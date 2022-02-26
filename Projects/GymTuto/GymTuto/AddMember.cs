using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GymTuto
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kocep\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(memberNameTxtBox.Text == "" || phoneNumberTxtBox.Text == "" || mounthlyAmountTxtBox.Text == "" || ageTxtBox.Text == "")
            {
                MessageBox.Show("Please insert the missing information!");
            }
            else
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Members VALUES('"+memberNameTxtBox.Text+"','"+phoneNumberTxtBox.Text+"','"+genderComboBox.SelectedItem.ToString()+ "','" + ageTxtBox.Text + "', '" + mounthlyAmountTxtBox.Text+"', '"+timingComboBox.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Member Succesfully Added");
                    btnReset_Click(sender, e);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            memberNameTxtBox.Text = "";
            phoneNumberTxtBox.Text = "";
            genderComboBox.Text = "";
            ageTxtBox.Text = "";
            mounthlyAmountTxtBox.Text = "";
            timingComboBox.Text = "";
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }
    }
}
