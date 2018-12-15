namespace TeachSystem
{
    partial class TestInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestInfoForm));
            this.titleLable = new System.Windows.Forms.Label();
            this.qCountLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.criteriaInfo = new System.Windows.Forms.Label();
            this.startTestingButton = new System.Windows.Forms.Button();
            this.qCount = new System.Windows.Forms.Label();
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
            // qCountLable
            // 
            this.qCountLable.AutoSize = true;
            this.qCountLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qCountLable.Location = new System.Drawing.Point(31, 115);
            this.qCountLable.Name = "qCountLable";
            this.qCountLable.Size = new System.Drawing.Size(165, 21);
            this.qCountLable.TabIndex = 10;
            this.qCountLable.Text = "Количество вопросов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Критерии оценивания";
            // 
            // criteriaInfo
            // 
            this.criteriaInfo.AutoSize = true;
            this.criteriaInfo.Location = new System.Drawing.Point(207, 151);
            this.criteriaInfo.Name = "criteriaInfo";
            this.criteriaInfo.Size = new System.Drawing.Size(129, 13);
            this.criteriaInfo.TabIndex = 27;
            this.criteriaInfo.Text = "Критерии не добавлены";
            // 
            // startTestingButton
            // 
            this.startTestingButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.startTestingButton.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.startTestingButton.Location = new System.Drawing.Point(101, 221);
            this.startTestingButton.Name = "startTestingButton";
            this.startTestingButton.Size = new System.Drawing.Size(183, 54);
            this.startTestingButton.TabIndex = 28;
            this.startTestingButton.Text = "НАЧАТЬ";
            this.startTestingButton.UseVisualStyleBackColor = true;
            // 
            // qCount
            // 
            this.qCount.AutoSize = true;
            this.qCount.Location = new System.Drawing.Point(207, 121);
            this.qCount.Name = "qCount";
            this.qCount.Size = new System.Drawing.Size(25, 13);
            this.qCount.TabIndex = 29;
            this.qCount.Text = "<n>";
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
            // TestInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.subTitleLable);
            this.Controls.Add(this.qCount);
            this.Controls.Add(this.startTestingButton);
            this.Controls.Add(this.criteriaInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qCountLable);
            this.Controls.Add(this.titleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachSystem - Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label qCountLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label criteriaInfo;
        private System.Windows.Forms.Button startTestingButton;
        private System.Windows.Forms.Label qCount;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Label subTitleLable;
    }
}