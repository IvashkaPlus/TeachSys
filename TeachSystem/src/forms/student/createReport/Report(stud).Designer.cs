namespace TeachSystem
{
    partial class Report_stud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_stud));
            this.testTitleBox = new System.Windows.Forms.ComboBox();
            this.titleLable = new System.Windows.Forms.Label();
            this.titLable = new System.Windows.Forms.Label();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.testTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printReportButton = new System.Windows.Forms.Button();
            this.closeReportForm = new System.Windows.Forms.Button();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.printReportPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            this.SuspendLayout();
            // 
            // testTitleBox
            // 
            this.testTitleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testTitleBox.FormattingEnabled = true;
            this.testTitleBox.Location = new System.Drawing.Point(17, 84);
            this.testTitleBox.Name = "testTitleBox";
            this.testTitleBox.Size = new System.Drawing.Size(309, 21);
            this.testTitleBox.TabIndex = 0;
            this.testTitleBox.SelectedIndexChanged += new System.EventHandler(this.testTitleBox_SelectedIndexChanged);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(12, 12);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(70, 30);
            this.titleLable.TabIndex = 9;
            this.titleLable.Text = "Отчет";
            // 
            // titLable
            // 
            this.titLable.AutoSize = true;
            this.titLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLable.Location = new System.Drawing.Point(13, 60);
            this.titLable.Name = "titLable";
            this.titLable.Size = new System.Drawing.Size(119, 21);
            this.titLable.TabIndex = 10;
            this.titLable.Text = "Название теста";
            // 
            // reportView
            // 
            this.reportView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testTitle,
            this.lastName,
            this.grade});
            this.reportView.Location = new System.Drawing.Point(17, 129);
            this.reportView.Name = "reportView";
            this.reportView.Size = new System.Drawing.Size(771, 309);
            this.reportView.TabIndex = 11;
            // 
            // testTitle
            // 
            this.testTitle.HeaderText = "Название теста";
            this.testTitle.Name = "testTitle";
            this.testTitle.ReadOnly = true;
            this.testTitle.Width = 400;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия студента";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 200;
            // 
            // grade
            // 
            this.grade.HeaderText = "Оценка за тест";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            this.grade.Width = 125;
            // 
            // printReportButton
            // 
            this.printReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printReportButton.Location = new System.Drawing.Point(713, 84);
            this.printReportButton.Name = "printReportButton";
            this.printReportButton.Size = new System.Drawing.Size(75, 25);
            this.printReportButton.TabIndex = 15;
            this.printReportButton.Text = "Печать";
            this.printReportButton.UseVisualStyleBackColor = true;
            this.printReportButton.Click += new System.EventHandler(this.printReportButton_Click);
            // 
            // closeReportForm
            // 
            this.closeReportForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeReportForm.Location = new System.Drawing.Point(713, 445);
            this.closeReportForm.Name = "closeReportForm";
            this.closeReportForm.Size = new System.Drawing.Size(75, 25);
            this.closeReportForm.TabIndex = 16;
            this.closeReportForm.Text = "Закрыть";
            this.closeReportForm.UseVisualStyleBackColor = true;
            this.closeReportForm.Click += new System.EventHandler(this.closeReportForm_Click);
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
            // Report_stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.closeReportForm);
            this.Controls.Add(this.printReportButton);
            this.Controls.Add(this.reportView);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.testTitleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report_stud";
            this.Text = "TeachSystem - Отчет";
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox testTitleBox;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label titLable;
        private System.Windows.Forms.DataGridView reportView;
        private System.Windows.Forms.Button printReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn testTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.Button closeReportForm;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.PrintPreviewDialog printReportPreviewDialog;
    }
}