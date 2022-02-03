using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txtBox_usr.Text.Equals("FluffeR") && txtBox_pass.Text.Equals("koce2004"))
            {
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("Wrong input!");
                btn_Restart_Click(sender, e);
            }
        }
        private void btn_Restart_Click(object sender, EventArgs e)
        {
            txtBox_usr.Clear();
            txtBox_pass.Clear();
        }

        private void btn_passUnhide_Click(object sender, EventArgs e)
        {
            if(txtBox_pass.UseSystemPasswordChar == false)
            {
                txtBox_pass.UseSystemPasswordChar = true;
            }
            else
            {
                txtBox_pass.UseSystemPasswordChar = false;
            }
        }
    }
}
