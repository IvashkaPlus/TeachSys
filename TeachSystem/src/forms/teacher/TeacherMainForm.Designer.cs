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
            this.colTestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addUserFuncGroup = new System.Windows.Forms.GroupBox();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.addTeachGroupButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.aboutProgramButton = new System.Windows.Forms.Button();
            this.createReportFuncGroup = new System.Windows.Forms.GroupBox();
            this.createReportButton = new System.Windows.Forms.Button();
            this.appointTestButton = new System.Windows.Forms.Button();
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
            this.updateTestListButton.Location = new System.Drawing.Point(537, 503);
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
            this.addTestButton.Location = new System.Drawing.Point(662, 503);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(98, 30);
            this.addTestButton.TabIndex = 8;
            this.addTestButton.Text = "Создать тест";
            this.addTestButton.UseVisualStyleBackColor = true;
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // listViewTests
            // 
            this.listViewTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTestName,
            this.colTeacher,
            this.colReleaseDate});
            this.listViewTests.FullRowSelect = true;
            this.listViewTests.GridLines = true;
            this.listViewTests.Location = new System.Drawing.Point(346, 50);
            this.listViewTests.MultiSelect = false;
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(414, 447);
            this.listViewTests.TabIndex = 9;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            this.listViewTests.View = System.Windows.Forms.View.Details;
            // 
            // colTestName
            // 
            this.colTestName.Text = "Название";
            this.colTestName.Width = 215;
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
            // addUserFuncGroup
            // 
            this.addUserFuncGroup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addUserFuncGroup.Controls.Add(this.addTeacherButton);
            this.addUserFuncGroup.Controls.Add(this.addTeachGroupButton);
            this.addUserFuncGroup.Controls.Add(this.addStudentButton);
            this.addUserFuncGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.addUserFuncGroup.Location = new System.Drawing.Point(30, 160);
            this.addUserFuncGroup.Name = "addUserFuncGroup";
            this.addUserFuncGroup.Size = new System.Drawing.Size(289, 138);
            this.addUserFuncGroup.TabIndex = 10;
            this.addUserFuncGroup.TabStop = false;
            this.addUserFuncGroup.Text = "Добавить пользователей";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherButton.Location = new System.Drawing.Point(146, 58);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(133, 45);
            this.addTeacherButton.TabIndex = 13;
            this.addTeacherButton.Text = "Добавить преподавателя";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // addTeachGroupButton
            // 
            this.addTeachGroupButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeachGroupButton.Location = new System.Drawing.Point(7, 91);
            this.addTeachGroupButton.Name = "addTeachGroupButton";
            this.addTeachGroupButton.Size = new System.Drawing.Size(133, 30);
            this.addTeachGroupButton.TabIndex = 12;
            this.addTeachGroupButton.Text = "Добавить группу";
            this.addTeachGroupButton.UseVisualStyleBackColor = true;
            this.addTeachGroupButton.Click += new System.EventHandler(this.addTeachGroupButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentButton.Location = new System.Drawing.Point(7, 44);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(133, 30);
            this.addStudentButton.TabIndex = 11;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // aboutProgramButton
            // 
            this.aboutProgramButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutProgramButton.Location = new System.Drawing.Point(29, 503);
            this.aboutProgramButton.Name = "aboutProgramButton";
            this.aboutProgramButton.Size = new System.Drawing.Size(99, 30);
            this.aboutProgramButton.TabIndex = 11;
            this.aboutProgramButton.Text = "О программе";
            this.aboutProgramButton.UseVisualStyleBackColor = true;
            this.aboutProgramButton.Click += new System.EventHandler(this.aboutProgramButton_Click);
            // 
            // createReportFuncGroup
            // 
            this.createReportFuncGroup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.createReportFuncGroup.Controls.Add(this.createReportButton);
            this.createReportFuncGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.createReportFuncGroup.Location = new System.Drawing.Point(29, 304);
            this.createReportFuncGroup.Name = "createReportFuncGroup";
            this.createReportFuncGroup.Size = new System.Drawing.Size(290, 193);
            this.createReportFuncGroup.TabIndex = 14;
            this.createReportFuncGroup.TabStop = false;
            this.createReportFuncGroup.Text = "Отчеты";
            // 
            // createReportButton
            // 
            this.createReportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReportButton.Location = new System.Drawing.Point(44, 51);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(215, 29);
            this.createReportButton.TabIndex = 13;
            this.createReportButton.Text = "Создание отчета успеваемости";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // appointTestButton
            // 
            this.appointTestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointTestButton.Location = new System.Drawing.Point(423, 503);
            this.appointTestButton.Name = "appointTestButton";
            this.appointTestButton.Size = new System.Drawing.Size(108, 30);
            this.appointTestButton.TabIndex = 16;
            this.appointTestButton.Text = "Назначить тест";
            this.appointTestButton.UseVisualStyleBackColor = true;
            this.appointTestButton.Click += new System.EventHandler(this.appointTestButton_Click);
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.appointTestButton);
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
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
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
        private System.Windows.Forms.ColumnHeader colTestName;
        private System.Windows.Forms.ColumnHeader colTeacher;
        private System.Windows.Forms.ColumnHeader colReleaseDate;
        private System.Windows.Forms.GroupBox addUserFuncGroup;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button addTeachGroupButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button aboutProgramButton;
        private System.Windows.Forms.GroupBox createReportFuncGroup;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button appointTestButton;
    }
}