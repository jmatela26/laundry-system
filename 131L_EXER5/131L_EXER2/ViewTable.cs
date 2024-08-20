using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
using System.Globalization;
using System.Net;



namespace _131L_EXER2
{
    public partial class ViewTable : Form
    {
        string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
        public ViewTable()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add ss = new Add();
            ss.Show();
        }

        private void editDeleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDelete nn = new EditDelete();
            nn.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {


            string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
            SqlConnection connCustomer = new SqlConnection(connString);
            connCustomer.Open();

            // Highlight 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cellValue = row.Cells["CUS_JOBORDER"].Value;
                if (cellValue != null && cellValue.ToString() == VT_Cuscode.Text)
                {
                    dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                    dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
            }

            string sqlSelectStatement = @"Select * from CUSTOMER where CUS_JOBORDER='" + VT_Cuscode.Text + "'";


            SqlCommand cmdTxt = new SqlCommand(sqlSelectStatement, connCustomer);
            SqlDataReader dtrCustomer = cmdTxt.ExecuteReader();
            dtrCustomer.Read();
            //        dtrCustomer.Close();




            try
            {
                txtLName.Text = dtrCustomer["CUS_LNAME"].ToString();
                txtFName.Text = dtrCustomer["CUS_FNAME"].ToString();
                txtPhone.Text = dtrCustomer["CUS_PHONE"].ToString();
                txtDownPayment.Text = dtrCustomer["CUS_DOWNPAYMENT"].ToString();
                txtTotalBalance.Text = dtrCustomer["CUS_BALANCE"].ToString();
                txtBoxStatus.Text = dtrCustomer["CUS_STATUS"].ToString();
                //  txtTotalDownPayment.Text = dtrCustomer["CUS_DOWNPAYMENT"].ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Record Found", "Warning! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show(ex.Message);

            }
            connCustomer.Close();
            connCustomer.Dispose();

            if (VT_Cuscode.Text != "")
            {
                button3.Enabled = true;
            }

        }

        private void KeyCode(object sender, KeyEventArgs e)
        {

        }

        private void cODE(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }



        private void VT_Cuscode_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void ViewTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercise5DataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.exercise5DataSet.CUSTOMER);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Width));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
            SqlConnection connCustomer = new SqlConnection(connString);
            SqlCommand cmdDatabase = new SqlCommand(@"select * from CUSTOMER order by CUS_JOBORDER;", connCustomer);
            SqlCommand total = new SqlCommand("SELECT SUM(CUS_AMOUNT) FROM CUSTOMER", connCustomer);
            SqlCommand total1 = new SqlCommand("SELECT SUM(CUS_BALANCE) FROM CUSTOMER", connCustomer);
            SqlCommand total2 = new SqlCommand("SELECT SUM(CUS_DOWNPAYMENT) FROM CUSTOMER", connCustomer);


            decimal totalDisplay, totalDisplay1, totalDisplay2;
            connCustomer.Open();
            totalDisplay = (decimal)total.ExecuteScalar();
            connCustomer.Close();
            txtTotalAmount.Text = totalDisplay.ToString();

            connCustomer.Open();
            totalDisplay1 = (decimal)total1.ExecuteScalar();
            connCustomer.Close();
            txtTotalBalance.Text = totalDisplay1.ToString();

            connCustomer.Open();
            totalDisplay2 = (decimal)total2.ExecuteScalar();
            connCustomer.Close();
            txtTotalDownPayment.Text = totalDisplay2.ToString();


            try
            {
                SqlDataAdapter a = new SqlDataAdapter();
                a.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                a.Fill(dbdataset);
                BindingSource bdsource = new BindingSource();
                bdsource.DataSource = dbdataset;

                dataGridView1.DataSource = bdsource;
                a.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public object itexmo(string Number, string Message, string API_CODE)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("1", Number);
                parameter.Add("2", Message);
                parameter.Add("3", API_CODE);
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            return functionReturnValue;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            //string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
            //SqlConnection connCustomer = new SqlConnection(connString);
            //SqlCommand cmdDatabase = new SqlCommand(@"select * from CUSTOMER order by CUS_JOBORDER;", connCustomer);
            //SqlCommand SMS = new SqlCommand("SELECT CUS_PHONE FROM CUSTOMER", connCustomer);

            //decimal SMSDisplay;
            //connCustomer.Open();
            //SMSDisplay = (decimal)SMS.ExecuteScalar();
            //connCustomer.Close();
            //txtPhone.Text = SMSDisplay.ToString();

            string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
                SqlConnection connCustomer = new SqlConnection(connString);
                connCustomer.Open();

                string sqlSelectStatement = @"select CUS_PHONE from CUSTOMER where CUS_JOBORDER= '" + VT_Cuscode.Text + "'";
                SqlCommand cmdTxt = new SqlCommand(sqlSelectStatement, connCustomer);
                SqlDataReader dtrCustomer = cmdTxt.ExecuteReader();
                dtrCustomer.Read();

             foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                 txtPhone.Text = dtrCustomer["CUS_PHONE"].ToString();
            }

               
                connCustomer.Close();
                connCustomer.Dispose();


                dynamic result = itexmo(txtPhone.Text, "Good day! We wish to remind you that you can now claim your laundry at Lei-Mitch Laundry Shop. If you have any questions, feel free to contact us at 0906-441 7767", "KRIST953563_MXHBN");
                if (result == "0")
                {
                    MessageBox.Show("Message Sent");
                }
                else
                {
                    MessageBox.Show("Error num " + result + " was encountered");
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
 }

  

   
   