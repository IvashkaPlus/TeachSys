namespace TeachSystem
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.createReportFuncGroup = new System.Windows.Forms.GroupBox();
            this.createReportButton = new System.Windows.Forms.Button();
            this.getTeacherListButton = new System.Windows.Forms.Button();
            this.getStudentListButton = new System.Windows.Forms.Button();
            this.aboutProgramButton = new System.Windows.Forms.Button();
            this.updateTestListButton = new System.Windows.Forms.Button();
            this.studGroupLable = new System.Windows.Forms.Label();
            this.userImageBox = new System.Windows.Forms.PictureBox();
            this.studLNLable = new System.Windows.Forms.Label();
            this.studFNLable = new System.Windows.Forms.Label();
            this.beginTestButton = new System.Windows.Forms.Button();
            this.listViewTests = new System.Windows.Forms.ListView();
            this.colTestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTestAviable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testListLable = new System.Windows.Forms.Label();
            this.createReportFuncGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createReportFuncGroup
            // 
            this.createReportFuncGroup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.createReportFuncGroup.Controls.Add(this.createReportButton);
            this.createReportFuncGroup.Controls.Add(this.getTeacherListButton);
            this.createReportFuncGroup.Controls.Add(this.getStudentListButton);
            this.createReportFuncGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.createReportFuncGroup.Location = new System.Drawing.Point(30, 293);
            this.createReportFuncGroup.Name = "createReportFuncGroup";
            this.createReportFuncGroup.Size = new System.Drawing.Size(289, 115);
            this.createReportFuncGroup.TabIndex = 24;
            this.createReportFuncGroup.TabStop = false;
            this.createReportFuncGroup.Text = "Отчеты";
            // 
            // createReportButton
            // 
            this.createReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReportButton.Location = new System.Drawing.Point(7, 69);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(133, 29);
            this.createReportButton.TabIndex = 13;
            this.createReportButton.Text = "Создание отчета";
            this.createReportButton.UseVisualStyleBackColor = true;
            // 
            // getTeacherListButton
            // 
            this.getTeacherListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getTeacherListButton.Location = new System.Drawing.Point(146, 41);
            this.getTeacherListButton.Name = "getTeacherListButton";
            this.getTeacherListButton.Size = new System.Drawing.Size(133, 48);
            this.getTeacherListButton.TabIndex = 12;
            this.getTeacherListButton.Text = "Список преподавателей";
            this.getTeacherListButton.UseVisualStyleBackColor = true;
            // 
            // getStudentListButton
            // 
            this.getStudentListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getStudentListButton.Location = new System.Drawing.Point(7, 33);
            this.getStudentListButton.Name = "getStudentListButton";
            this.getStudentListButton.Size = new System.Drawing.Size(133, 30);
            this.getStudentListButton.TabIndex = 11;
            this.getStudentListButton.Text = "Список студентов";
            this.getStudentListButton.UseVisualStyleBackColor = true;
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutProgramButton.Location = new System.Drawing.Point(346, 378);
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(119, 30);
            this.aboutProgramButton.TabIndex = 23;
            this.aboutProgramButton.Text = "О программе";
            this.aboutProgramButton.UseVisualStyleBackColor = true;
            this.aboutProgramButton.Click += new System.EventHandler(this.aboutProgramButton_Click);
            // 
            // updateTestListButton
            // 
            this.updateTestListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTestListButton.Location = new System.Drawing.Point(516, 378);
            this.updateTestListButton.Name = "updateTestListButton";
            this.updateTestListButton.Size = new System.Drawing.Size(119, 30);
            this.updateTestListButton.TabIndex = 21;
            this.updateTestListButton.Text = "Обновить список";
            this.updateTestListButton.UseVisualStyleBackColor = true;
            this.updateTestListButton.Click += new System.EventHandler(this.updateTestListButton_Click);
            // 
            // studGroupLable
            // 
            this.studGroupLable.AutoSize = true;
            this.studGroupLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studGroupLable.Location = new System.Drawing.Point(135, 100);
            this.studGroupLable.Name = "studGroupLable";
            this.studGroupLable.Size = new System.Drawing.Size(145, 21);
            this.studGroupLable.TabIndex = 19;
            this.studGroupLable.Text = "<Учебная группа>";
            // 
            // userImageBox
            // 
            this.userImageBox.Image = global::TeachSystem.Properties.Resources.defaultUserImage;
            this.userImageBox.ImageLocation = "";
            this.userImageBox.Location = new System.Drawing.Point(30, 30);
            this.userImageBox.Name = "userImageBox";
            this.userImageBox.Size = new System.Drawing.Size(100, 100);
            this.userImageBox.TabIndex = 17;
            this.userImageBox.TabStop = false;
            // 
            // studLNLable
            // 
            this.studLNLable.AutoSize = true;
            this.studLNLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studLNLable.Location = new System.Drawing.Point(135, 30);
            this.studLNLable.Name = "studLNLable";
            this.studLNLable.Size = new System.Drawing.Size(102, 21);
            this.studLNLable.TabIndex = 16;
            this.studLNLable.Text = "<Фамилия>";
            // 
            // studFNLable
            // 
            this.studFNLable.AutoSize = true;
            this.studFNLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studFNLable.Location = new System.Drawing.Point(135, 50);
            this.studFNLable.Name = "studFNLable";
            this.studFNLable.Size = new System.Drawing.Size(65, 21);
            this.studFNLable.TabIndex = 15;
            this.studFNLable.Text = "<Имя>";
            // 
            // beginTestButton
            // 
            this.beginTestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginTestButton.Location = new System.Drawing.Point(641, 378);
            this.beginTestButton.Name = "beginTestButton";
            this.beginTestButton.Size = new System.Drawing.Size(119, 30);
            this.beginTestButton.TabIndex = 25;
            this.beginTestButton.Text = "Начать тест";
            this.beginTestButton.UseVisualStyleBackColor = true;
            this.beginTestButton.Click += new System.EventHandler(this.beginTestButton_Click);
            // 
            // listViewTests
            // 
            this.listViewTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTestName,
            this.colTeacher,
            this.colReleaseDate,
            this.colTestAviable});
            this.listViewTests.FullRowSelect = true;
            this.listViewTests.GridLines = true;
            this.listViewTests.Location = new System.Drawing.Point(346, 50);
            this.listViewTests.MultiSelect = false;
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(414, 326);
            this.listViewTests.TabIndex = 26;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            this.listViewTests.View = System.Windows.Forms.View.Details;
            // 
            // colTestName
            // 
            this.colTestName.Text = "Название";
            this.colTestName.Width = 139;
            // 
            // colTeacher
            // 
            this.colTeacher.Text = "Преподаватель";
            this.colTeacher.Width = 98;
            // 
            // colReleaseDate
            // 
            this.colReleaseDate.Text = "Дата создания";
            this.colReleaseDate.Width = 93;
            // 
            // colTestAviable
            // 
            this.colTestAviable.Text = "Доступность";
            this.colTestAviable.Width = 79;
            // 
            // testListLable
            // 
            this.testListLable.AutoSize = true;
            this.testListLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testListLable.Location = new System.Drawing.Point(342, 26);
            this.testListLable.Name = "testListLable";
            this.testListLable.Size = new System.Drawing.Size(119, 21);
            this.testListLable.TabIndex = 27;
            this.testListLable.Text = "Список тестов";
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.testListLable);
            this.Controls.Add(this.listViewTests);
            this.Controls.Add(this.beginTestButton);
            this.Controls.Add(this.createReportFuncGroup);
            this.Controls.Add(this.aboutProgramButton);
            this.Controls.Add(this.updateTestListButton);
            this.Controls.Add(this.studGroupLable);
            this.Controls.Add(this.userImageBox);
            this.Controls.Add(this.studLNLable);
            this.Controls.Add(this.studFNLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 470);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "StudentMainForm";
            this.Text = "TeachSystem";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.createReportFuncGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox createReportFuncGroup;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button getTeacherListButton;
        private System.Windows.Forms.Button getStudentListButton;
        private System.Windows.Forms.Button aboutProgramButton;
        private System.Windows.Forms.Button updateTestListButton;
        private System.Windows.Forms.Label studGroupLable;
        private System.Windows.Forms.PictureBox userImageBox;
        private System.Windows.Forms.Label studLNLable;
        private System.Windows.Forms.Label studFNLable;
        private System.Windows.Forms.Button beginTestButton;
        private System.Windows.Forms.ListView listViewTests;
        private System.Windows.Forms.ColumnHeader colTestName;
        private System.Windows.Forms.ColumnHeader colTeacher;
        private System.Windows.Forms.ColumnHeader colReleaseDate;
        private System.Windows.Forms.ColumnHeader colTestAviable;
        private System.Windows.Forms.Label testListLable;
    }
}