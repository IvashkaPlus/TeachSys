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
    public partial class TestInfoForm : Form
    {
        public Test test = new Test();
        public string testSubTitle;

        public TestInfoForm(Test testIn, string testTit)
        {
            InitializeComponent();
            test = testIn;
            testSubTitle = testTit;
            subTitle.Text = testSubTitle;
            titleLable.Text += test.title;
            qCount.Text = test.questions.Count.ToString();
            criteriaInfo.Text = "На оценку 5: " + test.criteria.for5.ToString()
                                    + "%;\nНа оценку 4: " + test.criteria.for4.ToString()
                                    + "%;\nНа оценку 3: " + test.criteria.for3.ToString() + "%";
        }

    }
}
