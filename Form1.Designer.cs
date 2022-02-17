namespace FranklinStudentFormDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbStudentID = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.rbWebDesign = new System.Windows.Forms.RadioButton();
            this.rbProgramming = new System.Windows.Forms.RadioButton();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxCIS101 = new System.Windows.Forms.CheckBox();
            this.cbxCIS102 = new System.Windows.Forms.CheckBox();
            this.cbxCIS103 = new System.Windows.Forms.CheckBox();
            this.cbxCIS104 = new System.Windows.Forms.CheckBox();
            this.txbScore1 = new System.Windows.Forms.TextBox();
            this.txbScore2 = new System.Windows.Forms.TextBox();
            this.txbScore3 = new System.Windows.Forms.TextBox();
            this.txbScore4 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentID.Location = new System.Drawing.Point(63, 55);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(118, 30);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFirstName.Location = new System.Drawing.Point(63, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(119, 30);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLastName.Location = new System.Drawing.Point(63, 186);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 30);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txbStudentID
            // 
            this.txbStudentID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbStudentID.Location = new System.Drawing.Point(216, 55);
            this.txbStudentID.Name = "txbStudentID";
            this.txbStudentID.Size = new System.Drawing.Size(175, 35);
            this.txbStudentID.TabIndex = 3;
            // 
            // txbFirstName
            // 
            this.txbFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbFirstName.Location = new System.Drawing.Point(216, 120);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(175, 35);
            this.txbFirstName.TabIndex = 4;
            // 
            // txbLastName
            // 
            this.txbLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbLastName.Location = new System.Drawing.Point(216, 186);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(175, 35);
            this.txbLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIT);
            this.groupBox1.Controls.Add(this.rbWebDesign);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(63, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Major";
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(11, 135);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(55, 34);
            this.rbIT.TabIndex = 9;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rbIT_CheckedChanged);
            // 
            // rbWebDesign
            // 
            this.rbWebDesign.AutoSize = true;
            this.rbWebDesign.Location = new System.Drawing.Point(11, 84);
            this.rbWebDesign.Name = "rbWebDesign";
            this.rbWebDesign.Size = new System.Drawing.Size(150, 34);
            this.rbWebDesign.TabIndex = 8;
            this.rbWebDesign.TabStop = true;
            this.rbWebDesign.Text = "Web Design";
            this.rbWebDesign.UseVisualStyleBackColor = true;
            this.rbWebDesign.CheckedChanged += new System.EventHandler(this.rbWebDesign_CheckedChanged);
            // 
            // rbProgramming
            // 
            this.rbProgramming.AutoSize = true;
            this.rbProgramming.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbProgramming.Location = new System.Drawing.Point(74, 380);
            this.rbProgramming.Name = "rbProgramming";
            this.rbProgramming.Size = new System.Drawing.Size(164, 34);
            this.rbProgramming.TabIndex = 7;
            this.rbProgramming.TabStop = true;
            this.rbProgramming.Text = "Programming";
            this.rbProgramming.UseVisualStyleBackColor = true;
            this.rbProgramming.CheckedChanged += new System.EventHandler(this.rbProgramming_CheckedChanged);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourses.Location = new System.Drawing.Point(476, 345);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(80, 30);
            this.lblCourses.TabIndex = 8;
            this.lblCourses.Text = "Course";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblScores.Location = new System.Drawing.Point(623, 345);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(67, 30);
            this.lblScores.TabIndex = 9;
            this.lblScores.Text = "Score";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(476, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 65);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Student Info";
            // 
            // cbxCIS101
            // 
            this.cbxCIS101.AutoSize = true;
            this.cbxCIS101.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxCIS101.Location = new System.Drawing.Point(476, 390);
            this.cbxCIS101.Name = "cbxCIS101";
            this.cbxCIS101.Size = new System.Drawing.Size(108, 34);
            this.cbxCIS101.TabIndex = 11;
            this.cbxCIS101.Text = "CIS 101";
            this.cbxCIS101.UseVisualStyleBackColor = true;
            // 
            // cbxCIS102
            // 
            this.cbxCIS102.AutoSize = true;
            this.cbxCIS102.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxCIS102.Location = new System.Drawing.Point(476, 430);
            this.cbxCIS102.Name = "cbxCIS102";
            this.cbxCIS102.Size = new System.Drawing.Size(108, 34);
            this.cbxCIS102.TabIndex = 12;
            this.cbxCIS102.Text = "CIS 102";
            this.cbxCIS102.UseVisualStyleBackColor = true;
            // 
            // cbxCIS103
            // 
            this.cbxCIS103.AutoSize = true;
            this.cbxCIS103.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxCIS103.Location = new System.Drawing.Point(476, 470);
            this.cbxCIS103.Name = "cbxCIS103";
            this.cbxCIS103.Size = new System.Drawing.Size(108, 34);
            this.cbxCIS103.TabIndex = 13;
            this.cbxCIS103.Text = "CIS 103";
            this.cbxCIS103.UseVisualStyleBackColor = true;
            // 
            // cbxCIS104
            // 
            this.cbxCIS104.AutoSize = true;
            this.cbxCIS104.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxCIS104.Location = new System.Drawing.Point(476, 510);
            this.cbxCIS104.Name = "cbxCIS104";
            this.cbxCIS104.Size = new System.Drawing.Size(108, 34);
            this.cbxCIS104.TabIndex = 14;
            this.cbxCIS104.Text = "CIS 104";
            this.cbxCIS104.UseVisualStyleBackColor = true;
            // 
            // txbScore1
            // 
            this.txbScore1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbScore1.Location = new System.Drawing.Point(623, 390);
            this.txbScore1.Name = "txbScore1";
            this.txbScore1.Size = new System.Drawing.Size(67, 35);
            this.txbScore1.TabIndex = 15;
            this.txbScore1.TextChanged += new System.EventHandler(this.txbScore1_TextChanged);
            // 
            // txbScore2
            // 
            this.txbScore2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbScore2.Location = new System.Drawing.Point(623, 430);
            this.txbScore2.Name = "txbScore2";
            this.txbScore2.Size = new System.Drawing.Size(67, 35);
            this.txbScore2.TabIndex = 16;
            this.txbScore2.TextChanged += new System.EventHandler(this.txbScore2_TextChanged);
            // 
            // txbScore3
            // 
            this.txbScore3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbScore3.Location = new System.Drawing.Point(623, 470);
            this.txbScore3.Name = "txbScore3";
            this.txbScore3.Size = new System.Drawing.Size(67, 35);
            this.txbScore3.TabIndex = 17;
            this.txbScore3.TextChanged += new System.EventHandler(this.txbScore3_TextChanged);
            // 
            // txbScore4
            // 
            this.txbScore4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbScore4.Location = new System.Drawing.Point(623, 510);
            this.txbScore4.Name = "txbScore4";
            this.txbScore4.Size = new System.Drawing.Size(67, 35);
            this.txbScore4.TabIndex = 18;
            this.txbScore4.TextChanged += new System.EventHandler(this.txbScore4_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmit.Location = new System.Drawing.Point(785, 504);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 40);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txbResult
            // 
            this.txbResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txbResult.Location = new System.Drawing.Point(738, 98);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(409, 365);
            this.txbResult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 626);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbScore4);
            this.Controls.Add(this.txbScore3);
            this.Controls.Add(this.txbScore2);
            this.Controls.Add(this.txbScore1);
            this.Controls.Add(this.cbxCIS104);
            this.Controls.Add(this.cbxCIS103);
            this.Controls.Add(this.cbxCIS102);
            this.Controls.Add(this.cbxCIS101);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.rbProgramming);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbStudentID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "My First Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbStudentID;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.RadioButton rbWebDesign;
        private System.Windows.Forms.RadioButton rbProgramming;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox cbxCIS101;
        private System.Windows.Forms.CheckBox cbxCIS102;
        private System.Windows.Forms.CheckBox cbxCIS103;
        private System.Windows.Forms.CheckBox cbxCIS104;
        private System.Windows.Forms.TextBox txbScore1;
        private System.Windows.Forms.TextBox txbScore2;
        private System.Windows.Forms.TextBox txbScore3;
        private System.Windows.Forms.TextBox txbScore4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txbResult;
    }
}
