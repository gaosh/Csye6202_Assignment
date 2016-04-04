using System;
using System.Windows.Forms;
using StudentRegistration.Domain;


namespace StudentRegistration.MVP
{
    public partial class Registration : Form
    {
        IModel m = new Model();
        Student student;
        public Registration(IModel model)
        {
            InitializeComponent();
            LoadDepartments();
            m = model;
            
            
        }


        private void LoadDepartments()
        {
            comboBoxDepartment.Items.AddRange(new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
            comboBoxDepartment.SelectedItem = "Information Systems";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            string enrolltype;

            if (txt_FirstName.Text.Trim().Length==0||txt_LastName.Text.Trim().Length==0||txt_ID.Text.Trim().Length==0)
            {
                MessageBox.Show("Please fill in all the fields!","Registration Warning");
                return;
            }
            else
            {
                if(radioButtonFullTime.Checked == true)
                {
                    enrolltype = "Full Time";
                }
                else if (radioButtonPartTime.Checked == true)
                {
                    enrolltype = "Part Time";
                }
                else
                {
                    MessageBox.Show("Please choose only one enroll type!", "Registration Warning");
                    return;
                }
                if (comboBoxDepartment.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a department!", "Registration Warning");
                    return;
                }
                student = new Student(txt_ID.Text, txt_FirstName.Text, txt_LastName.Text, comboBoxDepartment.SelectedItem.ToString(), enrolltype);
                m.Add(student);
                
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_FirstName.Text = "";
            txt_ID.Text = "";
            txt_LastName.Text = "";
            comboBoxDepartment.SelectedItem = null;
            radioButtonFullTime.Checked = false;
            radioButtonPartTime.Checked = false;
        }
    }
}
