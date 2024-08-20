using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _131L_EXER2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {


            Add ss = new Add();
            ss.Show();
            
        }

        private void buttonEditDeleteCustomer_Click(object sender, EventArgs e)
        {
            EditDelete nn = new EditDelete();
            nn.Show();
        }

        private void buttonViewCustomerTable_Click(object sender, EventArgs e)
        {
            ViewTable rr = new ViewTable();
            rr.Show();
            
            //this.Hide();
            //this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
