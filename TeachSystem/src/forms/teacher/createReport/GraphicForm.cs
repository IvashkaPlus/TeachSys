using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeachSystem { 

    public partial class GraphicForm : Form
    {
        List<ReportTeach> reports = new List<ReportTeach>();
        List<string> idealTitleList;

        public GraphicForm(List<ReportTeach> reportsIncome, Dictionary<int, string> subjectsList)
        {
            InitializeComponent();
            reports = reportsIncome;
            foreach (KeyValuePair<int, string> sub in subjectsList)
                subTitleBox.Items.Add(sub.Value);
            List<string> tempGroupList = new List<string>();
            foreach (ReportTeach rep in reports)
                tempGroupList.Add(rep.groupName);
            idealTitleList = new List<string>(tempGroupList.Distinct());
        }

        private void subTitleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            avgGradeChart.Series[0].Points.Clear();
            foreach(ReportTeach rep in reports)
                if (subTitleBox.Text == rep.subjectTitle)
                    avgGradeChart.Series[0].Points.AddXY(idealTitleList.IndexOf(rep.groupName), rep.avgGrade);
            for(int i = 0; i < idealTitleList.Count; i++)
            {
                avgGradeChart.Series[0].Points[i].Label = idealTitleList[i];
            }
        }
    }
}
