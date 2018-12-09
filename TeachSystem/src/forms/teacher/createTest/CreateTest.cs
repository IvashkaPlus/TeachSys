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
            foreach(object sub in subjects)
            {
                subjectList.Items.Add(sub.ToString());
            }
                     
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
            }
        }
    }
}
