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
    public partial class M1CategoryManagement : Form
    {
        public M1CategoryManagement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void M1CategoryManagement_Load(object sender, EventArgs e)
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
                cmd.CommandText = "select * from Category";

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
                MessageBox.Show("Something Wrong");
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
            this.NewData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                rtxtdesc.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            dgvData.ClearSelection();
            txtId.Text = "Auto Generated";
            txtName.Text = "";
            rtxtdesc.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            if (id == "Auto Generated")
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"delete from OrderItem where MenuID in (select MenuID from Menu where CatagoryId={id}); delete from Menu where CatagoryId={id}; delete from Category where CategoryId={id}";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Operation Successful");
                this.LoadData();
                this.NewData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string desc = rtxtdesc.Text;

            string query = "";

            if (id == "Auto Generated")
            {

                query = $"insert into Category Values('{name}','{desc}')";
            }
            else
            {
                query = $"update Category set CategoryName='{name}',Description='{desc}' where CategoryId ={id}";
            }
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Operation Successful");
                this.LoadData();
                this.NewData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            A1AdminDasboard ad12 = new A1AdminDasboard();
            ad12.Show();
            this.Hide();
        }
    }
}
