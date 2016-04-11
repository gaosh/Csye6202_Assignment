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

namespace StudentRegistrationWPF
{
    /// <summary>
    /// Delete.xaml 的交互逻辑
    /// </summary>
    public partial class Delete : Window
    {
        Model m = new Model();
        string ID;
        public Delete(Model model, string id)
        {
            InitializeComponent();
            LoadDepartments();
            LockBoxes();
            m = model;
            ID = id;
            InitData();
        }

        private void LockBoxes()
        {
            fn_txt.IsEnabled = false;
            ln_txt.IsEnabled = false;
            id_txt.IsEnabled = false;
            dp_cb.IsEnabled = false;
            rbt_ft.IsEnabled = false;
            rbt_pt.IsEnabled = false;

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
            
        }
        private void LoadDepartments()
        {
            dp_cb.ItemsSource = (new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to remove this student?",
                                     "Remove Confirm",
                                     MessageBoxButton.YesNo);
            if (confirmResult == MessageBoxResult.Yes)
            {
                m.Remove(m.ReturnList().Where(s => s.StudentID == ID).FirstOrDefault());
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
    }
}
