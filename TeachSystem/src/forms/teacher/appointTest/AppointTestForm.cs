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
    public partial class AppointTestForm : Form
    {
        SqlConnectionStringBuilder sqlConnection;
        SqlConnection dbConnection;
        Dictionary<int, string> groups = new Dictionary<int, string>();
        List<string> studentIds = new List<string>();
        int testId;

        public AppointTestForm(int TestId)
        {
            InitializeComponent();
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID = "sa";
            sqlConnection.Password = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);
            dbConnection.Open();
            string getGroup = "SELECT * FROM teach_groups";
            SqlCommand sql = new SqlCommand(getGroup, dbConnection);
            SqlDataReader groupReader = sql.ExecuteReader();
            while (groupReader.Read())
            {
                string tempGroupName = StringEditor.SpaceDeliting(groupReader["name"].ToString());
                groups.Add(Convert.ToInt32(groupReader["t_group_id"]), tempGroupName);
                groupList.Items.Add(tempGroupName);
            }
            groupReader.Close();
            dbConnection.Close();
            testId = TestId;
        }

        private void updateAccessList()
        {
            listViewAccess.Items.Clear();
            int tempGroupId = 0;
            foreach (KeyValuePair<int, string> pair in groups)
                if (pair.Value == groupList.Text)
                {
                    tempGroupId = pair.Key;
                    break;
                }
            string getStudents = "select stud.last_name, stud.first_name, list.test_status, list.dead_line_date,  stud.student_id " +
                "from students stud LEFT OUTER JOIN list_test_access list ON stud.student_id = list.l_stud_id " +
                "where stud.s_group_id = " + tempGroupId + " AND list.l_test_id = " + testId;
            SqlCommand sql = new SqlCommand(getStudents, dbConnection);
            dbConnection.Open();
            SqlDataReader studentReader = sql.ExecuteReader();
            while (studentReader.Read())
            {
                string studentFullName = StringEditor.SpaceDeliting(studentReader["last_name"].ToString() +
                                    "_" + StringEditor.SpaceDeliting(studentReader["first_name"].ToString()));
                studentFullName = studentFullName.Replace('_', ' ');
                ListViewItem tempItem = new ListViewItem(studentFullName);
                string ts = studentReader["test_status"].ToString();
                if (studentReader["test_status"].ToString() != "")
                {
                    tempItem.SubItems.Add("+");
                    tempItem.SubItems.Add(StringEditor.SpaceDeliting(studentReader["dead_line_date"].ToString()));
                }
                else
                {
                    tempItem.SubItems.Add("-");
                }
                listViewAccess.Items.Add(tempItem);
            }
            dbConnection.Close();
        }

        private void groupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewAccess.Items.Clear();
            studentIds.Clear();
            int tempGroupId = 0;
            foreach (KeyValuePair<int, string> pair in groups)
                if (pair.Value == groupList.Text)
                {
                    tempGroupId = pair.Key;
                    break;
                }
            string getStudents = "select stud.last_name, stud.first_name, list.test_status, list.dead_line_date,  stud.student_id " +
                "from students stud LEFT OUTER JOIN list_test_access list ON stud.student_id = list.l_stud_id " +
                "where stud.s_group_id = " + tempGroupId + " AND list.l_test_id = " + testId;
            SqlCommand sql = new SqlCommand(getStudents, dbConnection);
            dbConnection.Open();
            SqlDataReader studentReader = sql.ExecuteReader();
            while (studentReader.Read())
            {
                string studentFullName = StringEditor.SpaceDeliting(studentReader["last_name"].ToString() + 
                                    "_" + StringEditor.SpaceDeliting(studentReader["first_name"].ToString()));
                studentFullName = studentFullName.Replace('_', ' ');
                ListViewItem tempItem = new ListViewItem(studentFullName);
                string ts = studentReader["test_status"].ToString();
                if (studentReader["test_status"].ToString() != "False")
                {
                    tempItem.SubItems.Add("+");
                    tempItem.SubItems.Add(StringEditor.SpaceDeliting(studentReader["dead_line_date"].ToString()));
                }
                else
                {
                    tempItem.SubItems.Add("-");
                }
                listViewAccess.Items.Add(tempItem);
                studentIds.Add(StringEditor.SpaceDeliting(studentReader["student_id"].ToString()));
            }
            dbConnection.Close();
        }

        private void appointTestButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selected = listViewAccess.SelectedIndices;
            DateTime deadLineDate = deadLineDatePicker.Value;
            DateTime nowDate = DateTime.Now;
            if(deadLineDate <= nowDate)
            {
                MessageBox.Show("Некорректный ввод даты");
                return;
            }
            StringBuilder tempDate = new StringBuilder(deadLineDate.ToString());
            String dlDate = tempDate[6].ToString() + tempDate[7].ToString() + tempDate[8].ToString() + tempDate[9].ToString() + "-" + tempDate[3].ToString() + tempDate[4].ToString() + "-" + tempDate[0].ToString() + tempDate[1].ToString();
            if (selected.Count != 0)
            {
                dbConnection.Open();
                foreach (int studId in selected)
                {
                    SqlCommand sql;
                    string updateAccess;
                    updateAccess = "UPDATE list_test_access SET dead_line_date = @date, test_status = 1  WHERE l_stud_id = @studId AND l_test_id = @testId";
                    sql = new SqlCommand(updateAccess, dbConnection);
                    sql.Parameters.AddWithValue("@studId", studentIds[studId]);
                    sql.Parameters.AddWithValue("@teseId", testId);
                    sql.Parameters.AddWithValue("@date", dlDate);
                    sql.ExecuteNonQuery();
                }
                dbConnection.Close();
                updateAccessList();
            }
        }
    }
}
