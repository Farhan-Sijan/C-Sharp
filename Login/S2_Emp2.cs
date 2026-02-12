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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Login
{
    public partial class S2_Emp2 : Form
    {
        public S2_Emp2()
        {
            InitializeComponent();
        }

        private void S2_Emp2_FormClosing(object sender, FormClosingEventArgs e)
        {
            S1_Emp1 s1 = new S1_Emp1();
            s1.Show();
        }

       

        private void S2_Emp2_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void loadData()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select Cusorder.*,Registration.Name  from Cusorder inner join Registration on Registration.ID=Cusorder.CusId";

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
            
            if (e.RowIndex>=0)
            {
                txtid.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbStatus.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAmount.Text= dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text= dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void newData()
        {
            dgvData.ClearSelection();
            txtid.Text = "Auto Genarated";
            txtAmount.Text = "";
            cmbStatus.Text = "";
            txtName.Text = "";
            
        }

       

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            this.loadData();
            this.newData();
        }

       private void BtSave_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string amount = txtAmount.Text;

            if(amount=="")
            {
                MessageBox.Show("Please Eenter your Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtName.Text;

            string cmbstatus = cmbStatus.Text;
            DateTime dateCus = dateTimePicker1.Value;

            
                  
            
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"update Cusorder set status='{cmbstatus}',TotalAmount='{amount}',OrderDate='{dateCus}' where OrderId={id}";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successful","Update");
                this.loadData();
                this.newData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            if (id == "Auto Genareted")
            {
                MessageBox.Show("Please select a raw");
                return;
            }
            var result = MessageBox.Show("Do you want to delete it ? ", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();
                var cmdItem1 = new SqlCommand();
                cmdItem1.Connection = con;
                cmdItem1.CommandText = $"delete from Rating where OrderID={id}";
                cmdItem1.ExecuteNonQuery();


                var cmdItem = new SqlCommand();
                cmdItem.Connection = con;
                cmdItem.CommandText = $"delete from Orderitem where OrderId={id}";
                cmdItem.ExecuteNonQuery();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"delete from Cusorder where OrderId={id}";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Deleted Successful", "delete");
                this.loadData();
                this.newData();
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

        private void BtRefresh_MouseLeave(object sender, EventArgs e)
        {
            BtRefresh.BackColor = Color.DarkSeaGreen;
        }

        private void BtRefresh_MouseHover(object sender, EventArgs e)
        {
            BtRefresh.BackColor = Color.IndianRed;
        }

        private void btDelete_MouseLeave(object sender, EventArgs e)
        {
            btDelete.BackColor = Color.DarkSeaGreen;
        }

        private void btDelete_MouseHover(object sender, EventArgs e)
        {
            btDelete.BackColor = Color.IndianRed;
        }

        private void BtSave_MouseLeave(object sender, EventArgs e)
        {
            BtSave.BackColor = Color.DarkSeaGreen;
        }

        private void BtSave_MouseHover(object sender, EventArgs e)
        {
            BtSave.BackColor = Color.IndianRed;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Btback.BackColor = Color.IndianRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Btback.BackColor = Color.DarkSeaGreen;
        }

        private void BtMmenu_Click(object sender, EventArgs e)
        {
            S2_Emp3 Menu = new S2_Emp3();
            Menu.Show();
            this.Hide();
        }

        private void BtMcustomer_Click(object sender, EventArgs e)
        {
            S2_Emp4 Customer = new S2_Emp4();

            Customer.Show();
            this.Hide();
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
            
        }
    }
}
