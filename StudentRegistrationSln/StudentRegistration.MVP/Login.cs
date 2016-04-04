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

    public partial class Login : Form,IView
    {
        int i = 0;
        bool b = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if ((txt_username.Text == "gao") && (txt_password.Text == "922815"))
                {
                    b = true;
                    this.loginSuccess();
                    break;
                }
                else
                {
                    txt_username.Text = "";
                    txt_password.Text = "";
                    b = false;
                    i++;
                    if (i == 3)
                    {
                        this.Close();
                        break;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(String.Format("Login Failed! {0} Times Remain!", 3 - i));
                        return;
                    }
                }
            }
            
        }
        public bool loginSuccess()
        {
            if(b == true)
            {
                this.Close();
            }
            return b;
        }
    }
}
