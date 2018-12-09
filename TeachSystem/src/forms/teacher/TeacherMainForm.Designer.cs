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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teachPLable = new System.Windows.Forms.Label();
            this.teachSDLable = new System.Windows.Forms.Label();
            this.testListLable = new System.Windows.Forms.Label();
            this.updateTestListButton = new System.Windows.Forms.Button();
            this.addTestButton = new System.Windows.Forms.Button();
            this.listViewTests = new System.Windows.Forms.ListView();
            this.columnTestTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTestCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTestAviable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeachSystem.Properties.Resources.defaultUserImage;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.updateTestListButton.Location = new System.Drawing.Point(516, 229);
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
            this.addTestButton.Location = new System.Drawing.Point(641, 229);
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
            this.listViewTests.Size = new System.Drawing.Size(414, 173);
            this.listViewTests.TabIndex = 9;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            // 
            // columnTestAviable
            // 
            this.columnTestAviable.DisplayIndex = 2;
            // 
            // columnReleaseDate
            // 
            this.columnReleaseDate.DisplayIndex = 3;
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.listViewTests);
            this.Controls.Add(this.addTestButton);
            this.Controls.Add(this.updateTestListButton);
            this.Controls.Add(this.testListLable);
            this.Controls.Add(this.teachSDLable);
            this.Controls.Add(this.teachPLable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.teachLNLable);
            this.Controls.Add(this.teachFNLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherMainForm";
            this.Text = "TeachSystem";
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teachFNLable;
        private System.Windows.Forms.Label teachLNLable;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}