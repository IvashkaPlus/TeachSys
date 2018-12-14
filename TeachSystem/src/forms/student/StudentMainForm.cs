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
            string testListFinder = "select DISTINCT test.title, teach.last_name, test.release_date, acc.test_status " +
                "from tests test JOIN teachers teach on test.teach_id = teach.teacher_id " +
                "JOIN list_test_access acc on test.test_id = acc.l_test_id " +
                "where acc.l_group_id  = "  +  currentStudent.sGroupId;

            SqlCommand sql = new SqlCommand(testListFinder, dbConnection);
            SqlDataReader dataReader = sql.ExecuteReader();
            while (dataReader.Read())
            {
                StringBuilder rDate = new StringBuilder(dataReader["release_date"].ToString(), 0, 10, 10);
                ListViewItem tempItem = new ListViewItem(dataReader["title"].ToString());
                tempItem.SubItems.Add(dataReader["last_name"].ToString());
                tempItem.SubItems.Add(rDate.ToString());
                tempItem.SubItems.Add(dataReader["test_status"].ToString());
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
                dbConnection.Close();

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
    }
}
