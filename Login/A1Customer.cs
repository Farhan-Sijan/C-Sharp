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
    public partial class A1Customer : Form
    {
        public A1Customer()
        {
            InitializeComponent();
        }

        private void BACKbutton5_Click(object sender, EventArgs e)
        {

        }

        private void MENUbutton2_Click(object sender, EventArgs e)
        {
            /*A1CusMenu mn = new A1CusMenu();
            mn.Show();
            this.Hide();*/
        }

        private void CARTbutton_Click(object sender, EventArgs e)
        {
            A1CusMenu mn = new A1CusMenu();
            mn.Show();
            this.Hide();
        }

        private void ORDERbutton_Click(object sender, EventArgs e)
        {
            A1CusInvoice inn = new A1CusInvoice();
            inn.Show();
            this.Hide();
        }

        private void REVIEWbutton_Click(object sender, EventArgs e)
        {
            M2Rating re = new M2Rating();
            re.Show();
            this.Hide();
        }

        private void LOGOUTbutton_Click(object sender, EventArgs e)
        {
            Login l2 = new Login();
            l2.Show();
            this.Hide();
        }
    }
}
