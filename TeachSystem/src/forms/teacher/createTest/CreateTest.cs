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
    public partial class CreateTest : Form
    {
        public Test test = new Test();
        public Dictionary<int, string> subjects = new Dictionary<int, string>();
        public int teacherSubId;

        public CreateTest(Dictionary<int, string> subList)
        {
            InitializeComponent();
            subjects = subList;
            foreach (KeyValuePair<int, string> subInfo in subjects)
                subjectList.Items.Add(subInfo.Value);
            test.questions = new List<Question>();
            subjectList.SelectedIndex = 0;
        }

        private void addGradeCriteriaButton_Click(object sender, EventArgs e)
        {
            CreateCriteria createCriteria = new CreateCriteria();
            if(createCriteria.ShowDialog(this) == DialogResult.OK)
            {
                test.criteria = createCriteria.criteria;
                criteriaInfo.Text = "На оценку 5: " + test.criteria.for5.ToString() 
                                    + "%; На оценку 4: " + test.criteria.for4.ToString() 
                                    + "%; На оценку 3: " + test.criteria.for3.ToString() + "%";
            }
        }

        private void createTestButton_Click(object sender, EventArgs e)
        {
            test.title = titBox.Text;
            SqlConnectionStringBuilder sqlConnection;
            SqlConnection dbConnection;
            sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = "IVA-NOTEBOOK\\SQLEXPRESS";
            sqlConnection.UserID = "sa";
            sqlConnection.Password = "root";
            sqlConnection.InitialCatalog = "TeachSystemDB";
            dbConnection = new SqlConnection(sqlConnection.ConnectionString);
            int tempSubId = -1;
            string getSubjectId = "SELECT subject_id FROM subjects WHERE title = \'" 
                                + subjectList.Text.ToString() + "\'";

            dbConnection.Open();
            SqlCommand sql = new SqlCommand(getSubjectId, dbConnection);
            SqlDataReader dataReader = sql.ExecuteReader();
            dataReader.Read();
            tempSubId = Convert.ToInt32(dataReader["subject_id"]);
            dbConnection.Close();
            test.subjectId = tempSubId;
            this.Close();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            CreateQuestion createQuest = new CreateQuestion();
            if (createQuest.ShowDialog(this) == DialogResult.OK)
            {
                test.questions.Add(createQuest.question);
                ListViewItem tempItem = new ListViewItem((listViewQuest.Items.Count + 1).ToString());
                tempItem.SubItems.Add(createQuest.question.text);
                listViewQuest.Items.Add(tempItem);
                createQuest.Dispose();
            }
        }

        private void addAnswerButton_Click(object sender, EventArgs e)
        {
            if (listViewQuest.SelectedIndices.Count != 0)
            {
                ListView.SelectedIndexCollection selected = listViewQuest.SelectedIndices;
                CreateAnswer answerForm = new CreateAnswer();
                if (answerForm.ShowDialog(this) == DialogResult.OK)
                {
                    if(test.questions[selected[0]].answers == null)
                    {
                        test.questions[selected[0]].answers = new List<Answer>();
                    }
                    test.questions[selected[0]].answers.Add(answerForm.answer);
                    ListViewItem tempItem = new ListViewItem((listViewAnswer.Items.Count + 1).ToString());
                    tempItem.SubItems.Add(answerForm.answer.text);
                    if (answerForm.answer.isRight == 1)
                    {
                        tempItem.SubItems.Add("+");
                    }
                    else
                    {
                        tempItem.SubItems.Add(" ");
                    }
                    listViewAnswer.Items.Add(tempItem);
                }
            }
            else
            {
                MessageBox.Show("Выберите вопрос");
            }
           
        }

        private void listViewQuest_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            listViewAnswer.Items.Clear();
            string t = e.ToString();
            //ListView.SelectedIndexCollection selected = listViewQuest.SelectedIndices;
            if (test.questions[e.ItemIndex].answers == null)
            {
                return;
            }
            foreach (Answer an in test.questions[e.ItemIndex].answers)
            {
                ListViewItem tempItem = new ListViewItem((listViewAnswer.Items.Count + 1).ToString());
                tempItem.SubItems.Add(an.text);
                if (an.isRight == 1)
                {
                    tempItem.SubItems.Add("+");
                }
                else
                {
                    tempItem.SubItems.Add(" ");
                }
                listViewAnswer.Items.Add(tempItem);
            }
        }
    }
}
