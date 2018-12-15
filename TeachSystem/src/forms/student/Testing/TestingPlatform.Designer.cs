namespace TeachSystem
{
    partial class TestingPlatform
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
            this.titleLable = new System.Windows.Forms.Label();
            this.questionLable = new System.Windows.Forms.Label();
            this.questText = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(30, 30);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(73, 30);
            this.titleLable.TabIndex = 10;
            this.titleLable.Text = "Тест - ";
            // 
            // questionLable
            // 
            this.questionLable.AutoSize = true;
            this.questionLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.questionLable.Location = new System.Drawing.Point(30, 80);
            this.questionLable.Name = "questionLable";
            this.questionLable.Size = new System.Drawing.Size(123, 30);
            this.questionLable.TabIndex = 11;
            this.questionLable.Text = "Вопрос № ";
            // 
            // questText
            // 
            this.questText.AutoSize = true;
            this.questText.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.questText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.questText.Location = new System.Drawing.Point(30, 130);
            this.questText.Name = "questText";
            this.questText.Size = new System.Drawing.Size(178, 30);
            this.questText.TabIndex = 12;
            this.questText.Text = "<Текст вопроса>";
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.nextQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextQuestionButton.Location = new System.Drawing.Point(339, 437);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(103, 38);
            this.nextQuestionButton.TabIndex = 14;
            this.nextQuestionButton.Text = "Далее";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // TestingPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(454, 487);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questText);
            this.Controls.Add(this.questionLable);
            this.Controls.Add(this.titleLable);
            this.MaximizeBox = false;
            this.Name = "TestingPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachSystem - Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label titleLable;
        public System.Windows.Forms.Label questionLable;
        public System.Windows.Forms.Label questText;
        public System.Windows.Forms.Button nextQuestionButton;
    }
}