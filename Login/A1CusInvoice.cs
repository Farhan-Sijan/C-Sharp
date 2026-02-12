using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Login
{
    public partial class A1CusInvoice : Form
    {
        public A1CusInvoice()
        {
            InitializeComponent();
        }

        private void dvgCUSID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCID.Text = dvgCUSID.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void loadCusID()
        {
            try
            {
                string email = txtEMAIL.Text;

                if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
                {
                    MessageBox.Show("Please enter valid a email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEMAIL.Focus();
                    return;
                }


                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select ID from Registration where email = '{email}' and UserType = 'Customer'";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd); //have to know which query to convert
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dvgCUSID.AutoGenerateColumns = false;
                dvgCUSID.DataSource = dt;
                dvgCUSID.Refresh();
                dvgCUSID.ClearSelection();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void A1CusInvoice_Load(object sender, EventArgs e)
        {
            //this.loadCusID();
            this.loadOrder();
            //this.loadINVOICE();
        }

        private void btCUSID_Click(object sender, EventArgs e)
        {
            this.loadCusID();
        }

        private void dvgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPRICE.Text = dvgOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
            textOITEMID.Text = dvgOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void loadOrder()
        {
            try
            {
               

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select OrderItemId, OrderId, Quantity, Price from OrderItem";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd); //have to know which query to convert
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dvgOrder.AutoGenerateColumns = false;
                dvgOrder.DataSource = dt;
                dvgOrder.Refresh();
                dvgOrder.ClearSelection();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvgINVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textOID.Text = dvgINVOICE.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void loadINVOICE()
        {
            try
            {
                string cid2 = textCID.Text;

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select OrderId, CusId, status, TotalAmount, OrderDate from Cusorder where CusId = {cid2}";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd); //have to know which query to convert
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dvgINVOICE.AutoGenerateColumns = false;
                dvgINVOICE.DataSource = dt;
                dvgINVOICE.Refresh();
                dvgINVOICE.ClearSelection();
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void INSERTbt_Click(object sender, EventArgs e)
        {
            try
            {
            string cid = textCID.Text;
            string price = textPRICE.Text;
            string oid = textOID.Text;

            string query = "";

            if (oid == "") //Auto Fill
                {
                query = $"insert into Cusorder (CusId, status, TotalAmount, OrderDate, EmpId) values ({cid}, 'Pending', {price}, GETDATE(), NULL)";
            }

                else
                {
                    MessageBox.Show("Order ID is auto generated. Select from Token table.");
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
                this.loadINVOICE();
                //this.newdata();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UPDATEbt_Click(object sender, EventArgs e)
        {
            try
            {
                string cid1 = textCID.Text;
                string oid1 = textOID.Text;
                string item1 = textOITEMID.Text;

                string query1 = "";

                if (oid1 == "" || item1 == "") //Auto Fill
                {
                    MessageBox.Show("Please select ID's first");
                }
                else
                {
                    query1 = $"update OrderItem set OrderId = {oid1} where OrderItemId = {item1} and OrderId = 1";
                }

                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand(); //query
                cmd.Connection = con;
                cmd.CommandText = query1;
                cmd.ExecuteNonQuery();
                con.Close();

                //MessageBox.Show("Done");
                this.loadINVOICE();
                this.loadOrder();
                //this.newdata();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showOrder_Click(object sender, EventArgs e)
        {
            this.loadINVOICE();
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            this.newdata();
            this.loadOrder();
        }

        private void newdata()
        {
            dvgCUSID.ClearSelection();
            dvgINVOICE.ClearSelection();
            dvgOrder.ClearSelection();
            textOID.Text = ""; //Auto Fill
            textOITEMID.Text = ""; //Auto Fill
            textCID.Text = "";
            textPRICE.Text = "";
            txtEMAIL.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            M2Rating re2 = new M2Rating();
            re2.Show();
            this.Hide();
        }

        private void HOMEbutton1_Click(object sender, EventArgs e)
        {
            A1Customer cu2 = new A1Customer();
            cu2.Show();
            this.Hide();
        }

        private void CARTbutton1_Click(object sender, EventArgs e)
        {
            A1CusMenu mn2 = new A1CusMenu();
            mn2.Show();
            this.Hide();
        }

        private void ORDERbutton1_Click(object sender, EventArgs e)
        {
            //A1CusInvoice inn2 = new A1CusInvoice();
            //inn2.Show();
            //this.Hide();
        }

        private void txtEMAIL_TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERTbt_MouseHover(object sender, EventArgs e)
        {
            INSERTbt.BackColor = Color.IndianRed;
        }

        private void INSERTbt_MouseLeave(object sender, EventArgs e)
        {
            INSERTbt.BackColor = Color.DarkSeaGreen;
        }

        private void UPDATEbt_MouseHover(object sender, EventArgs e)
        {
            UPDATEbt.BackColor = Color.IndianRed;
        }

        private void UPDATEbt_MouseLeave(object sender, EventArgs e)
        {
            UPDATEbt.BackColor = Color.DarkSeaGreen;
        }
    }
}

