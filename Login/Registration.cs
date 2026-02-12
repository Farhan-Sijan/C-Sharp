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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

      

        private void btpass1_MouseHover(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
        }

        private void btpass1_MouseLeave(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void btpass2_MouseHover(object sender, EventArgs e)
        {
            txtconpass.UseSystemPasswordChar = false;
        }

        private void btpass2_MouseLeave(object sender, EventArgs e)
        {
            txtconpass.UseSystemPasswordChar = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login lf = new Login();
            lf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = txtName.Text;
            string Password = txtpass.Text;
            string ConPassword = txtconpass.Text;
            string Phone = txtphone.Text;
            string Email = txtmail.Text;

            if(Username == "")
            {
                MessageBox.Show("Empty Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if(Password=="")
            {
                MessageBox.Show("Empty Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Focus();
                return;
            }
            if (ConPassword == "")
            {
                MessageBox.Show("Empty Comfirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconpass.Focus();
                return;

            }
            if (Password != ConPassword)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtconpass.Focus();
                return;
            }

            if(Phone=="")
            {
                MessageBox.Show("Empty Phone Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphone.Focus();
                return;
            }

            if (Email == "" || Email.Contains('@') == false || Email.Contains('.') == false)
            {
                MessageBox.Show("Empty Email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmail.Focus();
                return;
            }

            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText= $"insert into Registration values('{Username}','{Password}','{Phone}','{Email}','Customer','0') ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registration Complete","Save");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
