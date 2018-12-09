namespace TeachSystem
{
    partial class CreateTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTest));
            this.createTestButton = new System.Windows.Forms.Button();
            this.titBox = new System.Windows.Forms.TextBox();
            this.titLable = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gradeCriteriaLable = new System.Windows.Forms.Label();
            this.addGradeCriteriaButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.listViewQuest = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // createTestButton
            // 
            this.createTestButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createTestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTestButton.Location = new System.Drawing.Point(303, 408);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(79, 30);
            this.createTestButton.TabIndex = 0;
            this.createTestButton.Text = "Создать";
            this.createTestButton.UseVisualStyleBackColor = true;
            // 
            // titBox
            // 
            this.titBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titBox.Location = new System.Drawing.Point(162, 60);
            this.titBox.Name = "titBox";
            this.titBox.Size = new System.Drawing.Size(220, 29);
            this.titBox.TabIndex = 7;
            // 
            // titLable
            // 
            this.titLable.AutoSize = true;
            this.titLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLable.Location = new System.Drawing.Point(15, 63);
            this.titLable.Name = "titLable";
            this.titLable.Size = new System.Drawing.Size(119, 21);
            this.titLable.TabIndex = 6;
            this.titLable.Text = "Название теста";
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(12, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(210, 37);
            this.titleLable.TabIndex = 8;
            this.titleLable.Text = "Создание теста";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Предмет";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 29);
            this.comboBox1.TabIndex = 10;
            // 
            // gradeCriteriaLable
            // 
            this.gradeCriteriaLable.AutoSize = true;
            this.gradeCriteriaLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeCriteriaLable.Location = new System.Drawing.Point(15, 144);
            this.gradeCriteriaLable.Name = "gradeCriteriaLable";
            this.gradeCriteriaLable.Size = new System.Drawing.Size(136, 21);
            this.gradeCriteriaLable.TabIndex = 11;
            this.gradeCriteriaLable.Text = "Критерии оценки";
            // 
            // addGradeCriteriaButton
            // 
            this.addGradeCriteriaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addGradeCriteriaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGradeCriteriaButton.Location = new System.Drawing.Point(162, 140);
            this.addGradeCriteriaButton.Name = "addGradeCriteriaButton";
            this.addGradeCriteriaButton.Size = new System.Drawing.Size(109, 30);
            this.addGradeCriteriaButton.TabIndex = 12;
            this.addGradeCriteriaButton.Text = "Добавить...";
            this.addGradeCriteriaButton.UseVisualStyleBackColor = true;
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestionButton.Location = new System.Drawing.Point(236, 323);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(146, 30);
            this.addQuestionButton.TabIndex = 14;
            this.addQuestionButton.Text = "Добавить вопрос";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            // 
            // listViewQuest
            // 
            this.listViewQuest.Location = new System.Drawing.Point(19, 187);
            this.listViewQuest.Name = "listViewQuest";
            this.listViewQuest.Size = new System.Drawing.Size(363, 130);
            this.listViewQuest.TabIndex = 15;
            this.listViewQuest.UseCompatibleStateImageBehavior = false;
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 451);
            this.Controls.Add(this.listViewQuest);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.addGradeCriteriaButton);
            this.Controls.Add(this.gradeCriteriaLable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.titBox);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.createTestButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTest";
            this.Text = "Создание теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTestButton;
        private System.Windows.Forms.TextBox titBox;
        private System.Windows.Forms.Label titLable;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label gradeCriteriaLable;
        private System.Windows.Forms.Button addGradeCriteriaButton;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.ListView listViewQuest;
    }
}