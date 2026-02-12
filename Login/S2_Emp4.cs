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

namespace Login
{
    public partial class S2_Emp4 : Form
    {
        public S2_Emp4()
        {
            InitializeComponent();
        }

        private void S2_Emp4_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select ID,Name,Phone,Email,Password from Registration   where UserType='Customer'";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
              

                dgvData.AutoGenerateColumns = false;
                dgvData.DataSource = dt;
                dgvData.Refresh();
                dgvData.ClearSelection();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtid.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtname.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtpassword.Text= dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtphone.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtemail.Text = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
              

            }
        }

        private void NewData()
        {
            dgvData.ClearSelection();
            txtid.Text = "Auto Genareted";
            txtname.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            txtpassword.Text = "";
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            this.NewData();
            this.LoadData();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;

           if(name=="")
            {
                MessageBox.Show("Enter Customer Name please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string password = txtpassword.Text;
            if (password == "")
            {
                MessageBox.Show("Enter Customer Password please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = txtphone.Text;
            if (phone == "")
            {
                MessageBox.Show("Enter Customer Phone number please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = txtemail.Text;

            if (email == "")
            {
                MessageBox.Show("Enter Customer Emaill please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queary = "";
            if (id == "Auto Genareted")
            {
                queary = $"Insert into Registration(Name,Password,Phone,email,UserType) values ('{name}','{password}','{phone}','{email}','Customer')";
            }
            else
            {
                queary = $"update Registration set Name='{name}',Password='{password}',Phone='{phone}',email='{email}' where Registration.ID='{id}'";
            }
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = queary;
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" Successful","UPDATE");
                this.LoadData();
                this.NewData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S1_Emp1 back = new S1_Emp1();
            back.Show();
            this.Hide();
        }

        private void BtMorder_Click(object sender, EventArgs e)
        {
            S2_Emp2 MangeOrder = new S2_Emp2();
            MangeOrder.Show();
            this.Hide();
        }

        private void BtMmenu_Click(object sender, EventArgs e)
        {
            S2_Emp3 Menu = new S2_Emp3();
            Menu.Show();
            this.Hide();
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
           
        }
    }
}
