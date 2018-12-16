namespace TeachSystem
{
    partial class Report_teach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_teach));
            this.closeReportForm = new System.Windows.Forms.Button();
            this.printReportButton = new System.Windows.Forms.Button();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.subTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLable = new System.Windows.Forms.Label();
            this.graphButton = new System.Windows.Forms.Button();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.printReportPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeReportForm
            // 
            this.closeReportForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeReportForm.Location = new System.Drawing.Point(713, 429);
            this.closeReportForm.Name = "closeReportForm";
            this.closeReportForm.Size = new System.Drawing.Size(75, 25);
            this.closeReportForm.TabIndex = 22;
            this.closeReportForm.Text = "Закрыть";
            this.closeReportForm.UseVisualStyleBackColor = true;
            this.closeReportForm.Click += new System.EventHandler(this.closeReportForm_Click);
            // 
            // printReportButton
            // 
            this.printReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printReportButton.Location = new System.Drawing.Point(713, 68);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(75, 25);
            this.printReportButton.TabIndex = 21;
            this.printReportButton.Text = "Печать";
            this.printReportButton.UseVisualStyleBackColor = true;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // reportView
            // 
            this.reportView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subTitle,
            this.lastName,
            this.grade});
            this.reportView.Location = new System.Drawing.Point(17, 113);
            this.reportView.Name = "reportView";
            this.reportView.Size = new System.Drawing.Size(771, 309);
            this.reportView.TabIndex = 20;
            // 
            // subTitle
            // 
            this.subTitle.HeaderText = "Предмет";
            this.subTitle.Name = "subTitle";
            this.subTitle.ReadOnly = true;
            this.subTitle.Width = 400;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Группа";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.HeaderText = "Средняя оценка по предмету";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            this.grade.Width = 225;
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(12, 12);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(70, 30);
            this.titleLable.TabIndex = 18;
            this.titleLable.Text = "Отчет";
            // 
            // graphButton
            // 
            this.graphButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphButton.Location = new System.Drawing.Point(630, 68);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(77, 25);
            this.graphButton.TabIndex = 23;
            this.graphButton.Text = "График";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // printReport
            // 
            this.printReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReport_PrintPage);
            // 
            // printReportPreviewDialog
            // 
            this.printReportPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printReportPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printReportPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printReportPreviewDialog.Document = this.printReport;
            this.printReportPreviewDialog.Enabled = true;
            this.printReportPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printReportPreviewDialog.Icon")));
            this.printReportPreviewDialog.Name = "printReportPreviewDialog";
            this.printReportPreviewDialog.Visible = false;
            // 
            // Report_teach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.closeReportForm);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.reportView);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_teach";
            this.Text = "TeachSystem - Отчет";
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeReportForm;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.DataGridView reportView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Button graphButton;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.PrintPreviewDialog printReportPreviewDialog;
    }
}