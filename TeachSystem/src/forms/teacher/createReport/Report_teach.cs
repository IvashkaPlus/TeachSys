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
            int x = 20;
            int y = 20;
            e.Graphics.DrawString("Отчет по успеваемости групп", reportView.Font, new SolidBrush(Color.Black), new Point(x, y));
            y += 30;
            for (int i = 0; i < reportView.ColumnCount; i++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), x, y, reportView.Columns[i].Width, 21);
                e.Graphics.DrawString(reportView.Columns[i].HeaderText, reportView.Font, new SolidBrush(Color.Black), new Point(x,y));
                x += reportView.Columns[i].Width;
            }
            y += 21;
            for(int i = 0; i < reportView.RowCount - 1; i++)
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
    }
}
