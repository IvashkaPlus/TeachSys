using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeachSystem
{
    public partial class CreateTest : Form
    {
        public Test test = new Test();
        public Dictionary<int, string> subjects = new Dictionary<int, string>();
        public int teacherSubId;

        public CreateTest()
        {
            InitializeComponent();
            //subjects = createTestForm.subjects;
            foreach (object sub in subjects)
                subjectList.Items.Add(sub.ToString());
            test.questions = new List<Question>();
        }

        private void addGradeCriteriaButton_Click(object sender, EventArgs e)
        {
            CreateCriteria createCriteria = new CreateCriteria();
            if(createCriteria.ShowDialog(this) == DialogResult.OK)
            {
                 test.criteria = createCriteria.criteria;
            }
        }

        private void createTestButton_Click(object sender, EventArgs e)
        {

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
                    if (answerForm.answer.isRight)
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

        private void listViewQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                if (an.isRight)
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
