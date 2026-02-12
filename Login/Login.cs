using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btspass_MouseHover(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void btspass_MouseLeave(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string email = txtmail.Text;

            if (email == "" || email.Contains('@') == false || email.Contains('.') == false)
            {
                MessageBox.Show("Empty Email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmail.Focus();
                return;
            }

            string password = txtpassword.Text;

            if(password=="")
            {
                MessageBox.Show("Empty Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return;
            }
            try 
            {
                var connection = new SqlConnection();
                connection.ConnectionString = ApplicationHelper.CS;
                connection.Open();

                var cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = $"select * from Registration where email='{email}' and Password='{password}'";
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                connection.Close();

                if(dt.Rows.Count!=1)
                {
                    MessageBox.Show("Invalid Email and Password !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                string name = dt.Rows[0]["Name"].ToString();
                string User = dt.Rows[0]["UserType"].ToString();
                MessageBox.Show("Hello" +" "+ name);

              if(User=="Admin")
               {
                  A1AdminDasboard ad = new A1AdminDasboard();
                    ad.Show();
                   this.Hide();
                }

                if(User=="Emp")
                {
                    S1_Emp1 em = new S1_Emp1();
                    em.Show();
                    this.Hide();
                        
                        }

              if(User=="Customer")
              {
                   A1Customer cu = new A1Customer();
                 cu.Show();
                    this.Hide();
            }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


      
        }

        private void btlogin_MouseHover(object sender, EventArgs e)
        {
            btlogin.BackColor = Color.IndianRed;
        }

        private void btlogin_MouseLeave(object sender, EventArgs e)
        {
            btlogin.BackColor = Color.DarkSeaGreen;
        }

     

        private void btexit_MouseHover(object sender, EventArgs e)
        {
            btexit.BackColor = Color.IndianRed;
        }

        private void btexit_MouseLeave(object sender, EventArgs e)
        {
            btexit.BackColor = Color.DarkSeaGreen;
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btsign_Click(object sender, EventArgs e)
        {
            Registration rf2 = new Registration();
            rf2.Show();
            this.Hide();
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
