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
    public partial class TestResultForm : Form
    {
        public Test test = new Test();
        public string testSubTitle;

        public TestResultForm(Test testIn, string testTit, int grade, int rightAnswersCount)
        {
            InitializeComponent();
            test = testIn;
            testSubTitle = testTit;
            subTitle.Text = testSubTitle;
            titleLable.Text += test.title;
            rightAnswersLable.Text = "Кол-во правильных\nответов";
            raCount.Text = rightAnswersCount.ToString() + " из " + test.questions.Count.ToString();
            gradeInfo.Text = grade.ToString();
        }

        private void startTestingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
