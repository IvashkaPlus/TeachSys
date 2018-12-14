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
    public partial class CreateStudent : Form
    {
        SqlConnectionStringBuilder sqlConnection;
        SqlConnection dbConnection;

        public CreateStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID = "sa";
            sqlConnection.Password = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);

            string StudentId = LoginBox.Text.ToString();
            string StudentName = NameBox.Text.ToString();
            string StudentLast_Name = LastNameBox.Text.ToString();
            string StudentEmail = EmailBox.Text.ToString();
            string StudentPassword = PasswordBox.Text.ToString();
            string StudentGroup = GroupBox.Text.ToString();

            string groupCheck = "SELECT t_group_id FROM teach_groups WHERE name = \'" + StudentGroup + "\'";

            SqlCommand sql = new SqlCommand(groupCheck, dbConnection);
            int group;
            dbConnection.Open();
            if (sql.ExecuteScalar() == null)
            {
                MessageBox.Show("Данной группы не существует");
                dbConnection.Close();
                return;
            } else
            {
                group = Convert.ToInt32(sql.ExecuteScalar());
            }
            dbConnection.Close();

            string newStudent = "INSERT INTO students (student_id, first_name, last_name, email, s_password, s_group_id) VALUES (@student_id, @first_name, @last_name, @email, @s_password, @s_group_id)";
            sql = new SqlCommand(newStudent, dbConnection);

            sql.Parameters.AddWithValue("@student_id", StudentId);
            sql.Parameters.AddWithValue("@first_name", StudentName);
            sql.Parameters.AddWithValue("@last_name", StudentLast_Name);
            sql.Parameters.AddWithValue("@email", StudentEmail);
            sql.Parameters.AddWithValue("@s_password", StudentPassword);
            sql.Parameters.AddWithValue("@s_group_id", group);
            try
            {
                dbConnection.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Студент успешно добавлен");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
