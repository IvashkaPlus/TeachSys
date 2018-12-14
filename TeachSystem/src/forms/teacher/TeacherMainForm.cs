using System;
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
            dbConnection.Open();
            string testListFinder = "SELECT * FROM tests";
            SqlCommand sql = new SqlCommand(testListFinder, dbConnection);
            if (sql.ExecuteScalar() == null)
            {
                MessageBox.Show("Список тестов пуст. Пополните его первым!");
            } 
            else
            {
                SqlDataReader dataReader = sql.ExecuteReader();
            }
            dbConnection.Close();
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            Test tempTest = new Test();
            CreateTest createTestForm = null;
            createTestForm = new CreateTest(subjectsList);
            createTestForm.ShowDialog();
            tempTest = createTestForm.test;
            tempTest.teacherId = currentTeacher.teacherId;
            StringBuilder tempDate = new StringBuilder(DateTime.Now.ToString());
            String releaseDate = tempDate[6].ToString() + tempDate[7].ToString() + tempDate[8].ToString() + tempDate[9].ToString() + "-" + tempDate[3].ToString() + tempDate[4].ToString() + "-" + tempDate[0].ToString() + tempDate[1].ToString();
            tempTest.release_date = releaseDate;

            try
            {
                dbConnection.Open();
                string testCreation = "INSERT INTO tests (title, release_date, availability, teach_id, sub_id)" +
                                    " VALUES (@tit, @rel_date, @avail, @tId, @subId)";
                SqlCommand sql = new SqlCommand(testCreation, dbConnection);
                sql.Parameters.AddWithValue("@tit", tempTest.title);
                sql.Parameters.AddWithValue("@rel_date", tempTest.release_date);
                sql.Parameters.AddWithValue("@avail", 1);
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
                dbConnection.Close();
                MessageBox.Show("Тест успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания теста: " + ex);
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
    }
}
