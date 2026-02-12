using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class S1_Emp1 : Form
    {
        public S1_Emp1()
        {
            InitializeComponent();
        }

        private void Btlogout_Click(object sender, EventArgs e)
        {
            Login lf = new Login();
            lf.Show();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtMOitem_Click(object sender, EventArgs e)
        {
            S2_Emp4 Customer = new S2_Emp4();

            Customer.Show();
            this.Hide();
        }

        private void BtMorder_MouseHover(object sender, EventArgs e)
        {
            BtMorder.BackColor = Color.IndianRed;
        }
        

        private void BtMorder_MouseLeave(object sender, EventArgs e)
        {
            BtMorder.BackColor = Color.DarkSeaGreen;
        }

        private void BtMmenu_MouseLeave(object sender, EventArgs e)
        {
            BtMmenu.BackColor = Color.DarkSeaGreen;
        }

        private void BtMmenu_MouseHover(object sender, EventArgs e)
        {
            BtMmenu.BackColor = Color.IndianRed;
        }

        private void BtMcustomer_MouseLeave(object sender, EventArgs e)
        {
            BtMcustomer.BackColor = Color.DarkSeaGreen;
        }

        private void BtMcustomer_MouseHover(object sender, EventArgs e)
        {
            BtMcustomer.BackColor = Color.IndianRed;
        }

        private void Btlogout_MouseLeave(object sender, EventArgs e)
        {
            Btlogout.BackColor = Color.DarkSeaGreen;
        }

        private void Btlogout_MouseHover(object sender, EventArgs e)
        {
            Btlogout.BackColor = Color.IndianRed;
        }
    }
}
