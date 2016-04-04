namespace StudentRegistration.MVP
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(120, 46);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(150, 21);
            this.txt_username.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(120, 82);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(150, 21);
            this.txt_password.TabIndex = 2;
            this.txt_password.PasswordChar = '*';
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(42, 46);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(72, 16);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.Location = new System.Drawing.Point(42, 82);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(72, 16);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(96, 119);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(99, 30);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_login;
    }
}