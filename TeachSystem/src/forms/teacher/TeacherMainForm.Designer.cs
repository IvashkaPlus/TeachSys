namespace TeachSystem
{
    partial class TeacherMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMainForm));
            this.teachFNLable = new System.Windows.Forms.Label();
            this.teachLNLable = new System.Windows.Forms.Label();
            this.userImageBox = new System.Windows.Forms.PictureBox();
            this.teachPLable = new System.Windows.Forms.Label();
            this.teachSDLable = new System.Windows.Forms.Label();
            this.testListLable = new System.Windows.Forms.Label();
            this.updateTestListButton = new System.Windows.Forms.Button();
            this.addTestButton = new System.Windows.Forms.Button();
            this.listViewTests = new System.Windows.Forms.ListView();
            this.columnTestTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTestCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTestAviable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addUserFuncGroup = new System.Windows.Forms.GroupBox();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.addTeachGroupButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.aboutProgramButton = new System.Windows.Forms.Button();
            this.createReportFuncGroup = new System.Windows.Forms.GroupBox();
            this.createReportButton = new System.Windows.Forms.Button();
            this.getTeacherListButton = new System.Windows.Forms.Button();
            this.getStudentListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).BeginInit();
            this.addUserFuncGroup.SuspendLayout();
            this.createReportFuncGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachFNLable
            // 
            this.teachFNLable.AutoSize = true;
            this.teachFNLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachFNLable.Location = new System.Drawing.Point(135, 50);
            this.teachFNLable.Name = "teachFNLable";
            this.teachFNLable.Size = new System.Drawing.Size(65, 21);
            this.teachFNLable.TabIndex = 0;
            this.teachFNLable.Text = "<Имя>";
            // 
            // teachLNLable
            // 
            this.teachLNLable.AutoSize = true;
            this.teachLNLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachLNLable.Location = new System.Drawing.Point(135, 30);
            this.teachLNLable.Name = "teachLNLable";
            this.teachLNLable.Size = new System.Drawing.Size(102, 21);
            this.teachLNLable.TabIndex = 1;
            this.teachLNLable.Text = "<Фамилия>";
            // 
            // userImageBox
            // 
            this.userImageBox.Image = global::TeachSystem.Properties.Resources.defaultUserImage;
            this.userImageBox.ImageLocation = "";
            this.userImageBox.Location = new System.Drawing.Point(30, 30);
            this.userImageBox.Name = "userImageBox";
            this.userImageBox.Size = new System.Drawing.Size(100, 100);
            this.userImageBox.TabIndex = 2;
            this.userImageBox.TabStop = false;
            // 
            // teachPLable
            // 
            this.teachPLable.AutoSize = true;
            this.teachPLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachPLable.Location = new System.Drawing.Point(135, 71);
            this.teachPLable.Name = "teachPLable";
            this.teachPLable.Size = new System.Drawing.Size(103, 21);
            this.teachPLable.TabIndex = 3;
            this.teachPLable.Text = "<Отчество>";
            // 
            // teachSDLable
            // 
            this.teachSDLable.AutoSize = true;
            this.teachSDLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachSDLable.Location = new System.Drawing.Point(135, 100);
            this.teachSDLable.Name = "teachSDLable";
            this.teachSDLable.Size = new System.Drawing.Size(153, 21);
            this.teachSDLable.TabIndex = 4;
            this.teachSDLable.Text = "<Научная степень>";
            // 
            // testListLable
            // 
            this.testListLable.AutoSize = true;
            this.testListLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testListLable.Location = new System.Drawing.Point(342, 26);
            this.testListLable.Name = "testListLable";
            this.testListLable.Size = new System.Drawing.Size(119, 21);
            this.testListLable.TabIndex = 6;
            this.testListLable.Text = "Список тестов";
            // 
            // updateTestListButton
            // 
            this.updateTestListButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTestListButton.Location = new System.Drawing.Point(516, 382);
            this.updateTestListButton.Name = "updateTestListButton";
            this.updateTestListButton.Size = new System.Drawing.Size(119, 30);
            this.updateTestListButton.TabIndex = 7;
            this.updateTestListButton.Text = "Обновить список";
            this.updateTestListButton.UseVisualStyleBackColor = true;
            this.updateTestListButton.Click += new System.EventHandler(this.updateTestListButton_Click);
            // 
            // addTestButton
            // 
            this.addTestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTestButton.Location = new System.Drawing.Point(641, 382);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(119, 30);
            this.addTestButton.TabIndex = 8;
            this.addTestButton.Text = "Создать тест";
            this.addTestButton.UseVisualStyleBackColor = true;
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // listViewTests
            // 
            this.listViewTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTestTitle,
            this.columnTestCreator,
            this.columnReleaseDate,
            this.columnTestAviable});
            this.listViewTests.GridLines = true;
            this.listViewTests.Location = new System.Drawing.Point(346, 50);
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(414, 326);
            this.listViewTests.TabIndex = 9;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            // 
            // columnReleaseDate
            // 
            this.columnReleaseDate.DisplayIndex = 3;
            // 
            // columnTestAviable
            // 
            this.columnTestAviable.DisplayIndex = 2;
            // 
            // addUserFuncGroup
            // 
            this.addUserFuncGroup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addUserFuncGroup.Controls.Add(this.addTeacherButton);
            this.addUserFuncGroup.Controls.Add(this.addTeachGroupButton);
            this.addUserFuncGroup.Controls.Add(this.addStudentButton);
            this.addUserFuncGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addUserFuncGroup.Location = new System.Drawing.Point(30, 159);
            this.addUserFuncGroup.Name = "addUserFuncGroup";
            this.addUserFuncGroup.Size = new System.Drawing.Size(289, 115);
            this.addUserFuncGroup.TabIndex = 10;
            this.addUserFuncGroup.TabStop = false;
            this.addUserFuncGroup.Text = "Добавить пользователей";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherButton.Location = new System.Drawing.Point(146, 44);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(133, 45);
            this.addTeacherButton.TabIndex = 13;
            this.addTeacherButton.Text = "Добавить преподавателя";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            // 
            // addTeachGroupButton
            // 
            this.addTeachGroupButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeachGroupButton.Location = new System.Drawing.Point(7, 69);
            this.addTeachGroupButton.Name = "addTeachGroupButton";
            this.addTeachGroupButton.Size = new System.Drawing.Size(133, 30);
            this.addTeachGroupButton.TabIndex = 12;
            this.addTeachGroupButton.Text = "Добавить группу";
            this.addTeachGroupButton.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentButton.Location = new System.Drawing.Point(7, 33);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(133, 30);
            this.addStudentButton.TabIndex = 11;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutProgramButton.Location = new System.Drawing.Point(346, 382);
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(119, 30);
            this.aboutProgramButton.TabIndex = 11;
            this.aboutProgramButton.Text = "О программе";
            this.aboutProgramButton.UseVisualStyleBackColor = true;
            this.aboutProgramButton.Click += new System.EventHandler(this.aboutProgramButton_Click);
            // 
            // createReportFuncGroup
            // 
            this.createReportFuncGroup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.createReportFuncGroup.Controls.Add(this.createReportButton);
            this.createReportFuncGroup.Controls.Add(this.getTeacherListButton);
            this.createReportFuncGroup.Controls.Add(this.getStudentListButton);
            this.createReportFuncGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.createReportFuncGroup.Location = new System.Drawing.Point(30, 297);
            this.createReportFuncGroup.Name = "createReportFuncGroup";
            this.createReportFuncGroup.Size = new System.Drawing.Size(289, 115);
            this.createReportFuncGroup.TabIndex = 14;
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
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.createReportFuncGroup);
            this.Controls.Add(this.aboutProgramButton);
            this.Controls.Add(this.addUserFuncGroup);
            this.Controls.Add(this.listViewTests);
            this.Controls.Add(this.addTestButton);
            this.Controls.Add(this.updateTestListButton);
            this.Controls.Add(this.testListLable);
            this.Controls.Add(this.teachSDLable);
            this.Controls.Add(this.teachPLable);
            this.Controls.Add(this.userImageBox);
            this.Controls.Add(this.teachLNLable);
            this.Controls.Add(this.teachFNLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherMainForm";
            this.Text = "TeachSystem";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).EndInit();
            this.addUserFuncGroup.ResumeLayout(false);
            this.createReportFuncGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teachFNLable;
        private System.Windows.Forms.Label teachLNLable;
        private System.Windows.Forms.PictureBox userImageBox;
        private System.Windows.Forms.Label teachPLable;
        private System.Windows.Forms.Label teachSDLable;
        private System.Windows.Forms.Label testListLable;
        private System.Windows.Forms.Button updateTestListButton;
        private System.Windows.Forms.Button addTestButton;
        private System.Windows.Forms.ListView listViewTests;
        private System.Windows.Forms.ColumnHeader columnTestTitle;
        private System.Windows.Forms.ColumnHeader columnTestCreator;
        private System.Windows.Forms.ColumnHeader columnReleaseDate;
        private System.Windows.Forms.ColumnHeader columnTestAviable;
        private System.Windows.Forms.GroupBox addUserFuncGroup;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button addTeachGroupButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button aboutProgramButton;
        private System.Windows.Forms.GroupBox createReportFuncGroup;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button getTeacherListButton;
        private System.Windows.Forms.Button getStudentListButton;
    }
}