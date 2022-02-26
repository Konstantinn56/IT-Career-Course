using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTuto
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kocep\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            connection.Open();

            string query = "SELECT * FROM Members";
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            var ds = new DataSet();
            adapter.Fill(ds);
            MembersSDGV.DataSource = ds.Tables[0];

            connection.Close();
        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }
        public static void showInfo()
        {
            Information info = new Information();
            info.Show();
        }
        private void lblInfo1_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void lblInfo2_Click(object sender, EventArgs e)
        {
            showInfo();
        }
    }
}
