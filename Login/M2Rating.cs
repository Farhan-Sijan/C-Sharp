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
    public partial class M2Rating : Form
    {
        public M2Rating()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCusid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCusid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCid.Text = dgvCusid.Rows[e.RowIndex].Cells[0].Value + "";
            }

        }

        private void btMail_Click(object sender, EventArgs e)
        {
            this.loadCusid();
        }
        private void loadCusid()
        {
            try
            {
                string email = txtMail.Text;

                if (email == "")
                {
                    MessageBox.Show("Please enter email first.");
                    return;
                }

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;

           
                cmd.CommandText = $"select ID from Registration where email = '{email}' and UserType = 'Customer'";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

               

                DataTable dt = ds.Tables[0];
                dgvCusid.AutoGenerateColumns = true;
                dgvCusid.DataSource = dt;
                dgvCusid.Refresh();
                dgvCusid.ClearSelection();

                
                DataTable dt1 = ds.Tables[0];
                dgvCusid.AutoGenerateColumns = true;
                dgvCusid.DataSource = dt1;
                dgvCusid.Refresh();
                dgvCusid.ClearSelection();

                if (dt1.Rows.Count == 1)
                {
                    txtCid.Text = dt1.Rows[0]["ID"].ToString();
                }
                else
                {
                    txtCid.Text = "Auto Fill"; 
                }

                con.Close();
            }
            catch (Exception ex)
               {
                MessageBox.Show(ex.Message);
               }
        }

        private void dgvRating_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRating_Click(object sender, EventArgs e)
        {
            this.loadRatings();
        }
        private void loadRatings()
        {
            try
            {
                string cid = txtCid.Text;
                if (cid == "Auto Fill")
                {
                    MessageBox.Show("Please load Customer ID first.");
                    return;
                }

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;

                
                cmd.CommandText = $"select r.RatingID, r.CustomerID, r.OrderID, r.RatingStars, r.Comment from Rating r inner join Cusorder o on o.OrderId = r.OrderID where r.CustomerID = {cid};select  o.OrderId as 'OrderID' from Cusorder o inner join Registration c on c.ID = o.CusId where o.CusId = {cid}";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvRating.AutoGenerateColumns = false;   
                dgvRating.DataSource = dt;
                dgvRating.Refresh();
                dgvRating.ClearSelection();

                DataTable dtOrders = ds.Tables[1];
                cmbOid.DataSource = null;
                cmbOid.Items.Clear();
                
                cmbOid.ValueMember = "OrderID";
                cmbOid.DisplayMember = "OrderID";
                cmbOid.DataSource = dtOrders;
                cmbOid.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRating_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRating_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                txtRid.Text = dgvRating.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCid.Text = dgvRating.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbOid.SelectedValue = dgvRating.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtRstar.Text = dgvRating.Rows[e.RowIndex].Cells[3].Value.ToString();
                rtxtComment.Text = dgvRating.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            txtRid.Text = "Auto Generated";

            cmbOid.SelectedIndex = -1;

            
            txtRstar.Clear();
            rtxtComment.Clear();
            dgvRating.ClearSelection();
            cmbOid.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.loadRatings();
            this.NewData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = txtRid.Text;

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
                cmd.CommandText = $"delete from Rating where RatingID = {id}";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Operation Successful");
                this.loadRatings();
                this.NewData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wrong");

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string id = txtRid.Text;
            string cid = txtCid.Text;
            if (cmbOid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Order ID first.");
                return;
            }
            string oid = cmbOid.SelectedValue.ToString();
            string stars = txtRstar.Text;
            string comment = rtxtComment.Text;

            int st;

            try
            {
                st = Convert.ToInt32(stars);
            }
            catch
            {
                MessageBox.Show("Please enter numbers only for Rating Stars.");
                return;
            }

            if (st < 1 || st > 5)
            {
                MessageBox.Show("Rating Stars must be between 1 and 5.");
                return;
            }


            string query = "";

            if (id == "Auto Generated")
            {
                query = $"insert into Rating values({cid},{oid},{stars},'{comment}')";
            }
            else
            {
                query = $"update Rating set CustomerID={cid},OrderID={oid},RatingStars={stars},Comment='{comment}' where RatingID={id}";
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
                this.loadRatings();
                this.NewData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            A1Customer dash1 = new A1Customer();
            dash1.Show();
            this.Hide();
        }
    }
   
}
