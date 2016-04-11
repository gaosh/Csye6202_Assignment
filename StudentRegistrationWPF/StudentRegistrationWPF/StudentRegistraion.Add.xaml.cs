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
    /// StudentRegistraion.xaml 的交互逻辑
    /// </summary>
    public partial class StudentRegistraion : Window
    {
        Model m = new Model();
        Student student;
        public StudentRegistraion(Model model)
        {
            m = model;
            
            InitializeComponent();
            DefaultValue();
            LoadDepartments();
        }

        

        public void DefaultValue()
        {
            dp_cb.SelectedValue = "Information Systems";
            rbt_ft.IsChecked = true;
            fn_txt.Text = "TestUser";
            ln_txt.Text = "TextUser";
            id_txt.Text = "000-00-0000";
        }

        private void LoadDepartments()
        {
            dp_cb.ItemsSource = (new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string enrolltype;

            if (fn_txt.Text.Trim().Length == 0 || ln_txt.Text.Trim().Length == 0 || id_txt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill in all the fields!", "Registration Warning");
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
                    MessageBox.Show("Please choose only one enroll type!", "Registration Warning");
                    return;
                }
                if (dp_cb.SelectedItem == null)
                {
                    MessageBox.Show("Please choose a department!", "Registration Warning");
                    return;
                }
                student = new Student(id_txt.Text, fn_txt.Text, ln_txt.Text, dp_cb.SelectedItem.ToString(), enrolltype);
                m.Add(student);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DefaultValue();
        }
        bool AisChecked = false;
        private void rbt_ft_Checked(object sender, RoutedEventArgs e)
        {
            AisChecked =(bool)rbt_ft.IsChecked;

        }
        bool BisChecked = false;
        private void rbt_pt_Checked(object sender, RoutedEventArgs e)
        {
            BisChecked = (bool)rbt_pt.IsChecked;
        }

        private void rbt_ft_Click(object sender, RoutedEventArgs e)
        {
            if((bool)rbt_ft.IsChecked && !AisChecked)
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
