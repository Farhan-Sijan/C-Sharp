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
    public partial class A1AdminDasboard : Form
    {
        public A1AdminDasboard()
        {
            InitializeComponent();
        }

        private void EMPbutton2_Click(object sender, EventArgs e)
        {
            A1Admin emp = new A1Admin();
            emp.Show();
            this.Hide();
        }

        private void CAtEGORYbutton3_Click(object sender, EventArgs e)
        {
            M1CategoryManagement cat1 = new M1CategoryManagement();
            cat1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LOGOUTbutton6_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
