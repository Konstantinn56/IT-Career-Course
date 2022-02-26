using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTuto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            this.Hide();
            am.Show();
        }

        private void picBxInfo_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            MessageBox.Show("Succesfully logouted!");
        }
    }
}
