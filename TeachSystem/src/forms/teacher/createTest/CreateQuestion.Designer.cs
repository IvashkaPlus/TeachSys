namespace TeachSystem
{
    partial class CreateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuestion));
            this.titleLable = new System.Windows.Forms.Label();
            this.titBox = new System.Windows.Forms.TextBox();
            this.titLable = new System.Windows.Forms.Label();
            this.createQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(20, 15);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(198, 30);
            this.titleLable.TabIndex = 19;
            this.titleLable.Text = "Создание вопроса";
            // 
            // titBox
            // 
            this.titBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titBox.Location = new System.Drawing.Point(25, 87);
            this.titBox.Multiline = true;
            this.titBox.Name = "titBox";
            this.titBox.Size = new System.Drawing.Size(363, 74);
            this.titBox.TabIndex = 18;
            // 
            // titLable
            // 
            this.titLable.AutoSize = true;
            this.titLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLable.Location = new System.Drawing.Point(21, 63);
            this.titLable.Name = "titLable";
            this.titLable.Size = new System.Drawing.Size(111, 21);
            this.titLable.TabIndex = 17;
            this.titLable.Text = "Текст вопроса";
            // 
            // createQuestionButton
            // 
            this.createQuestionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createQuestionButton.Location = new System.Drawing.Point(309, 167);
            this.createQuestionButton.Name = "createQuestionButton";
            this.createQuestionButton.Size = new System.Drawing.Size(79, 30);
            this.createQuestionButton.TabIndex = 16;
            this.createQuestionButton.Text = "Создать";
            this.createQuestionButton.UseVisualStyleBackColor = true;
            this.createQuestionButton.Click += new System.EventHandler(this.createQuestionButton_Click);
            // 
            // CreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 211);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.titBox);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.createQuestionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateQuestion";
            this.Text = "Создание вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.TextBox titBox;
        private System.Windows.Forms.Label titLable;
        private System.Windows.Forms.Button createQuestionButton;
    }
}