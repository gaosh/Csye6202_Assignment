using StudentRegistration.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration.MVP
{
    public partial class EditStudent : Form
    {
        IModel m = new Model();
        static string ID;
        public EditStudent(IModel model, string id)
        {
            InitializeComponent();
            LoadDepartments();
            m = model;
            ID = id;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Student student;
            string enrolltype;

            if (txt_FirstName.Text.Trim().Length == 0 || txt_LastName.Text.Trim().Length == 0 || txt_ID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all the fields!","Edit Warning");
                return;
            }
            else
            {
                if (radioButtonFullTime.Checked == true)
                {
                    enrolltype = "Full Time";
                }
                else if (radioButtonPartTime.Checked == true)
                {
                    enrolltype = "Part Time";
                }
                else
                {
                    MessageBox.Show("Please choose only one enroll type!","Edit Warning");
                    return;
                }
                if (comboBoxDepartment.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a department!", "Edit Warning");
                    return;
                }
                //student = new Student(txt_ID.Text, txt_FirstName.Text, txt_LastName.Text, comboBoxDepartment.SelectedItem.ToString(), enrolltype);
                var confirmResult = MessageBox.Show("Are you sure you want to update this student?",
                                     "Update Confirm",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().StudentID = txt_ID.Text;
                    if (txt_ID.Text == ID)
                    {
                        m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().LastName = txt_LastName.Text;
                        m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().FirstName = txt_FirstName.Text;
                        m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().Department = comboBoxDepartment.SelectedItem.ToString();
                        m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().EnrollmentType = enrolltype;
                    }
                    else
                    {
                        m.ReturnList().Where(s => s.StudentID == txt_ID.Text).FirstOrDefault().LastName = txt_LastName.Text;
                        m.ReturnList().Where(s => s.StudentID == txt_ID.Text).FirstOrDefault().FirstName = txt_FirstName.Text;
                        m.ReturnList().Where(s => s.StudentID == txt_ID.Text).FirstOrDefault().Department = comboBoxDepartment.SelectedItem.ToString();
                        m.ReturnList().Where(s => s.StudentID == txt_ID.Text).FirstOrDefault().EnrollmentType = enrolltype;
                    }
                }
                else
                {
                    return;
                }


            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
