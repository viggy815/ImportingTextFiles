namespace Vignero_Text_Files
{
    partial class StudentScores
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbStudentScores = new System.Windows.Forms.GroupBox();
            this.lblScores = new System.Windows.Forms.Label();
            this.gbHighestScore = new System.Windows.Forms.GroupBox();
            this.lblHighest = new System.Windows.Forms.Label();
            this.gbAverage = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.gbStudentScores.SuspendLayout();
            this.gbHighestScore.SuspendLayout();
            this.gbAverage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbStudentScores
            // 
            this.gbStudentScores.Controls.Add(this.lblScores);
            this.gbStudentScores.Location = new System.Drawing.Point(103, 12);
            this.gbStudentScores.Name = "gbStudentScores";
            this.gbStudentScores.Size = new System.Drawing.Size(180, 319);
            this.gbStudentScores.TabIndex = 3;
            this.gbStudentScores.TabStop = false;
            this.gbStudentScores.Text = "Student Scores";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(6, 28);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(0, 13);
            this.lblScores.TabIndex = 0;
            // 
            // gbHighestScore
            // 
            this.gbHighestScore.Controls.Add(this.lblHighest);
            this.gbHighestScore.Location = new System.Drawing.Point(289, 12);
            this.gbHighestScore.Name = "gbHighestScore";
            this.gbHighestScore.Size = new System.Drawing.Size(200, 100);
            this.gbHighestScore.TabIndex = 4;
            this.gbHighestScore.TabStop = false;
            this.gbHighestScore.Text = "Student w/Highest Score";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(34, 46);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(0, 13);
            this.lblHighest.TabIndex = 0;
            // 
            // gbAverage
            // 
            this.gbAverage.Controls.Add(this.lblAverage);
            this.gbAverage.Location = new System.Drawing.Point(289, 231);
            this.gbAverage.Name = "gbAverage";
            this.gbAverage.Size = new System.Drawing.Size(200, 100);
            this.gbAverage.TabIndex = 5;
            this.gbAverage.TabStop = false;
            this.gbAverage.Text = "Average Score";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(82, 48);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 13);
            this.lblAverage.TabIndex = 0;
            // 
            // StudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 374);
            this.Controls.Add(this.gbAverage);
            this.Controls.Add(this.gbHighestScore);
            this.Controls.Add(this.gbStudentScores);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Name = "StudentScores";
            this.Text = "Student Scores";
            this.gbStudentScores.ResumeLayout(false);
            this.gbStudentScores.PerformLayout();
            this.gbHighestScore.ResumeLayout(false);
            this.gbHighestScore.PerformLayout();
            this.gbAverage.ResumeLayout(false);
            this.gbAverage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbStudentScores;
        private System.Windows.Forms.GroupBox gbHighestScore;
        private System.Windows.Forms.GroupBox gbAverage;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label lblAverage;
    }
}

