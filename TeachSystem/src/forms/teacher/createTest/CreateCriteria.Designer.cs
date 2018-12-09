namespace TeachSystem
{
    partial class CreateCriteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCriteria));
            this.titleLable = new System.Windows.Forms.Label();
            this.tit5Lable = new System.Windows.Forms.Label();
            this.createQuestionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tit5Box = new System.Windows.Forms.TextBox();
            this.tit4Box = new System.Windows.Forms.TextBox();
            this.tit3Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(17, 15);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(299, 37);
            this.titleLable.TabIndex = 26;
            this.titleLable.Text = "Создание оценивания";
            // 
            // tit5Lable
            // 
            this.tit5Lable.AutoSize = true;
            this.tit5Lable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit5Lable.Location = new System.Drawing.Point(20, 69);
            this.tit5Lable.Name = "tit5Lable";
            this.tit5Lable.Size = new System.Drawing.Size(98, 21);
            this.tit5Lable.TabIndex = 25;
            this.tit5Lable.Text = "На оценку 5";
            // 
            // createQuestionButton
            // 
            this.createQuestionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createQuestionButton.Location = new System.Drawing.Point(265, 249);
            this.createQuestionButton.Name = "createQuestionButton";
            this.createQuestionButton.Size = new System.Drawing.Size(79, 30);
            this.createQuestionButton.TabIndex = 24;
            this.createQuestionButton.Text = "Создать";
            this.createQuestionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "На оценку 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "На оценку 3";
            // 
            // tit5Box
            // 
            this.tit5Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit5Box.Location = new System.Drawing.Point(124, 66);
            this.tit5Box.Name = "tit5Box";
            this.tit5Box.Size = new System.Drawing.Size(220, 29);
            this.tit5Box.TabIndex = 29;
            // 
            // tit4Box
            // 
            this.tit4Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit4Box.Location = new System.Drawing.Point(124, 102);
            this.tit4Box.Name = "tit4Box";
            this.tit4Box.Size = new System.Drawing.Size(220, 29);
            this.tit4Box.TabIndex = 30;
            // 
            // tit3Box
            // 
            this.tit3Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit3Box.Location = new System.Drawing.Point(124, 138);
            this.tit3Box.Name = "tit3Box";
            this.tit3Box.Size = new System.Drawing.Size(220, 29);
            this.tit3Box.TabIndex = 31;
            // 
            // CreateCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 291);
            this.Controls.Add(this.tit3Box);
            this.Controls.Add(this.tit4Box);
            this.Controls.Add(this.tit5Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.tit5Lable);
            this.Controls.Add(this.createQuestionButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateCriteria";
            this.Text = "Создание критериев оценки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label tit5Lable;
        private System.Windows.Forms.Button createQuestionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tit5Box;
        private System.Windows.Forms.TextBox tit4Box;
        private System.Windows.Forms.TextBox tit3Box;
    }
}