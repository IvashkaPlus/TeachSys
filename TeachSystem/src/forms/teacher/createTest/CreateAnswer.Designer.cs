namespace TeachSystem
{
    partial class CreateAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnswer));
            this.titleLable = new System.Windows.Forms.Label();
            this.titBox = new System.Windows.Forms.TextBox();
            this.titLable = new System.Windows.Forms.Label();
            this.createAnswerButton = new System.Windows.Forms.Button();
            this.isRightCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(17, 11);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(228, 37);
            this.titleLable.TabIndex = 23;
            this.titleLable.Text = "Создание ответа";
            // 
            // titBox
            // 
            this.titBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titBox.Location = new System.Drawing.Point(24, 89);
            this.titBox.Multiline = true;
            this.titBox.Name = "titBox";
            this.titBox.Size = new System.Drawing.Size(363, 74);
            this.titBox.TabIndex = 22;
            // 
            // titLable
            // 
            this.titLable.AutoSize = true;
            this.titLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLable.Location = new System.Drawing.Point(20, 65);
            this.titLable.Name = "titLable";
            this.titLable.Size = new System.Drawing.Size(99, 21);
            this.titLable.TabIndex = 21;
            this.titLable.Text = "Текст ответа";
            // 
            // createAnswerButton
            // 
            this.createAnswerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createAnswerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAnswerButton.Location = new System.Drawing.Point(308, 241);
            this.createAnswerButton.Name = "createAnswerButton";
            this.createAnswerButton.Size = new System.Drawing.Size(79, 30);
            this.createAnswerButton.TabIndex = 20;
            this.createAnswerButton.Text = "Создать";
            this.createAnswerButton.UseVisualStyleBackColor = true;
            // 
            // isRightCheckBox
            // 
            this.isRightCheckBox.AutoSize = true;
            this.isRightCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isRightCheckBox.Location = new System.Drawing.Point(24, 191);
            this.isRightCheckBox.Name = "isRightCheckBox";
            this.isRightCheckBox.Size = new System.Drawing.Size(162, 25);
            this.isRightCheckBox.TabIndex = 24;
            this.isRightCheckBox.Text = "Правильный ответ";
            this.isRightCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 291);
            this.Controls.Add(this.isRightCheckBox);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.titBox);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.createAnswerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAnswer";
            this.Text = "Создание ответа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.TextBox titBox;
        private System.Windows.Forms.Label titLable;
        private System.Windows.Forms.Button createAnswerButton;
        private System.Windows.Forms.CheckBox isRightCheckBox;
    }
}