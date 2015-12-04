﻿namespace StudentsRegistrationAppAssignmnet
{
    partial class frmAddStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpEnrolmentType = new System.Windows.Forms.GroupBox();
            this.rbPartTime = new System.Windows.Forms.RadioButton();
            this.rbFullTime = new System.Windows.Forms.RadioButton();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpEnrolmentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpEnrolmentType);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // grpEnrolmentType
            // 
            this.grpEnrolmentType.Controls.Add(this.rbPartTime);
            this.grpEnrolmentType.Controls.Add(this.rbFullTime);
            this.grpEnrolmentType.Location = new System.Drawing.Point(337, 37);
            this.grpEnrolmentType.Name = "grpEnrolmentType";
            this.grpEnrolmentType.Size = new System.Drawing.Size(245, 100);
            this.grpEnrolmentType.TabIndex = 8;
            this.grpEnrolmentType.TabStop = false;
            this.grpEnrolmentType.Text = "Enrollment Type";
            // 
            // rbPartTime
            // 
            this.rbPartTime.AutoSize = true;
            this.rbPartTime.Location = new System.Drawing.Point(115, 30);
            this.rbPartTime.Name = "rbPartTime";
            this.rbPartTime.Size = new System.Drawing.Size(70, 17);
            this.rbPartTime.TabIndex = 1;
            this.rbPartTime.Text = "Part Time";
            this.rbPartTime.UseVisualStyleBackColor = true;
            this.rbPartTime.CheckedChanged += new System.EventHandler(this.EnableResetButton);
            // 
            // rbFullTime
            // 
            this.rbFullTime.AutoSize = true;
            this.rbFullTime.Checked = true;
            this.rbFullTime.Location = new System.Drawing.Point(7, 30);
            this.rbFullTime.Name = "rbFullTime";
            this.rbFullTime.Size = new System.Drawing.Size(64, 17);
            this.rbFullTime.TabIndex = 0;
            this.rbFullTime.TabStop = true;
            this.rbFullTime.Text = "FullTime";
            this.rbFullTime.UseVisualStyleBackColor = true;
            this.rbFullTime.CheckedChanged += new System.EventHandler(this.EnableResetButton);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "",
            "Information Systems",
            "International Affairs",
            "Nursing",
            "Pharmacy",
            "Professional Studies",
            "Psychology",
            "Public Administration"});
            this.cmbDepartment.Location = new System.Drawing.Point(135, 168);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(144, 21);
            this.cmbDepartment.TabIndex = 7;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.EnableResetButton);
            this.cmbDepartment.TextChanged += new System.EventHandler(this.EnableResetButton);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 121);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.TextChanged += new System.EventHandler(this.EnableResetButton);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.TextChanged += new System.EventHandler(this.EnableResetButton);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(135, 38);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(144, 20);
            this.txtStudentID.TabIndex = 4;
            this.txtStudentID.TextChanged += new System.EventHandler(this.EnableResetButton);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(513, 298);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 34);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 386);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(228, 162);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.Text = "New Student Registration";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEnrolmentType.ResumeLayout(false);
            this.grpEnrolmentType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpEnrolmentType;
        private System.Windows.Forms.RadioButton rbPartTime;
        private System.Windows.Forms.RadioButton rbFullTime;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
    }
}