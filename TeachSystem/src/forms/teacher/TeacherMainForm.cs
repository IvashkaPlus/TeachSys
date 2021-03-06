﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;

namespace TeachSystem
{
    public partial class TeacherMainForm : Form
    {
        SqlConnectionStringBuilder sqlConnection;
        SqlConnection dbConnection;
        Teacher currentTeacher;
        public Dictionary<int, string> subjectsList = new Dictionary<int, string>();
        List<int> testIds = new List<int>();
        public TeacherMainForm()
        {
            InitializeComponent();
        }

        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource     = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID         = "sa";
            sqlConnection.Password       = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);

            string currentTeacherFinder = "SELECT * FROM teachers WHERE teacher_id = \'" 
                + Properties.Settings.Default.teacher_id + "\'";

            dbConnection.Open();
            SqlCommand sql = new SqlCommand(currentTeacherFinder, dbConnection);
            SqlDataReader dataReader = sql.ExecuteReader();
            dataReader.Read();
            currentTeacher = new Teacher(dataReader["teacher_id"].ToString(),
                                        dataReader["first_name"].ToString(),
                                        dataReader["last_name"].ToString(),
                                        dataReader["email"].ToString(),
                                        dataReader["sci_degree"].ToString(),
                                        dataReader["phone_number"].ToString(),
                                        dataReader["patronymic"].ToString(),
                                        Convert.ToInt32(dataReader["sub_id"].ToString()));
            dataReader.Close();
            this.Text += " - " + currentTeacher.tLastName; 
            teachFNLable.Text = currentTeacher.tFirstName;
            teachLNLable.Text = currentTeacher.tLastName;
            teachSDLable.Text = currentTeacher.sciDegree;
            teachPLable.Text  = currentTeacher.patronym;
            listViewTests.Items.Add("Нажмите на \"Обновить список\" для загрузки тестов");
            string subjectsListFinder = "SELECT * FROM subjects";
            sql = new SqlCommand(subjectsListFinder, dbConnection);
            dataReader = sql.ExecuteReader();
            while(dataReader.Read())
            {
                StringBuilder tempName = new StringBuilder(dataReader["title"].ToString());
                int checkerSpace = 0;
                int delIndex = 0;
                for(int i = 0; i < tempName.Length; i++)
                {
                    char tru = tempName[10];
                    if (tempName[i].Equals(' '))
                    {
                        checkerSpace++;
                        delIndex = i;
                    }
                    else
                    {
                        checkerSpace = 0;
                    }
                    if(checkerSpace == 2)
                    {
                        tempName.Replace(" ", string.Empty, delIndex - 1, tempName.Length - delIndex + 1);
                        break;
                    }
                }
                subjectsList.Add(Convert.ToInt32(dataReader["subject_id"]), tempName.ToString());
            }
            dataReader.Close();
            dbConnection.Close();
        }
        private void updateTestListButton_Click(object sender, EventArgs e)
        {
            listViewTests.Items.Clear();
            dbConnection.Open();
            string testListFinder = "select test.title, teach.last_name, test.release_date, test.test_id " +
                "from TeachSystemDB.dbo.tests test INNER JOIN TeachSystemDB.dbo.teachers teach " +
                "on test.teach_id = teach.teacher_id";

            SqlCommand sql = new SqlCommand(testListFinder, dbConnection);
            if (sql.ExecuteScalar() == null)
            {
                MessageBox.Show("Список тестов пуст. Пополните его первым!");
            } 
            else
            {
                SqlDataReader dataReader = sql.ExecuteReader();
                while (dataReader.Read())
                {
                    StringBuilder rDate = new StringBuilder(dataReader["release_date"].ToString(), 0, 10, 10);
                    ListViewItem tempItem = new ListViewItem(dataReader["title"].ToString());
                    tempItem.SubItems.Add(dataReader["last_name"].ToString());
                    tempItem.SubItems.Add(rDate.ToString());
                    listViewTests.Items.Add(tempItem);
                    testIds.Add(Convert.ToInt32(dataReader["test_id"].ToString()));
                }
                dataReader.Close();
            }
            dbConnection.Close();
        }
        private void addTestButton_Click(object sender, EventArgs e)
        {
            Test tempTest = new Test();
            CreateTest createTestForm = null;
            createTestForm = new CreateTest(subjectsList);
            Dictionary<int, string> groups = new Dictionary<int, string>();
            List<string> studentIds = new List<string>();
            if(createTestForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            tempTest = createTestForm.test;
            tempTest.teacherId = currentTeacher.teacherId;
            StringBuilder tempDate = new StringBuilder(DateTime.Now.ToString());
            String releaseDate = tempDate[6].ToString() + tempDate[7].ToString() + tempDate[8].ToString() + tempDate[9].ToString() + "-" + tempDate[3].ToString() + tempDate[4].ToString() + "-" + tempDate[0].ToString() + tempDate[1].ToString();
            tempTest.release_date = releaseDate;

            try
            {
                dbConnection.Open();
                SqlCommand sql;
                string testCreation = "INSERT INTO tests (title, release_date, teach_id, sub_id)" +
                                    " VALUES (@tit, @rel_date, @tId, @subId)";
                sql = new SqlCommand(testCreation, dbConnection);
                sql.Parameters.AddWithValue("@tit", tempTest.title);
                sql.Parameters.AddWithValue("@rel_date", tempTest.release_date);
                sql.Parameters.AddWithValue("@tId", tempTest.teacherId);
                sql.Parameters.AddWithValue("@subId", tempTest.subjectId);
                sql.ExecuteNonQuery();
                
                string criteriaCreation = "INSERT INTO grade_criteria (for5, for4, for3, test_c_id) " +
                                          "VALUES (@f5, @f4, @f3, (SELECT MAX(test_id) FROM tests))";
                sql = new SqlCommand(criteriaCreation, dbConnection);
                sql.Parameters.AddWithValue("@f5", tempTest.criteria.for5);
                sql.Parameters.AddWithValue("@f4", tempTest.criteria.for4);
                sql.Parameters.AddWithValue("@f3", tempTest.criteria.for3);
                sql.ExecuteNonQuery();

                for (int i = 0; i < tempTest.questions.Count; i++)
                {
                    string questionCreation = "INSERT INTO questions (q_text, test_q_id)" +
                                                "VALUES (@qTitle, (SELECT MAX(test_id) FROM tests))";
                    sql = new SqlCommand(questionCreation, dbConnection);
                    sql.Parameters.AddWithValue("@qTitle", tempTest.questions[i].text);
                    sql.ExecuteNonQuery();
                    for (int j = 0; j < tempTest.questions[i].answers.Count; j++)
                    {
                        string answerCreation = "INSERT INTO answers (a_text, question_a_id, isRight)" +
                                                "VALUES (@aTitle, (SELECT MAX(question_id) FROM questions), @isR)";
                        sql = new SqlCommand(answerCreation, dbConnection);
                        sql.Parameters.AddWithValue("@aTitle", tempTest.questions[i].answers[j].text);
                        sql.Parameters.AddWithValue("@isR", tempTest.questions[i].answers[j].isRight);
                        sql.ExecuteNonQuery();
                    }
                }
                string getGroup = "SELECT * FROM teach_groups";
                sql = new SqlCommand(getGroup, dbConnection);
                SqlDataReader groupReader = sql.ExecuteReader();
                while (groupReader.Read())
                {
                    string tempGroupName = StringEditor.SpaceDeliting(groupReader["name"].ToString());
                    groups.Add(Convert.ToInt32(groupReader["t_group_id"]), tempGroupName);
                }
                groupReader.Close();
                foreach (KeyValuePair<int, string> pair in groups)
                {
                    int tempGroupId = pair.Key;
                    studentIds.Clear();
                    string getStudents = "select student_id " +
                                         "from students " +
                                         "where s_group_id = " + tempGroupId;
                    sql = new SqlCommand(getStudents, dbConnection);
                    SqlDataReader studentReader = sql.ExecuteReader();
                    while (studentReader.Read())
                        studentIds.Add(StringEditor.SpaceDeliting(studentReader["student_id"].ToString()));
                    studentReader.Close();
                    foreach (string stud in studentIds)
                    {
                        string updateAccess = "INSERT INTO list_test_access (l_test_id, test_status, l_stud_id) VALUES((SELECT MAX(test_id) FROM tests), @status, @studId)";
                        sql = new SqlCommand(updateAccess, dbConnection);
                        sql.Parameters.AddWithValue("@status", false);
                        sql.Parameters.AddWithValue("@studId", stud);
                        sql.ExecuteNonQuery();
                    }
                }
                dbConnection.Close();
                MessageBox.Show("Тест успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания теста: " + ex);
                dbConnection.Close();
            }
            
            
        }
        private void aboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
            aboutBox.Dispose();
        }
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            CreateTeacher createTeacher = new CreateTeacher(subjectsList);
            createTeacher.ShowDialog();
            createTeacher.Dispose();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudent createStud = new CreateStudent();
            createStud.ShowDialog();
            createStud.Dispose();
        }

        private void addTeachGroupButton_Click(object sender, EventArgs e)
        {
            CreateGroup group = new CreateGroup();
            group.ShowDialog();
            group.Dispose();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            string reportQuery = "SELECT sub.title, tg.name,  ROUND(AVG(rep.grade),1) as avgGrade " +
                "FROM reports rep " +
                "JOIN tests test ON test.test_id = rep.l_test_id " +
                "JOIN subjects sub ON test.sub_id = sub.subject_id " +
                "JOIN students stud ON stud.student_id = rep.r_student_id " +
                "JOIN teach_groups tg ON tg.t_group_id = stud.s_group_id " +
                "GROUP BY sub.title, tg.name";
            List<ReportTeach> reportList = new List<ReportTeach>();
            SqlCommand sql = new SqlCommand(reportQuery, dbConnection);
            dbConnection.Open();
            SqlDataReader dataReader = sql.ExecuteReader();
            while (dataReader.Read())
            {
                string subTitle  = StringEditor.SpaceDeliting(dataReader["title"].ToString());
                string groupName = StringEditor.SpaceDeliting(dataReader["name"].ToString());
                reportList.Add(new ReportTeach(subTitle, groupName, Convert.ToDouble(dataReader["avgGrade"])));
            }
            Report_teach report_TeachForm = new Report_teach(reportList, subjectsList);
            report_TeachForm.ShowDialog();
            dataReader.Close();
            dbConnection.Close();
        }

        private void appointTestButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selected = listViewTests.SelectedIndices;
            if(selected.Count == 0)
            {
                return;
            }
            AppointTestForm appoint = new AppointTestForm(testIds[selected[0]]);
            appoint.ShowDialog();
            appoint.Dispose();
        }
    }
}
