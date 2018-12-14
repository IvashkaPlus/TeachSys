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

        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void createQuestionButton_Click(object sender, EventArgs e)
        {
            question = new Question(titBox.Text);
        }
    }
}
