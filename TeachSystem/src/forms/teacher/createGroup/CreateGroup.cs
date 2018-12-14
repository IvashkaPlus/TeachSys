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
    public partial class CreateGroup : Form
    {
        SqlConnectionStringBuilder sqlConnection;
        SqlConnection dbConnection;

        public CreateGroup()
        {
            InitializeComponent();
        }

        private void Создать_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID = "sa";
            sqlConnection.Password = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);

            string GroupName = GroupBox.Text.ToString();
            string checkGroup = "SELECT t_group_id FROM teach_groups WHERE name = \'" + GroupName + "\'";
            SqlCommand sql = new SqlCommand(checkGroup, dbConnection);
            dbConnection.Open();
            if(sql.ExecuteScalar() != null)
            {
                MessageBox.Show("Данная группа уже существует");
                dbConnection.Close();
                return;
            }
            dbConnection.Close();

            string newGroup = "INSERT INTO teach_groups (name) VALUES (@name)";
            sql = new SqlCommand(newGroup, dbConnection);
            sql.Parameters.AddWithValue("@name", GroupName);
            try
            {
                dbConnection.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Группа добавлена");
                this.Close();
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}
