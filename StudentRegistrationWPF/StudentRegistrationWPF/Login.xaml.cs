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
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        bool b = false;
        int i = 0;
        private void btn_Signin_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                if ((user_txt.Text == "gao") && (password_txt.Password == "922815"))
                {
                    b = true;
                    this.loginSuccess();
                    break;
                }
                else
                {
                    user_txt.Text = "";
                    password_txt.Password = "";
                    b = false;
                    i++;
                    if (i == 3)
                    {
                        Application.Current.Shutdown();
                        break;
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Login Failed! {0} Times Remain!", 3 - i));
                        return;
                    }
                }
            }
        }

        public bool loginSuccess()
        {
            if (b == true)
            {
                this.Close();
            }
            return b;
        }
    }
}

