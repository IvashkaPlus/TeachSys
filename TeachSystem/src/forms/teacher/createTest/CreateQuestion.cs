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
    public partial class CreateQuestion : Form
    {
        public Question question;
        List<Answer> tempList = new List<Answer>();

        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void createQuestionButton_Click(object sender, EventArgs e)
        {
            question = new Question(titBox.Text);
            question.answers = tempList;
        }

        private void addAnswerButton_Click(object sender, EventArgs e)
        {
            CreateAnswer answerForm = new CreateAnswer();
            if(answerForm.ShowDialog(this) == DialogResult.OK)
            {
                tempList.Add(answerForm.answer);
                listViewAnswer.Items.Add(answerForm.answer.text, answerForm.answer.isRight.ToString());
            }
        }
    }
}
