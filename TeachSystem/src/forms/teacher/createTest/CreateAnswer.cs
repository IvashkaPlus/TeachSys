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
    public partial class CreateAnswer : Form
    {
        public Answer answer;

        public CreateAnswer()
        {
            InitializeComponent();
        }

        private void createAnswerButton_Click(object sender, EventArgs e)
        {
            if (titBox.Text != "")
            {
                answer = new Answer(titBox.Text, isRightCheckBox.Checked);
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите корректное значение!");
            }
        }

    }
}
