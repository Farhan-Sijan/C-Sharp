using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Login
{
    public partial class A1Admin : Form
    {
        public A1Admin()
        {
            InitializeComponent();
        }


        private void loaddata()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.CS;
                con.Open();

                var cmd = new SqlCommand(); 
                cmd.Connection = con;
                cmd.CommandText = "select ID, Name,Phone,Email,UserType,Salary from Registration where UserType = 'Emp'";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);


                DataTable dt = ds.Tables[0];

                dvgEMP.AutoGenerateColumns = false;
                dvgEMP.DataSource = dt;
                dvgEMP.Refresh();
                dvgEMP.ClearSelection();
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void HOMEbutton1_Click(object sender, EventArgs e)
        {
            A1AdminDasboard ad1 = new A1AdminDasboard();
            ad1.Show();
            this.Hide();
        }

        private void A1Admin_Load(object sender, EventArgs e)
        {
            this.loaddata();
        }

        private void Refreshbt_Click(object sender, EventArgs e)
        {
            this.loaddata();
            this.newdata();

        }

        private void newdata()
        {

         

                dvgEMP.ClearSelection();

                textEMP.Text = "Auto Generated";
                textName.Text = "";
                textContact.Text = "";
                textEmail.Text = "";
                textRole.Text = "";
                textSalary.Text = "";

        }

        private void dvgEMP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    textEMP.Text = dvgEMP.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textName.Text = dvgEMP.Rows[e.RowIndex].Cells[1].Value.ToString();
                    textContact.Text = dvgEMP.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textEmail.Text = dvgEMP.Rows[e.RowIndex].Cells[3].Value.ToString();
                    textRole.Text = dvgEMP.Rows[e.RowIndex].Cells[4].Value.ToString();
                    textSalary.Text = dvgEMP.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            string id = textEMP.Text;
            if (id == "Auto Generated")
            {
                MessageBox.Show("Please select first a row first");
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
                cmd.CommandText = $"update Cusorder SET EmpId = NULL where EmpId = {id}";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $"delete from Registration where ID = {id} and UserType = 'Emp'";
                cmd.ExecuteNonQuery();

                con.Close();

                //MessageBox.Show("Done");
                this.loaddata();
                this.newdata();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Savebt_Click(object sender, EventArgs e)
        {
            string id = textEMP.Text;
            string name = textName.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter employee name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textName.Focus();
                return;
            }

            string contact = textContact.Text;
            if (contact.Length != 11)
            {
                MessageBox.Show("Please enter valid contact number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textContact.Focus();
                return;
            }


            string email = textEmail.Text;
            if (email == "" || email.Contains("@") == false || email.Contains(".") == false)
            {
                MessageBox.Show("Please enter valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Focus();
                return;
            }

            string role = textRole.Text;
            if (role != "Emp")
            {
                MessageBox.Show("The Role must be 'Emp' for this section.");
                textRole.Focus();
                return;
            }


            string salary = textSalary.Text;
            if (salary == "")
            {
                MessageBox.Show("Prease enter salary!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSalary.Focus();
                return;
            }


            string query = "";

            if(id == "Auto Generated")
            {
                query = $"insert into Registration(Name, Phone, email, UserType, Password, Salary) values('{name}', '{contact}', '{email}', '{role}','000', '{salary}')";
            }
            else
            {
                query = $"update Registration set Name = '{name}', Phone = '{contact}', email = '{email}', UserType = '{role}', Salary = '{salary}' where ID = {id}";
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

                MessageBox.Show("Employee Information Saved Successfully");

                this.loaddata(); 
                this.newdata();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Newbt_Click(object sender, EventArgs e)
        {
            this.newdata();
        }

        private void CAtEGORYbutton3_Click(object sender, EventArgs e)
        {
            M1CategoryManagement cat = new M1CategoryManagement();
            cat.Show();
            this.Hide();
        }

        private void LOGOUTbutton6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BACKbutton5_Click(object sender, EventArgs e)
        {
           
        }

        private void Savebt_MouseHover(object sender, EventArgs e)
        {
            Savebt.BackColor = Color.IndianRed;
        }

        private void Savebt_MouseLeave(object sender, EventArgs e)
        {
            Savebt.BackColor = Color.DarkSeaGreen;
        }
    }
    }

    

