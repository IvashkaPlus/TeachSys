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
    public partial class CreateTeacher : Form
    {
        SqlConnectionStringBuilder sqlConnection;
        SqlConnection dbConnection;

        public Dictionary<int, string> subjectsList = new Dictionary<int, string>();

        public CreateTeacher()
        {
            InitializeComponent();
        }
        public CreateTeacher(Dictionary<int, string> subList)
        {
            InitializeComponent();
            subjectsList = subList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID = "sa";
            sqlConnection.Password = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);

            string TeacherId = LoginBox.Text.ToString();
            string TeacherName = NameBox.Text.ToString();
            string TeacherLast_Name = LastNameBox.Text.ToString();
            string TeacherPatronymic = PatronymicBox.Text.ToString();
            string TeacherSci_degree = SciDegreeBox.Text.ToString();
            string TeacherPhone_number = PhoneNumberBox.Text.ToString();
            string TeacherEmail = EmailBox.Text.ToString();
            string TeacherPassword = PasswordBox.Text.ToString();
            string sub = subBox.Text.ToString();
            int subId = 0;
            foreach(KeyValuePair<int, string> subInfo in subjectsList)
            {
                if(subInfo.Value.IndexOf(sub) != -1)
                {
                    subId = subInfo.Key;
                    break;
                }
            }
            if (subId == 0)
            {
                MessageBox.Show("Данного предмета нет в списке");
                return;
            }

            string newTeacher = "INSERT INTO teachers (teacher_id, first_name, last_name, email, sci_degree, phone_number, patronymic, t_password, sub_id) VALUES (@teacher_id, @first_name, @last_name, @email, @sci_degree, @phone_number, @patronymic, @t_password, @sub)";
            SqlCommand sql = new SqlCommand(newTeacher, dbConnection);

            sql.Parameters.AddWithValue("@teacher_id", TeacherId);
            sql.Parameters.AddWithValue("@first_name", TeacherName);
            sql.Parameters.AddWithValue("@last_name", TeacherLast_Name);
            sql.Parameters.AddWithValue("@email", TeacherEmail);
            sql.Parameters.AddWithValue("@sci_degree", TeacherSci_degree);
            sql.Parameters.AddWithValue("@phone_number", TeacherPhone_number);
            sql.Parameters.AddWithValue("@patronymic", TeacherPatronymic);
            sql.Parameters.AddWithValue("@t_password", TeacherPassword);
            sql.Parameters.AddWithValue("@sub", subId);
            try
            {
                dbConnection.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Преподаватель добавлен");
                this.Close();
            }
            catch 
            {
                
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
