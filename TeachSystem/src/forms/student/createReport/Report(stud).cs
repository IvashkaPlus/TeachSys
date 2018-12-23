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
                    reportView.Rows.Add(rep.testTitle, rep.lastName, rep.grade);
        }

        private void closeReportForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void printReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 20;
            int y = 20;
            string reportName = "Отчет по тесту - " + testTitleBox.Text;
            e.Graphics.DrawString(reportName, reportView.Font, new SolidBrush(Color.Black), new Point(x, y));
            y += 30;
            for (int i = 0; i < reportView.ColumnCount; i++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), x, y, reportView.Columns[i].Width, 21);
                e.Graphics.DrawString(reportView.Columns[i].HeaderText, reportView.Font, new SolidBrush(Color.Black), new Point(x, y));
                x += reportView.Columns[i].Width;
            }
            y += 21;
            for (int i = 0; i < reportView.RowCount - 1; i++)
            {
                x = 20;
                for (int j = 0; j < reportView.ColumnCount; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black), x, y, reportView[j, i].Size.Width, reportView[j, i].Size.Height);
                    e.Graphics.DrawString(reportView[j, i].Value.ToString(), reportView.Font, new SolidBrush(Color.Black), new Point(x, y));
                    x += reportView[j, i].Size.Width;
                }
                y += reportView[i, 0].Size.Height;
            }
        }
    

        private void printReportButton_Click(object sender, EventArgs e)
        {
            printReportPreviewDialog.ShowDialog();
        }
    }
}
