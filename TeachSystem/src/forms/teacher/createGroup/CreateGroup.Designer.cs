namespace TeachSystem
{
    partial class CreateGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.Создать = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните Информацию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя группы";
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(108, 68);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(164, 20);
            this.GroupBox.TabIndex = 2;
            // 
            // Создать
            // 
            this.Создать.Location = new System.Drawing.Point(161, 131);
            this.Создать.Name = "Создать";
            this.Создать.Size = new System.Drawing.Size(111, 31);
            this.Создать.TabIndex = 3;
            this.Создать.Text = "Создать";
            this.Создать.UseVisualStyleBackColor = true;
            this.Создать.Click += new System.EventHandler(this.Создать_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.Создать);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.Button Создать;
    }
}