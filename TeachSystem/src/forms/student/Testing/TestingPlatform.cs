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
    public partial class TestingPlatform : Form
    {
        Test test;
        int questonNumber;
        int rightAnswer = -1;
        RadioButton[] answerRadioButtons;
        public int score = 0;

        public TestingPlatform(Test testIn, int qNum)
        {
            InitializeComponent();
            test = testIn;
            questonNumber = qNum;
            answerRadioButtons = new RadioButton[test.questions[questonNumber].answers.Count];

            if(questonNumber == (test.questions.Count - 1))
            {
                nextQuestionButton.Text = "Завершить";
            }

            for (int i = 0; i < answerRadioButtons.Length; i++)
            {
                answerRadioButtons[i] = new RadioButton();
                answerRadioButtons[i].Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                answerRadioButtons[i].Name = "answerRadioButton {0}" + i;
                answerRadioButtons[i].Size = new Size(92, 25);
                answerRadioButtons[i].Text = test.questions[questonNumber].answers[i].text;
                answerRadioButtons[i].UseVisualStyleBackColor = true;
                answerRadioButtons[i].Location = new Point(35, 225 + 30*i);
                this.Controls.Add(answerRadioButtons[i]);
                if(test.questions[questonNumber].answers[i].isRight == 1)
                {
                    rightAnswer = i;
                }
            }
            answerRadioButtons[0].Checked = true;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (answerRadioButtons[rightAnswer].Checked)
            {
                score = 1;
            }
        }
    }
}
