namespace TeachSystem
{
    partial class AppointTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointTestForm));
            this.titleLable = new System.Windows.Forms.Label();
            this.listViewAccess = new System.Windows.Forms.ListView();
            this.colStudName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeadLineDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadLineDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupList = new System.Windows.Forms.ComboBox();
            this.subjectLable = new System.Windows.Forms.Label();
            this.titLable = new System.Windows.Forms.Label();
            this.appointTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(12, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(187, 30);
            this.titleLable.TabIndex = 9;
            this.titleLable.Text = "Назначение теста";
            // 
            // listViewAccess
            // 
            this.listViewAccess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStudName,
            this.colTeacher,
            this.colDeadLineDate});
            this.listViewAccess.FullRowSelect = true;
            this.listViewAccess.GridLines = true;
            this.listViewAccess.Location = new System.Drawing.Point(264, 56);
            this.listViewAccess.Name = "listViewAccess";
            this.listViewAccess.Size = new System.Drawing.Size(414, 351);
            this.listViewAccess.TabIndex = 10;
            this.listViewAccess.UseCompatibleStateImageBehavior = false;
            this.listViewAccess.View = System.Windows.Forms.View.Details;
            // 
            // colStudName
            // 
            this.colStudName.Text = "Студент";
            this.colStudName.Width = 215;
            // 
            // colTeacher
            // 
            this.colTeacher.Text = "Назначен";
            this.colTeacher.Width = 98;
            // 
            // colDeadLineDate
            // 
            this.colDeadLineDate.Text = "Крайний срок";
            this.colDeadLineDate.Width = 93;
            // 
            // deadLineDatePicker
            // 
            this.deadLineDatePicker.Location = new System.Drawing.Point(17, 162);
            this.deadLineDatePicker.Name = "deadLineDatePicker";
            this.deadLineDatePicker.Size = new System.Drawing.Size(230, 20);
            this.deadLineDatePicker.TabIndex = 11;
            // 
            // groupList
            // 
            this.groupList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupList.FormattingEnabled = true;
            this.groupList.Location = new System.Drawing.Point(17, 80);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(230, 29);
            this.groupList.TabIndex = 14;
            this.groupList.SelectedIndexChanged += new System.EventHandler(this.groupList_SelectedIndexChanged);
            // 
            // subjectLable
            // 
            this.subjectLable.AutoSize = true;
            this.subjectLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLable.Location = new System.Drawing.Point(13, 127);
            this.subjectLable.Name = "subjectLable";
            this.subjectLable.Size = new System.Drawing.Size(109, 21);
            this.subjectLable.TabIndex = 13;
            this.subjectLable.Text = "Крайний срок";
            // 
            // titLable
            // 
            this.titLable.AutoSize = true;
            this.titLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLable.Location = new System.Drawing.Point(13, 56);
            this.titLable.Name = "titLable";
            this.titLable.Size = new System.Drawing.Size(61, 21);
            this.titLable.TabIndex = 12;
            this.titLable.Text = "Группа";
            // 
            // appointTestButton
            // 
            this.appointTestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointTestButton.Location = new System.Drawing.Point(599, 413);
            this.appointTestButton.Name = "appointTestButton";
            this.appointTestButton.Size = new System.Drawing.Size(79, 30);
            this.appointTestButton.TabIndex = 15;
            this.appointTestButton.Text = "Назначить";
            this.appointTestButton.UseVisualStyleBackColor = true;
            this.appointTestButton.Click += new System.EventHandler(this.appointTestButton_Click);
            // 
            // AppointTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 453);
            this.Controls.Add(this.appointTestButton);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.subjectLable);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.deadLineDatePicker);
            this.Controls.Add(this.listViewAccess);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointTestForm";
            this.Text = "TeachSystem - Назначение теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.ListView listViewAccess;
        private System.Windows.Forms.ColumnHeader colStudName;
        private System.Windows.Forms.ColumnHeader colTeacher;
        private System.Windows.Forms.ColumnHeader colDeadLineDate;
        private System.Windows.Forms.DateTimePicker deadLineDatePicker;
        private System.Windows.Forms.ComboBox groupList;
        private System.Windows.Forms.Label subjectLable;
        private System.Windows.Forms.Label titLable;
        private System.Windows.Forms.Button appointTestButton;
    }
}