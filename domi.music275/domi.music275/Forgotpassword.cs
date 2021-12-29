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
    public partial class Forgotpassword : Form
    {
        public Forgotpassword()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == "") { MessageBox.Show("Find your email !"); }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count!=0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Password: " + modify.TaiKhoans(query)[0].PassWord;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "This email is not a VIP account";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
