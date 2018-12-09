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
                subjectsList.Add(Convert.ToInt32(dataReader["subject_id"].ToString()), dataReader["title"].ToString());
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

        }
    }
}
