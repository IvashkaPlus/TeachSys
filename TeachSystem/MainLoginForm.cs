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
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try { 
                SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
                sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
                sqlConnection.UserID = "sa";
                sqlConnection.Password = "root";
                sqlConnection.InitialCatalog = "TeachSystemDB";
                SqlConnection dbConnection = new SqlConnection(sqlConnection.ConnectionString);
                string sqlCommand = "SELECT * FROM teachers WHERE teacher_id = \'" + loginBox.Text
                    + "\' AND t_password = \'" + passwordBox.Text + "\'";
                dbConnection.Open();
                SqlCommand sql = new SqlCommand(sqlCommand, dbConnection);
                if (sql.ExecuteScalar() != null)
                {
                    loginStatusLable.ForeColor = Color.DarkGreen;
                    loginStatusLable.Text = "Вход выполнен";
                    loginStatusLable.Visible = true;
                    Properties.Settings.Default.logined = true;
                    Properties.Settings.Default.teacher_id = loginBox.Text;
                    this.Close();
                }
                else
                {
                    loginStatusLable.ForeColor = Color.Firebrick;
                    loginStatusLable.Text = "Неверный логин или пароль";
                    loginStatusLable.Visible = true;
                }
            }
            catch
            {
                loginStatusLable.ForeColor = Color.Firebrick;
                loginStatusLable.Text = "Ошибка подключения к серверу";
                loginStatusLable.Visible = true;
            }

        }
    }
}
