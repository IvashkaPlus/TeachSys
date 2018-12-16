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
    public partial class Report_teach : Form
    {
        List<ReportTeach> reports = new List<ReportTeach>();
        GraphicForm graphicForm;

        public Report_teach(List<ReportTeach> gradeReports, Dictionary<int, string> subjectsList)
        {
            InitializeComponent();
            reports = gradeReports;
            foreach (ReportTeach rep in reports)
                reportView.Rows.Add(rep.subjectTitle, rep.groupName, rep.avgGrade);
            graphicForm = new GraphicForm(reports, subjectsList);
        }

        private void closeReportForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printReportButton_Click(object sender, EventArgs e)
        {
            printReportPreviewDialog.ShowDialog();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            
            graphicForm.ShowDialog();
        }

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(reportView.Size.Width + 10, reportView.Size.Height + 10);
            reportView.DrawToBitmap(bmp, reportView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
