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
    public partial class CreateCriteria : Form
    {
        public GradeCriteria criteria;
        
        public CreateCriteria()
        {
            InitializeComponent();
        }
        private void createQuestionButton_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(tit3Box.Text) > 0 
                && Convert.ToInt32(tit3Box.Text) <= 100)
                || ((Convert.ToInt32(tit4Box.Text) > 0
                && Convert.ToInt32(tit4Box.Text) < Convert.ToInt32(tit5Box.Text)))
                || (Convert.ToInt32(tit3Box.Text) > 0
                && Convert.ToInt32(tit3Box.Text) <= Convert.ToInt32(tit4Box.Text)))
                criteria = new GradeCriteria(Convert.ToInt32(tit5Box.Text), Convert.ToInt32(tit4Box.Text), Convert.ToInt32(tit3Box.Text));
        }
    }
}
