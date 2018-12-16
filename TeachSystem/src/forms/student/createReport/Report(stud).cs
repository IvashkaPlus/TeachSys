using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TeachSystem
{
    public partial class Report_stud : Form
    {
        List<ReportStud> reports = new List<ReportStud>();
        public Report_stud(List<ReportStud> reportsIncome)
        {
            InitializeComponent();
            reports = reportsIncome;
            List<string> tempTitleList = new List<string>();
            foreach(ReportStud rep in reports)
            {
                tempTitleList.Add(rep.testTitle);
                reportView.Rows.Add(rep.testTitle, rep.lastName, rep.grade);
            }
            List<string> idealTitleList = new List<string>(tempTitleList.Distinct()); 
            foreach(string title in idealTitleList)
                testTitleBox.Items.Add(title);
            tempTitleList.Clear();
            idealTitleList.Clear();
            
        }

        private void testTitleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempTestTitle = testTitleBox.Text;
            reportView.Rows.Clear();
            foreach(ReportStud rep in reports)
                if(rep.testTitle == tempTestTitle)
                    reportView.Rows.Add(rep.lastName, rep.testTitle, rep.grade);
        }

        private void closeReportForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void printReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(reportView.Size.Width + 10, reportView.Size.Height + 10);
            reportView.DrawToBitmap(bmp, reportView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printReportButton_Click(object sender, EventArgs e)
        {
            printReportPreviewDialog.ShowDialog();
        }
    }
}
