using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Login
{
    public partial class A1CusMenu : Form
    {
        public A1CusMenu()
        {
            InitializeComponent();
        }

        private void A1CusMenu_Load(object sender, EventArgs e)
        {
            this.loadCategories();
            this.loadOrderItem();
        }

        private void loadCategories()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select c.CategoryName, m.FoodName, m.Price, m.MenuID from Menu m join Category c on m.CatagoryId = c.CategoryId";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd); //have to know which query to convert
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dvgMenu.AutoGenerateColumns = false;
                dvgMenu.DataSource = dt;
                dvgMenu.Refresh();
                dvgMenu.ClearSelection();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadOrderItem()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select OrderItem.MenuId, OrderItem.OrderItemId, OrderItem.Quantity, OrderItem.Price ,Menu.FoodName from OrderItem inner join Menu on Menu.MenuId = OrderItem.MenuId;select * from Menu";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd); //have to know which query to convert
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dvgOrderItem.AutoGenerateColumns = true;
                dvgOrderItem.DataSource = dt;
                dvgOrderItem.Refresh();
                dvgOrderItem.ClearSelection();


                DataTable dt1 = ds.Tables[1];
                cmbMENU.DataSource = dt1;
                cmbMENU.ValueMember = "MenuID";
                cmbMENU.DisplayMember = "MenuID";
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgMenu_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    textName.Text = dvgMenu.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textPrice.Text = dvgMenu.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }

            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            
            }
        }

        private void ATC_Click(object sender, EventArgs e)
        {

            try
            {
                string OID = textOID.Text; 
                string pricedel = textPriceDEL.Text; 
                string namedel = textNameForDEL.Text; 
                string name = textName.Text; 
                string price = textPrice.Text;
                string qty = textQuantity.Text;
                string selqty = textQTY.Text;

                /*if (selqty == "")
                {
                    MessageBox.Show("Please select a quantity first");
                    return;
                }*/



                if (cmbMENU.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Food ID");
                    return; 
                }
                string menuid = cmbMENU.SelectedValue.ToString(); 
              
                string query = "";

            if (OID == "Auto Generated")
            {
                query = $"Insert into OrderItem (OrderId, MenuId, Quantity, Price) values (1, {menuid}, {selqty}, {price})";
            }
            else
            {
                query = $"update OrderItem set Quantity = {qty} where OrderItemId = {OID}";
            }

           
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand(); //query
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();

                //MessageBox.Show("Done");
                this.loadCategories();
                this.loadOrderItem();
                this.newdata();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void qtyTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgOrderItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    textOID.Text = dvgOrderItem.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
                    cmbMENU.SelectedValue = dvgOrderItem.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
                    textNameForDEL.Text = dvgOrderItem.Rows[e.RowIndex].Cells["Column10"].Value.ToString();
                    textPriceDEL.Text = dvgOrderItem.Rows[e.RowIndex].Cells["Column9"].Value.ToString();
                    textQuantity.Text = dvgOrderItem.Rows[e.RowIndex].Cells["Column8"].Value.ToString();

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void NEWbutton_Click(object sender, EventArgs e)
        {
            this.newdata();
        }

        private void newdata()
        {
            try
            {
                //dvgMenu.ClearSelection();
                dvgOrderItem.ClearSelection();
                textOID.Text = "Auto Generated";
                textName.Text = "";
                textPrice.Text = "";
                textQuantity.Text = "";
                textPriceDEL.Text = "";
                textNameForDEL.Text = "";
                textQTY.Text = "";
                cmbMENU.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void REFRESHbutton_Click(object sender, EventArgs e)
        {
            this.loadCategories();
            this.loadOrderItem();
            this.newdata();
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
             
            string id = textOID.Text;
            if (id == "Auto Generated")
            {
                MessageBox.Show("Please select first");
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
                cmd.CommandText = $"delete from OrderItem where OrderItemId = {id}";
                cmd.ExecuteNonQuery();
                con.Close();

                //MessageBox.Show("Done");
                this.loadOrderItem();
                this.newdata();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HOMEbutton2_Click(object sender, EventArgs e)
        {
            A1Customer cu1 = new A1Customer();
            cu1.Show();
            this.Hide();
        }

        private void CARTbutton2_Click(object sender, EventArgs e)
        {
            //A1CusMenu mn1 = new A1CusMenu();
            //mn1.Show();
            //this.Hide();
        }

        private void ORDERbutton2_Click(object sender, EventArgs e)
        {
            A1CusInvoice inn1 = new A1CusInvoice();
            inn1.Show();
            this.Hide();
        }

        private void REVIEWbutton2_Click(object sender, EventArgs e)
        {
            M2Rating re1 = new M2Rating();
            re1.Show();
            this.Hide();
        }

        private void BACKbutton2_Click(object sender, EventArgs e)
        {

        }

        private void ATC_MouseHover(object sender, EventArgs e)
        {
            ATC.BackColor = Color.IndianRed;
        }

        private void ATC_MouseLeave(object sender, EventArgs e)
        {
               ATC.BackColor = Color.DarkSeaGreen;
        }
    }
}

