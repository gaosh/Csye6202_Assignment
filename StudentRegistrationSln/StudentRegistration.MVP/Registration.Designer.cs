namespace StudentRegistration.MVP
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxEnrollmentType = new System.Windows.Forms.GroupBox();
            this.radioButtonPartTime = new System.Windows.Forms.RadioButton();
            this.radioButtonFullTime = new System.Windows.Forms.RadioButton();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBoxEnrollmentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.groupBoxEnrollmentType);
            this.groupBoxStudentInfo.Controls.Add(this.comboBoxDepartment);
            this.groupBoxStudentInfo.Controls.Add(this.txt_LastName);
            this.groupBoxStudentInfo.Controls.Add(this.txt_FirstName);
            this.groupBoxStudentInfo.Controls.Add(this.txt_ID);
            this.groupBoxStudentInfo.Controls.Add(this.lblDepartment);
            this.groupBoxStudentInfo.Controls.Add(this.lblLastName);
            this.groupBoxStudentInfo.Controls.Add(this.lblFirstName);
            this.groupBoxStudentInfo.Controls.Add(this.lblStudentID);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(10, 10);
            this.groupBoxStudentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(451, 173);
            this.groupBoxStudentInfo.TabIndex = 0;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "Student Info";
            // 
            // groupBoxEnrollmentType
            // 
            this.groupBoxEnrollmentType.Controls.Add(this.radioButtonPartTime);
            this.groupBoxEnrollmentType.Controls.Add(this.radioButtonFullTime);
            this.groupBoxEnrollmentType.Location = new System.Drawing.Point(237, 25);
            this.groupBoxEnrollmentType.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEnrollmentType.Name = "groupBoxEnrollmentType";
            this.groupBoxEnrollmentType.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEnrollmentType.Size = new System.Drawing.Size(193, 106);
            this.groupBoxEnrollmentType.TabIndex = 9;
            this.groupBoxEnrollmentType.TabStop = false;
            this.groupBoxEnrollmentType.Text = "Enrollment Type";
            // 
            // radioButtonPartTime
            // 
            this.radioButtonPartTime.AutoSize = true;
            this.radioButtonPartTime.Location = new System.Drawing.Point(106, 46);
            this.radioButtonPartTime.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPartTime.Name = "radioButtonPartTime";
            this.radioButtonPartTime.Size = new System.Drawing.Size(77, 16);
            this.radioButtonPartTime.TabIndex = 1;
            this.radioButtonPartTime.TabStop = true;
            this.radioButtonPartTime.Text = "Part Time";
            this.radioButtonPartTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonFullTime
            // 
            this.radioButtonFullTime.AutoSize = true;
            this.radioButtonFullTime.Checked = true;
            this.radioButtonFullTime.Location = new System.Drawing.Point(5, 46);
            this.radioButtonFullTime.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFullTime.Name = "radioButtonFullTime";
            this.radioButtonFullTime.Size = new System.Drawing.Size(77, 16);
            this.radioButtonFullTime.TabIndex = 0;
            this.radioButtonFullTime.TabStop = true;
            this.radioButtonFullTime.Text = "Full Time";
            this.radioButtonFullTime.UseVisualStyleBackColor = true;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(81, 110);
            this.comboBoxDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(128, 20);
            this.comboBoxDepartment.TabIndex = 8;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(81, 81);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(128, 21);
            this.txt_LastName.TabIndex = 7;
            this.txt_LastName.Text = "TextUser";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(81, 51);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(128, 21);
            this.txt_FirstName.TabIndex = 6;
            this.txt_FirstName.Text = "TestUser";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(81, 22);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(128, 21);
            this.txt_ID.TabIndex = 5;
            this.txt_ID.Text = "000-00-0000";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(14, 115);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 12);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 85);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 12);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 55);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 12);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(14, 25);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 12);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(340, 199);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 39);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(202, 199);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 39);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 281);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 300);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.groupBoxEnrollmentType.ResumeLayout(false);
            this.groupBoxEnrollmentType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentInfo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.GroupBox groupBoxEnrollmentType;
        private System.Windows.Forms.RadioButton radioButtonPartTime;
        private System.Windows.Forms.RadioButton radioButtonFullTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reset;
    }
}