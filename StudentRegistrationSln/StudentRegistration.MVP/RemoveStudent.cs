using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StudentRegistration.MVP
{
    public partial class RemoveStudent : Form
    {
        IModel m = new Model();
        string ID;
        public RemoveStudent(IModel model, string id)
        {
            InitializeComponent();
            m = model;
            ID = id;
            LoadDepartments();
            InitData();
            
        }
        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
            comboBoxDepartment.SelectedItem = "Information Systems";
        }
        public void InitData()
        {
            txt_ID.Text = ID;
            txt_FirstName.Text = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().FirstName;
            txt_LastName.Text = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().LastName;
            comboBoxDepartment.SelectedItem = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().Department;
            if (m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().EnrollmentType == "Full Time")
            {
                radioButtonFullTime.Checked = true;
            }
            else
            {
                radioButtonPartTime.Checked = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove this student?",
                                     "Remove Confirm",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                m.Remove(m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault());
            }
            else
            {
                return;
            }
        }
    }
}
