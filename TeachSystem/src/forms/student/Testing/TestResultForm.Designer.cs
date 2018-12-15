namespace TeachSystem
{
    partial class TestResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestResultForm));
            this.titleLable = new System.Windows.Forms.Label();
            this.rightAnswersLable = new System.Windows.Forms.Label();
            this.gradeLable = new System.Windows.Forms.Label();
            this.gradeInfo = new System.Windows.Forms.Label();
            this.endTestingButton = new System.Windows.Forms.Button();
            this.raCount = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.subTitleLable = new System.Windows.Forms.Label();
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
            this.titleLable.TabIndex = 9;
            this.titleLable.Text = "Тест - ";
            // 
            // rightAnswersLable
            // 
            this.rightAnswersLable.AutoSize = true;
            this.rightAnswersLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightAnswersLable.Location = new System.Drawing.Point(31, 115);
            this.rightAnswersLable.Name = "rightAnswersLable";
            this.rightAnswersLable.Size = new System.Drawing.Size(209, 21);
            this.rightAnswersLable.TabIndex = 10;
            this.rightAnswersLable.Text = "Кол-во правильных ответов";
            // 
            // gradeLable
            // 
            this.gradeLable.AutoSize = true;
            this.gradeLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLable.Location = new System.Drawing.Point(31, 165);
            this.gradeLable.Name = "gradeLable";
            this.gradeLable.Size = new System.Drawing.Size(65, 21);
            this.gradeLable.TabIndex = 11;
            this.gradeLable.Text = "Оценка";
            // 
            // gradeInfo
            // 
            this.gradeInfo.AutoSize = true;
            this.gradeInfo.Location = new System.Drawing.Point(207, 171);
            this.gradeInfo.Name = "gradeInfo";
            this.gradeInfo.Size = new System.Drawing.Size(46, 13);
            this.gradeInfo.TabIndex = 27;
            this.gradeInfo.Text = "<grade>";
            // 
            // endTestingButton
            // 
            this.endTestingButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.endTestingButton.Location = new System.Drawing.Point(101, 221);
            this.endTestingButton.Name = "endTestingButton";
            this.endTestingButton.Size = new System.Drawing.Size(183, 54);
            this.endTestingButton.TabIndex = 28;
            this.endTestingButton.Text = "ОК";
            this.endTestingButton.UseVisualStyleBackColor = true;
            this.endTestingButton.Click += new System.EventHandler(this.startTestingButton_Click);
            // 
            // raCount
            // 
            this.raCount.AutoSize = true;
            this.raCount.Location = new System.Drawing.Point(207, 121);
            this.raCount.Name = "raCount";
            this.raCount.Size = new System.Drawing.Size(63, 13);
            this.raCount.TabIndex = 29;
            this.raCount.Text = "<n> из <m>";
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Location = new System.Drawing.Point(207, 91);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(64, 13);
            this.subTitle.TabIndex = 31;
            this.subTitle.Text = "<Предмет>";
            // 
            // subTitleLable
            // 
            this.subTitleLable.AutoSize = true;
            this.subTitleLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLable.Location = new System.Drawing.Point(31, 85);
            this.subTitleLable.Name = "subTitleLable";
            this.subTitleLable.Size = new System.Drawing.Size(73, 21);
            this.subTitleLable.TabIndex = 30;
            this.subTitleLable.Text = "Предмет";
            // 
            // TestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.subTitleLable);
            this.Controls.Add(this.raCount);
            this.Controls.Add(this.endTestingButton);
            this.Controls.Add(this.gradeInfo);
            this.Controls.Add(this.gradeLable);
            this.Controls.Add(this.rightAnswersLable);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachSystem - Результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label rightAnswersLable;
        private System.Windows.Forms.Label gradeLable;
        private System.Windows.Forms.Label gradeInfo;
        private System.Windows.Forms.Button endTestingButton;
        private System.Windows.Forms.Label raCount;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Label subTitleLable;
    }
}