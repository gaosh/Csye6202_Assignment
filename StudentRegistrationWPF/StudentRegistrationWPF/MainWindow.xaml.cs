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
using System.Windows.Navigation;
using System.Windows.Shapes;
using StudentRegistrationWPF.Domain;
using System.Data;

namespace StudentRegistrationWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// StartupUri="MainWindow.xaml"
    /// </summary>
    public partial class MainWindow : Window
    {
        Model m = new Model();
        public MainWindow(Model model)
        {
            m = model;
            InitializeComponent();
            DefaultValue();
            LoadDepartments();
            LoadBindingData();
            
        }

        private void LoadDepartments()
        {
            dp_cb.ItemsSource = (new[] { "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" });
        }

        private void LoadBindingData()
        {
            IList<Student> Students = new List<Student>();
            Students = m.ReturnList();
            
            Students_DataGrid.ItemsSource = Students;
            
        }

        public void DefaultValue()
        {
            dp_cb.SelectedValue = "Information Systems";
            rbt_ft.IsChecked = true;
            fn_txt.Text = "TestUser";
            ln_txt.Text = "TextUser";
            id_txt.Text = "000-00-0000";
        }

        private void Students_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rbt_ft.IsChecked = false;
            rbt_pt.IsChecked = false;
            //Student student = (Student)Students_DataGrid.SelectedItems;
            foreach (Student student in Students_DataGrid.SelectedItems)
            {
                id_txt.Text = student.StudentID;
                fn_txt.Text = student.FirstName;
                ln_txt.Text = student.LastName;
                dp_cb.SelectedValue = student.Department;
                if (student.EnrollmentType == "Full Time")
                {
                    rbt_ft.IsChecked = true;
                }
                else if (student.EnrollmentType == "Part Time")
                {
                    rbt_pt.IsChecked = true;
                }
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            StudentRegistraion Add = new StudentRegistraion(m);
            Add.ShowDialog();
            Students_DataGrid.Items.Refresh();
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
           
            Student drv = (Student)Students_DataGrid.SelectedItem;
            if(drv == null)
            {
                MessageBox.Show("Please Select an Item!", "Edit Warning");
                return;
            }
            string id = drv.StudentID;
            Edit Edit = new Edit(m,id);
            Edit.ShowDialog();
            Students_DataGrid.Items.Refresh();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Student drv = (Student)Students_DataGrid.SelectedItem;
            if (drv == null)
            {
                MessageBox.Show("Please Select an Item!", "Remove Warning");
                return;
            }
            string id = drv.StudentID;
            Delete Delete = new Delete(m, id);
            Delete.ShowDialog();
            Students_DataGrid.Items.Refresh();
        }
    }
}
