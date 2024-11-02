namespace AssignmentPRN
{
    partial class fTest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbExamCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btNext = new System.Windows.Forms.Button();
            this.checkLbAns = new System.Windows.Forms.CheckedListBox();
            this.lbNotic = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.cbFinish = new System.Windows.Forms.CheckBox();
            this.btFinish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exam Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Left:";
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.AutoSize = true;
            this.lbTimeLeft.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTimeLeft.ForeColor = System.Drawing.Color.Red;
            this.lbTimeLeft.Location = new System.Drawing.Point(565, 72);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(77, 62);
            this.lbTimeLeft.TabIndex = 4;
            this.lbTimeLeft.Text = "00";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStudentName.ForeColor = System.Drawing.Color.Blue;
            this.lbStudentName.Location = new System.Drawing.Point(167, 41);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(51, 20);
            this.lbStudentName.TabIndex = 5;
            this.lbStudentName.Text = "label5";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDuration.ForeColor = System.Drawing.Color.Blue;
            this.lbDuration.Location = new System.Drawing.Point(167, 106);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(51, 20);
            this.lbDuration.TabIndex = 6;
            this.lbDuration.Text = "label6";
            // 
            // lbExamCode
            // 
            this.lbExamCode.AutoSize = true;
            this.lbExamCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbExamCode.ForeColor = System.Drawing.Color.Blue;
            this.lbExamCode.Location = new System.Drawing.Point(578, 41);
            this.lbExamCode.Name = "lbExamCode";
            this.lbExamCode.Size = new System.Drawing.Size(51, 20);
            this.lbExamCode.TabIndex = 7;
            this.lbExamCode.Text = "label7";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Controls.Add(this.checkLbAns);
            this.panel1.Controls.Add(this.lbNotic);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rtbQuestion);
            this.panel1.Location = new System.Drawing.Point(34, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 517);
            this.panel1.TabIndex = 8;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(16, 314);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(94, 29);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // checkLbAns
            // 
            this.checkLbAns.CheckOnClick = true;
            this.checkLbAns.FormattingEnabled = true;
            this.checkLbAns.Location = new System.Drawing.Point(16, 98);
            this.checkLbAns.MultiColumn = true;
            this.checkLbAns.Name = "checkLbAns";
            this.checkLbAns.Size = new System.Drawing.Size(103, 158);
            this.checkLbAns.TabIndex = 3;
            this.checkLbAns.SelectedIndexChanged += new System.EventHandler(this.checkLbAns_SelectedIndexChanged);
            // 
            // lbNotic
            // 
            this.lbNotic.AutoSize = true;
            this.lbNotic.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNotic.ForeColor = System.Drawing.Color.Blue;
            this.lbNotic.Location = new System.Drawing.Point(148, 25);
            this.lbNotic.Name = "lbNotic";
            this.lbNotic.Size = new System.Drawing.Size(143, 25);
            this.lbNotic.TabIndex = 2;
            this.lbNotic.Text = "Multiple choice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Choose Answer:";
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbQuestion.Location = new System.Drawing.Point(148, 64);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(846, 429);
            this.rtbQuestion.TabIndex = 0;
            this.rtbQuestion.Text = "";
            // 
            // cbFinish
            // 
            this.cbFinish.AutoSize = true;
            this.cbFinish.Location = new System.Drawing.Point(34, 714);
            this.cbFinish.Name = "cbFinish";
            this.cbFinish.Size = new System.Drawing.Size(193, 24);
            this.cbFinish.TabIndex = 9;
            this.cbFinish.Text = "I want to finish the exam";
            this.cbFinish.UseVisualStyleBackColor = true;
            // 
            // btFinish
            // 
            this.btFinish.BackColor = System.Drawing.Color.AliceBlue;
            this.btFinish.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btFinish.ForeColor = System.Drawing.Color.Blue;
            this.btFinish.Location = new System.Drawing.Point(34, 762);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(94, 29);
            this.btFinish.TabIndex = 10;
            this.btFinish.Text = "Finish";
            this.btFinish.UseVisualStyleBackColor = false;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(168, 768);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btClose.Location = new System.Drawing.Point(975, 762);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 29);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Visible = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 803);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.cbFinish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbExamCode);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.lbTimeLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fTest";
            this.Text = "fTest";
            this.Load += new System.EventHandler(this.fTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbExamCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkLbAns;
        private System.Windows.Forms.Label lbNotic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.CheckBox cbFinish;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClose;
    }
}