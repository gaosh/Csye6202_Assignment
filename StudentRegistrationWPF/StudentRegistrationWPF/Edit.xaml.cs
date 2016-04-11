using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StudentRegistrationWPF.Domain;

namespace StudentRegistrationWPF
{
    /// <summary>
    /// Edit.xaml 的交互逻辑
    /// </summary>
    public partial class Edit : Window
    {
        Model m = new Model();
        static string ID;
        Student Oldstudent;
        public Edit(Model model, string id)
        {

            InitializeComponent();
            LoadDepartments();
            m = model;
            ID = id;
            InitData();
        }

        private void LoadDepartments()
        {
            dp_cb.ItemsSource = (new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        public void InitData()
        {
            id_txt.Text = ID;
            fn_txt.Text = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().FirstName;
            ln_txt.Text = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().LastName;
            dp_cb.SelectedItem = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().Department;
            if (m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().EnrollmentType == "Full Time")
            {
                rbt_ft.IsChecked = true;
            }
            else
            {
                rbt_pt.IsChecked = true;
            }
            Oldstudent = m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string enrolltype;

            if (fn_txt.Text.Trim().Length == 0 || ln_txt.Text.Trim().Length == 0 || id_txt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all the fields!", "Edit Warning");
                return;
            }
            else
            {
                if (rbt_ft.IsChecked == true && rbt_pt.IsChecked == false)
                {
                    enrolltype = "Full Time";
                }
                else if (rbt_pt.IsChecked == true && rbt_ft.IsChecked == false)
                {
                    enrolltype = "Part Time";
                }
                else
                {
                    MessageBox.Show("Please choose only one enroll type!", "Edit Warning");
                    return;
                }
                if (dp_cb.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a department!", "Edit Warning");
                    return;
                }
            }
            var confirmResult = MessageBox.Show("Are you sure you want to update this student?",
                     "Update Confirm",
                     MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                Student student = new Student(ID, fn_txt.Text, ln_txt.Text, dp_cb.Text, enrolltype);
                student.StudentID = id_txt.Text;
                MessageBox.Show(m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault().StudentID);
                m.Add(student);
                int i = m.ReturnList().IndexOf(m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault());
                Swap(m.ReturnList(), i, m.ReturnList().Count - 1);
                m.ReturnList().Remove(Oldstudent);
                this.Close();
            }
            else
            {
                return;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private static void Swap(List<Student> list, int indexA, int indexB)
        {
            Student tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        bool AisChecked = false;
        private void rbt_ft_Checked(object sender, RoutedEventArgs e)
        {
            AisChecked = (bool)rbt_ft.IsChecked;

        }
        bool BisChecked = false;
        private void rbt_pt_Checked(object sender, RoutedEventArgs e)
        {
            BisChecked = (bool)rbt_pt.IsChecked;
        }

        private void rbt_ft_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbt_ft.IsChecked && !AisChecked)
            {
                rbt_ft.IsChecked = false;
            }
            else
            {
                rbt_ft.IsChecked = true;
                AisChecked = false;
            }

        }
        private void rbt_pt_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbt_pt.IsChecked && !BisChecked)
            {
                rbt_pt.IsChecked = false;
            }
            else
            {
                rbt_pt.IsChecked = true;
                BisChecked = false;
            }
        }
    }
}

