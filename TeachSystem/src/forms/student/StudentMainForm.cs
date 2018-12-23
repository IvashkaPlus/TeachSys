using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeachSystem
{
    public partial class StudentMainForm : Form
    {
        SqlConnectionStringBuilder sqlConnection;
        SqlConnection dbConnection;
        Student currentStudent;

        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void aboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
            aboutBox.Dispose();
        }

        private void updateTestListButton_Click(object sender, EventArgs e)
        {
            listViewTests.Items.Clear();
            dbConnection.Open();
            string testListFinder = "select DISTINCT test.title, teach.last_name, acc.dead_line_date " +
                "from tests test JOIN teachers teach on test.teach_id = teach.teacher_id " +
                "JOIN list_test_access acc on test.test_id = acc.l_test_id " +
                "where acc.l_stud_id  = \'" + currentStudent.studentId + "\'";

            SqlCommand sql = new SqlCommand(testListFinder, dbConnection);
            SqlDataReader dataReader = sql.ExecuteReader();
            if (dataReader.RecordsAffected == -1){
                return;
            }
            while (dataReader.Read())
            {
                StringBuilder rDate = new StringBuilder(dataReader["dead_line_date"].ToString(), 0, 10, 10);
                ListViewItem tempItem = new ListViewItem(dataReader["title"].ToString());
                tempItem.SubItems.Add(dataReader["last_name"].ToString());
                tempItem.SubItems.Add(rDate.ToString());
                listViewTests.Items.Add(tempItem);
            }
            dataReader.Close();
            dbConnection.Close();
        }

        private void beginTestButton_Click(object sender, EventArgs e)
        {
            if (listViewTests.SelectedIndices.Count != 0)
            {
                Test choosedTest = new Test();
                ListView.SelectedIndexCollection selected = listViewTests.SelectedIndices;
                string testTitle = listViewTests.Items[selected[0]].Text;
                dbConnection.Open();
                string getTest = "SELECT test_id, release_date, sub_id " +
                                 "FROM tests " +
                                 "WHERE title = \'" + testTitle + "\'";
                SqlCommand sql = new SqlCommand(getTest, dbConnection);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                choosedTest.title = testTitle;
                choosedTest.subjectId = Convert.ToInt32(reader["sub_id"]);
                choosedTest.release_date = reader["release_date"].ToString();
                choosedTest.testId = Convert.ToInt32(reader["test_id"]);
                reader.Close();

                string getQuestions = "SELECT q_text, question_id " +
                                      "FROM questions " +
                                      "WHERE test_q_id = " + choosedTest.testId;
                choosedTest.questions = new List<Question>();
                sql = new SqlCommand(getQuestions, dbConnection);
                reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    string qText = StringEditor.SpaceDeliting(reader["q_text"].ToString());
                    choosedTest.questions.Add(new Question(qText, Convert.ToInt32(reader["question_id"])));
                }
                reader.Close();

                for (int i = 0; i < choosedTest.questions.Count; i++)
                {
                    choosedTest.questions[i].answers = new List<Answer>();
                    string getAnswres = "SELECT a_text, isRight " +
                                        "FROM answers " +
                                        "WHERE question_a_id = " + choosedTest.questions[i].questionId;
                    sql = new SqlCommand(getAnswres, dbConnection);
                    reader = sql.ExecuteReader();
                    while (reader.Read())
                    {
                        int isR = -1;
                        if (Convert.ToBoolean(reader["isRight"]))
                            isR = 1;
                        else
                            isR = 0;
                        string aText = StringEditor.SpaceDeliting(reader["a_text"].ToString());
                        choosedTest.questions[i].answers.Add(new Answer(aText, isR));
                    }
                    reader.Close();
                }

                string getGradeCriteria = "SELECT for5, for4, for3 " +
                                          "FROM grade_criteria " +
                                          "WHERE test_c_id = " + choosedTest.testId;
                sql = new SqlCommand(getGradeCriteria, dbConnection);
                reader = sql.ExecuteReader();
                reader.Read();
                choosedTest.criteria = new GradeCriteria(Convert.ToInt32(reader["for5"]), Convert.ToInt32(reader["for4"]), Convert.ToInt32(reader["for3"]));
                reader.Close();

                string getSubjectId = "SELECT title FROM subjects WHERE subject_id = "
                                + choosedTest.subjectId;
                sql = new SqlCommand(getSubjectId, dbConnection);
                reader = sql.ExecuteReader();
                reader.Read();
                string subTitle = StringEditor.SpaceDeliting(reader["title"].ToString());
                reader.Close();
                dbConnection.Close();
                TestInfoForm testInfo = new TestInfoForm(choosedTest, subTitle);
                if (testInfo.ShowDialog() == DialogResult.OK)
                {
                    int resultScore = 0;
                    int resultGrade;
                    for (int i = 0; i < choosedTest.questions.Count; i++)
                    {
                        TestingPlatform testing = new TestingPlatform(choosedTest, i);
                        testing.titleLable.Text += choosedTest.title;
                        testing.questionLable.Text += i+1;
                        testing.questText.Text = choosedTest.questions[i].text;
                        if (testing.ShowDialog() == DialogResult.OK)
                        {
                            resultScore += testing.score;
                        }
                        else
                        {
                            MessageBox.Show("Тестирование сброшено");
                            return;
                        }
                    }
                    double percent = Convert.ToDouble(resultScore) / Convert.ToDouble(choosedTest.questions.Count) * 100;
                    if (percent >= choosedTest.criteria.for5)
                    {
                        resultGrade = 5;
                    }
                    else if (percent >= choosedTest.criteria.for4)
                    {
                        resultGrade = 4;
                    }
                    else if (percent >= choosedTest.criteria.for3)
                    {
                        resultGrade = 3;
                    }
                    else
                    {
                        resultGrade = 2;
                    }
                    TestResultForm testResult = new TestResultForm(choosedTest, subTitle, resultGrade, resultScore);
                    testResult.ShowDialog();
                    string setNewResult = "INSERT INTO reports VALUES(@stud_id, @test_id, @grade)";
                    sql = new SqlCommand(setNewResult, dbConnection);
                    sql.Parameters.AddWithValue("@stud_id", currentStudent.studentId);
                    sql.Parameters.AddWithValue("@test_id", choosedTest.testId);
                    sql.Parameters.AddWithValue("@grade", resultGrade);
                    dbConnection.Open();
                    sql.ExecuteNonQuery();
                    string updateAccess;
                    updateAccess = "UPDATE list_test_access SET dead_line_date = @date, test_status = 0  WHERE l_stud_id = @studId AND l_test_id = @test_id";
                    sql = new SqlCommand(updateAccess, dbConnection);
                    sql.Parameters.AddWithValue("@studId", currentStudent.studentId);
                    sql.Parameters.AddWithValue("@date", DBNull.Value);
                    sql.Parameters.AddWithValue("@test_id", choosedTest.testId);
                    sql.ExecuteNonQuery();
                    dbConnection.Close();
                    listViewTests.Items.Clear();
                }
            }
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID = "sa";
            sqlConnection.Password = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);

            string currentStudentFinder = "SELECT * FROM students WHERE student_id = \'"
                                        + Properties.Settings.Default.student_id + "\'";
            dbConnection.Open();
            SqlCommand sql = new SqlCommand(currentStudentFinder, dbConnection);
            SqlDataReader dataReader = sql.ExecuteReader();
            dataReader.Read();
            currentStudent = new Student(dataReader["student_id"].ToString(),
                                        dataReader["first_name"].ToString(),
                                        dataReader["last_name"].ToString(),
                                        dataReader["email"].ToString(),
                                        Convert.ToInt32(dataReader["s_group_id"].ToString()));
            dataReader.Close();

            string getGroup = "SELECT * FROM teach_groups";
            sql = new SqlCommand(getGroup, dbConnection);
            SqlDataReader groupReader = sql.ExecuteReader();
            Dictionary<int, string> groups = new Dictionary<int, string>();
            while (groupReader.Read())
            {
                groups.Add(Convert.ToInt32(groupReader["t_group_id"]), groupReader["name"].ToString());
            }

            groupReader.Close();

            dbConnection.Close();
            this.Text += " - " + currentStudent.sLastName;
            studFNLable.Text = currentStudent.sFirstName;
            studLNLable.Text = currentStudent.sLastName;
            studGroupLable.Text = groups[currentStudent.sGroupId];
            groups.Clear();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            List<ReportStud> reportsList = new List<ReportStud>();
            string creatingStudentReport = "SELECT test.title, stud.last_name, rep.grade " +
                "FROM tests test " +
                "JOIN reports rep ON rep.l_test_id = test.test_id " +
                "JOIN students stud ON rep.r_student_id = stud.student_id " +
                "WHERE s_group_id = \'" + currentStudent.sGroupId + "\'";
            SqlCommand sql = new SqlCommand(creatingStudentReport, dbConnection);
            dbConnection.Open();
            SqlDataReader dataReader = sql.ExecuteReader();
            while (dataReader.Read())
            {
                string lastName = StringEditor.SpaceDeliting(dataReader["last_name"].ToString());
                string testTitle = StringEditor.SpaceDeliting(dataReader["title"].ToString());
                reportsList.Add(new ReportStud(lastName, testTitle, Convert.ToInt32(dataReader["grade"])));
            }
            Report_stud report_StudForm = new Report_stud(reportsList);
            report_StudForm.ShowDialog();
            dataReader.Close();
            dbConnection.Close();
        }
    }
}
