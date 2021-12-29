using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domi.music275
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpassword forgotpassword = new Forgotpassword();
            forgotpassword.ShowDialog();
        }

        private void linkLabel_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();  
            signup.ShowDialog();
        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Please re-enter your username ! "); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Please re-enter your password ! "); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+"' and MatKhau =  '" +matkhau+"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Log In successfully !","Notification", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Tunesource tuneSource = new Tunesource();
                    tuneSource.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect !", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
