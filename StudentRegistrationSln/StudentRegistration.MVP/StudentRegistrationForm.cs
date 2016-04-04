#region Using Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using StudentRegistration.Domain;

#endregion

namespace StudentRegistration.MVP
{
	public partial class StudentRegistrationForm : Form, IStudentRegistrationForm
	{

		public event EventHandler DataChanged;
        private IModel m = new Model();
		#region Constructors

		public StudentRegistrationForm()
		{
			InitializeComponent();
			Init();
            
		}

		#endregion

		#region Methods

		// good software programming practice!!
		private void Init()
		{			
			LoadDepartments();
			LoadDataGridWithMockData();
			LoadDefaults();
		}

        public void InitModel(IModel model)
        {
            this.m = model;
        }

		private void LoadDepartments()
		{
			comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
				"Professional Studies", "Psychology", "Public Administration" });
		}

		// since we don't know ADO.NET and/or File I/O we will get static mock data
		private void LoadDataGridWithMockData()
		{
			var bindingList = new BindingList<Student>(m.ReturnList());
			var source = new BindingSource(bindingList, null);
            if (source != null && source.Count > 0) dataGridViewStudents.DataSource = source;
		}

		private void LoadDefaults()
		{
			radioButtonFullTime.Select();
			comboBoxDepartment.SelectedIndex = 0;

		}

		#endregion

		private void HandleDataGridViewStudentsSelectionChanged(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
			{
				textBox2.Text = row.Cells[0].Value.ToString();
				textBox3.Text = row.Cells[1].Value.ToString();
				textBox4.Text = row.Cells[2].Value.ToString();

				comboBoxDepartment.SelectedIndex = comboBoxDepartment.Items.IndexOf(row.Cells[3].Value.ToString());

				// enrollment type selection driven by the grid itself
				var enrollmentType = row.Cells[4].Value.ToString();
				if (radioButtonFullTime.Text == enrollmentType)
				{
					radioButtonFullTime.Checked = true;
				}
				else if (radioButtonPartTime.Text == enrollmentType)
				{
					radioButtonPartTime.Checked = true;
				}
			}
		}

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration(m);
            reg.ShowDialog();
            LoadDataGridWithMockData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = dataGridViewStudents.SelectedCells[0].Value.ToString();
            EditStudent es = new EditStudent(m, id);
            es.ShowDialog();
            LoadDataGridWithMockData();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string id = dataGridViewStudents.SelectedCells[0].Value.ToString();
            RemoveStudent rs = new RemoveStudent(m, id);
            rs.ShowDialog();
            LoadDataGridWithMockData();
        }
    }
}
