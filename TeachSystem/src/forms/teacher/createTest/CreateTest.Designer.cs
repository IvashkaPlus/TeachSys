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
            this.subjectLable = new System.Windows.Forms.Label();
            this.subjectList = new System.Windows.Forms.ComboBox();
            this.gradeCriteriaLable = new System.Windows.Forms.Label();
            this.addGradeCriteriaButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.listViewQuest = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAnswer = new System.Windows.Forms.ListView();
            this.columnANum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnsText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIsRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addAnswerButton = new System.Windows.Forms.Button();
            this.answerListLable = new System.Windows.Forms.Label();
            this.questionLable = new System.Windows.Forms.Label();
            this.criteriaInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTestButton
            // 
            this.createTestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTestButton.Location = new System.Drawing.Point(668, 409);
            this.createTestButton.Name = "createTestButton";
            this.createTestButton.Size = new System.Drawing.Size(79, 30);
            this.createTestButton.TabIndex = 0;
            this.createTestButton.Text = "Создать";
            this.createTestButton.UseVisualStyleBackColor = true;
            this.createTestButton.Click += new System.EventHandler(this.createTestButton_Click);
            // 
            // titBox
            // 
            this.titBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titBox.Location = new System.Drawing.Point(162, 60);
            this.titBox.Name = "titBox";
            this.titBox.Size = new System.Drawing.Size(585, 29);
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
            this.titleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLable.Location = new System.Drawing.Point(12, 9);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(164, 30);
            this.titleLable.TabIndex = 8;
            this.titleLable.Text = "Создание теста";
            // 
            // subjectLable
            // 
            this.subjectLable.AutoSize = true;
            this.subjectLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLable.Location = new System.Drawing.Point(15, 101);
            this.subjectLable.Name = "subjectLable";
            this.subjectLable.Size = new System.Drawing.Size(73, 21);
            this.subjectLable.TabIndex = 9;
            this.subjectLable.Text = "Предмет";
            // 
            // subjectList
            // 
            this.subjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.subjectList.FormattingEnabled = true;
            this.subjectList.Location = new System.Drawing.Point(162, 93);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(230, 29);
            this.subjectList.TabIndex = 10;
            // 
            // gradeCriteriaLable
            // 
            this.gradeCriteriaLable.AutoSize = true;
            this.gradeCriteriaLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeCriteriaLable.Location = new System.Drawing.Point(15, 137);
            this.gradeCriteriaLable.Name = "gradeCriteriaLable";
            this.gradeCriteriaLable.Size = new System.Drawing.Size(136, 21);
            this.gradeCriteriaLable.TabIndex = 11;
            this.gradeCriteriaLable.Text = "Критерии оценки";
            // 
            // addGradeCriteriaButton
            // 
            this.addGradeCriteriaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGradeCriteriaButton.Location = new System.Drawing.Point(162, 133);
            this.addGradeCriteriaButton.Name = "addGradeCriteriaButton";
            this.addGradeCriteriaButton.Size = new System.Drawing.Size(109, 30);
            this.addGradeCriteriaButton.TabIndex = 12;
            this.addGradeCriteriaButton.Text = "Добавить...";
            this.addGradeCriteriaButton.UseVisualStyleBackColor = true;
            this.addGradeCriteriaButton.Click += new System.EventHandler(this.addGradeCriteriaButton_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestionButton.Location = new System.Drawing.Point(236, 338);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(146, 30);
            this.addQuestionButton.TabIndex = 14;
            this.addQuestionButton.Text = "Добавить вопрос";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // listViewQuest
            // 
            this.listViewQuest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnText});
            this.listViewQuest.FullRowSelect = true;
            this.listViewQuest.GridLines = true;
            this.listViewQuest.Location = new System.Drawing.Point(19, 202);
            this.listViewQuest.MultiSelect = false;
            this.listViewQuest.Name = "listViewQuest";
            this.listViewQuest.Size = new System.Drawing.Size(363, 130);
            this.listViewQuest.TabIndex = 15;
            this.listViewQuest.UseCompatibleStateImageBehavior = false;
            this.listViewQuest.View = System.Windows.Forms.View.Details;
            this.listViewQuest.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewQuest_SelectedIndexChanged);
            // 
            // columnNum
            // 
            this.columnNum.Text = "Номер";
            // 
            // columnText
            // 
            this.columnText.Text = "Вопрос";
            this.columnText.Width = 298;
            // 
            // listViewAnswer
            // 
            this.listViewAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnANum,
            this.columnAnsText,
            this.columnIsRight});
            this.listViewAnswer.FullRowSelect = true;
            this.listViewAnswer.GridLines = true;
            this.listViewAnswer.Location = new System.Drawing.Point(388, 202);
            this.listViewAnswer.MultiSelect = false;
            this.listViewAnswer.Name = "listViewAnswer";
            this.listViewAnswer.Size = new System.Drawing.Size(363, 130);
            this.listViewAnswer.TabIndex = 23;
            this.listViewAnswer.UseCompatibleStateImageBehavior = false;
            this.listViewAnswer.View = System.Windows.Forms.View.Details;
            // 
            // columnANum
            // 
            this.columnANum.Text = "Номер";
            // 
            // columnAnsText
            // 
            this.columnAnsText.Text = "Ответ";
            this.columnAnsText.Width = 200;
            // 
            // columnIsRight
            // 
            this.columnIsRight.Text = "Правильность";
            this.columnIsRight.Width = 96;
            // 
            // addAnswerButton
            // 
            this.addAnswerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAnswerButton.Location = new System.Drawing.Point(605, 338);
            this.addAnswerButton.Name = "addAnswerButton";
            this.addAnswerButton.Size = new System.Drawing.Size(146, 30);
            this.addAnswerButton.TabIndex = 22;
            this.addAnswerButton.Text = "Добавить ответ";
            this.addAnswerButton.UseVisualStyleBackColor = true;
            this.addAnswerButton.Click += new System.EventHandler(this.addAnswerButton_Click);
            // 
            // answerListLable
            // 
            this.answerListLable.AutoSize = true;
            this.answerListLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerListLable.Location = new System.Drawing.Point(384, 178);
            this.answerListLable.Name = "answerListLable";
            this.answerListLable.Size = new System.Drawing.Size(122, 21);
            this.answerListLable.TabIndex = 24;
            this.answerListLable.Text = "Список ответов";
            // 
            // questionLable
            // 
            this.questionLable.AutoSize = true;
            this.questionLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLable.Location = new System.Drawing.Point(15, 178);
            this.questionLable.Name = "questionLable";
            this.questionLable.Size = new System.Drawing.Size(134, 21);
            this.questionLable.TabIndex = 25;
            this.questionLable.Text = "Список вопросов";
            // 
            // criteriaInfo
            // 
            this.criteriaInfo.AutoSize = true;
            this.criteriaInfo.Location = new System.Drawing.Point(278, 144);
            this.criteriaInfo.Name = "criteriaInfo";
            this.criteriaInfo.Size = new System.Drawing.Size(129, 13);
            this.criteriaInfo.TabIndex = 26;
            this.criteriaInfo.Text = "Критерии не добавлены";
            // 
            // CreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.criteriaInfo);
            this.Controls.Add(this.questionLable);
            this.Controls.Add(this.answerListLable);
            this.Controls.Add(this.listViewAnswer);
            this.Controls.Add(this.addAnswerButton);
            this.Controls.Add(this.listViewQuest);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.addGradeCriteriaButton);
            this.Controls.Add(this.gradeCriteriaLable);
            this.Controls.Add(this.subjectList);
            this.Controls.Add(this.subjectLable);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.titBox);
            this.Controls.Add(this.titLable);
            this.Controls.Add(this.createTestButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label subjectLable;
        private System.Windows.Forms.ComboBox subjectList;
        private System.Windows.Forms.Label gradeCriteriaLable;
        private System.Windows.Forms.Button addGradeCriteriaButton;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.ListView listViewQuest;
        private System.Windows.Forms.ListView listViewAnswer;
        private System.Windows.Forms.Button addAnswerButton;
        private System.Windows.Forms.Label answerListLable;
        private System.Windows.Forms.Label questionLable;
        private System.Windows.Forms.Label criteriaInfo;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.ColumnHeader columnANum;
        private System.Windows.Forms.ColumnHeader columnAnsText;
        private System.Windows.Forms.ColumnHeader columnIsRight;
    }
}