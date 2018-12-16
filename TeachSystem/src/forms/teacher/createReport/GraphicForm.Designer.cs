namespace TeachSystem
{
    partial class GraphicForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicForm));
            this.avgGradeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.titLable = new System.Windows.Forms.Label();
            this.subTitleBox = new System.Windows.Forms.ComboBox();
            this.closeReportForm = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avgGradeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // avgGradeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.avgGradeChart.ChartAreas.Add(chartArea1);
            this.avgGradeChart.Location = new System.Drawing.Point(17, 116);
            this.avgGradeChart.Name = "avgGradeChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "groupSeries";
            this.avgGradeChart.Series.Add(series1);
            this.avgGradeChart.Size = new System.Drawing.Size(484, 300);
            this.avgGradeChart.TabIndex = 0;
            this.avgGradeChart.Text = "chart1";
            // 
            // titLable
            // 
            this.titLable.AutoSize = true;
            this.titLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titLable.Location = new System.Drawing.Point(12, 52);
            this.titLable.Name = "titLable";
            this.titLable.Size = new System.Drawing.Size(73, 21);
            this.titLable.TabIndex = 12;
            this.titLable.Text = "Предмет";
            // 
            // subTitleBox
            // 
            this.subTitleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subTitleBox.FormattingEnabled = true;
            this.subTitleBox.Location = new System.Drawing.Point(17, 76);
            this.subTitleBox.Name = "subTitleBox";
            this.subTitleBox.Size = new System.Drawing.Size(309, 21);
            this.subTitleBox.TabIndex = 11;
            this.subTitleBox.SelectedIndexChanged += new System.EventHandler(this.subTitleBox_SelectedIndexChanged);
            // 
            // closeReportForm
            // 
            this.closeReportForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeReportForm.Location = new System.Drawing.Point(426, 441);
            this.closeReportForm.Name = "closeReportForm";
            this.closeReportForm.Size = new System.Drawing.Size(75, 25);
            this.closeReportForm.TabIndex = 17;
            this.closeReportForm.Text = "Закрыть";
            this.closeReportForm.UseVisualStyleBackColor = true;
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(12, 12);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(84, 30);
            this.titleLable.TabIndex = 19;
            this.titleLable.Text = "График";
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 478);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.closeReportForm);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.subTitleBox);
            this.Controls.Add(this.avgGradeChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphicForm";
            this.Text = "TeachSystem - График";
            ((System.ComponentModel.ISupportInitialize)(this.avgGradeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart avgGradeChart;
        private System.Windows.Forms.Label titLable;
        private System.Windows.Forms.ComboBox subTitleBox;
        private System.Windows.Forms.Button closeReportForm;
        private System.Windows.Forms.Label titleLable;
    }
}