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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Login
{
    public partial class S2_Emp3 : Form
    {
        public S2_Emp3()
        {
            InitializeComponent();
        }

        private void S2_Emp3_Load(object sender, EventArgs e)
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
                cmd.CommandText = "select  Menu.MenuID, Menu.FoodName,Menu.Price, Category.CategoryName,Menu.AvailableQuantity from Menu inner join Category  on Menu.CatagoryId = Category.CategoryId;select * from Category";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                DataTable dt1 = ds.Tables[1];

             


                dgvData.AutoGenerateColumns = false;
                dgvData.DataSource = dt;
                dgvData.Refresh();
                dgvData.ClearSelection();

                DataTable ds1 = ds.Tables[1];
                cmbCatagory.DataSource = dt1;
                cmbCatagory.ValueMember = "CategoryId";
                cmbCatagory.DisplayMember = "CategoryName";
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtMenuid.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFood.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtprice.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCatagory.Text = dgvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuantity.Text = dgvData.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
          
        }

        private void NewData()
        {
            dgvData.ClearSelection();
            txtMenuid.Text = "AG";
            txtFood.Text = "";
            txtprice.Text = "";
            txtQuantity.Text = "";
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            this.NewData();
            this.loadData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = txtMenuid.Text;
            if (id == "AG")
            {
                MessageBox.Show("Selet raw");
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
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"delete from OrderItem where MenuId={id}";
                cmd.ExecuteNonQuery();


                var cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = $"delete from Menu where MenuID={id}";
                cmd1.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Deleted Successful", "Delete");
                this.loadData();
                this.NewData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            string id = txtMenuid.Text;
            string catagory = cmbCatagory.SelectedValue.ToString();
            string food = txtFood.Text;
            if(food=="")
            {
                MessageBox.Show("Please Enter your Food name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string amount = txtprice.Text;

            if (amount == "")
            {
                MessageBox.Show("Please Eenter your Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string quantity = txtQuantity.Text;

            if(quantity=="")
            {
                {
                    MessageBox.Show("Please Eenter your Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            string queary = "";
            if (id == "AG")
            {
                queary = $"insert into Menu(CatagoryId,FoodName,Price,AvailableQuantity) values ('{catagory}','{food}','{amount}','{quantity}')";
            }
            else
            {
                queary = $"update Menu set FoodName = '{food}', Price = '{amount}', AvailableQuantity = '{quantity}',CatagoryId='{catagory}' where MenuID = {id}";
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
                MessageBox.Show("Updated Successful");
                this.loadData();
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

        private void btNew_MouseLeave(object sender, EventArgs e)
        {
            btNew.BackColor = Color.DarkSeaGreen;
        }

        private void btNew_MouseHover(object sender, EventArgs e)
        {
            btNew.BackColor = Color.IndianRed;
        }


        private void btDelete_MouseHover_1(object sender, EventArgs e)
        {
            btDelete.BackColor = Color.IndianRed;
        }

        private void btDelete_MouseLeave_1(object sender, EventArgs e)
        {
            btDelete.BackColor = Color.DarkSeaGreen;
        }

        private void BtRefresh_MouseLeave_1(object sender, EventArgs e)
        {
            BtRefresh.BackColor = Color.DarkSeaGreen;
        }

        private void BtRefresh_MouseHover_1(object sender, EventArgs e)
        {
            BtRefresh.BackColor = Color.IndianRed;
        }

        private void BtSave_MouseHover_1(object sender, EventArgs e)
        {
            BtSave.BackColor = Color.IndianRed;
        }

        private void BtSave_MouseLeave_1(object sender, EventArgs e)
        {
            BtSave.BackColor = Color.DarkSeaGreen;
        }

        private void BtBack_MouseHover(object sender, EventArgs e)
        {
            BtBack.BackColor = Color.IndianRed;
        }

        private void BtBack_MouseLeave(object sender, EventArgs e)
        {
            BtBack.BackColor = Color.DarkSeaGreen;
        }

        private void BtMorder_Click(object sender, EventArgs e)
        {
            S2_Emp2 MangeOrder = new S2_Emp2();
            MangeOrder.Show();
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
