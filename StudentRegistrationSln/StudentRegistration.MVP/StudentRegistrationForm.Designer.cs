namespace StudentRegistration.MVP
{
	partial class StudentRegistrationForm
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBoxEnrollmentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.groupBoxEnrollmentType);
            this.groupBoxStudentInfo.Controls.Add(this.comboBoxDepartment);
            this.groupBoxStudentInfo.Controls.Add(this.textBox4);
            this.groupBoxStudentInfo.Controls.Add(this.textBox3);
            this.groupBoxStudentInfo.Controls.Add(this.textBox2);
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(81, 81);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 21);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 51);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 21);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 21);
            this.textBox2.TabIndex = 5;
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
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudents.Location = new System.Drawing.Point(10, 196);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(451, 267);
            this.dataGridViewStudents.TabIndex = 3;
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.HandleDataGridViewStudentsSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(500, 35);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 53);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "New Student";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(500, 120);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(111, 55);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "Remove Student";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(500, 207);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(111, 53);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "Edit Student";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 473);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 512);
            this.Name = "StudentRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.groupBoxEnrollmentType.ResumeLayout(false);
            this.groupBoxEnrollmentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxStudentInfo;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblStudentID;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBoxDepartment;
		private System.Windows.Forms.GroupBox groupBoxEnrollmentType;
		private System.Windows.Forms.RadioButton radioButtonPartTime;
		private System.Windows.Forms.RadioButton radioButtonFullTime;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
    }
}

