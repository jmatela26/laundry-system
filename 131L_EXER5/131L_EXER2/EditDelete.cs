using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _131L_EXER2
{
    public partial class EditDelete : Form
    {
        public EditDelete()
        {
            InitializeComponent();
        }

   

        private void ED_AddCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add ss = new Add();
            ss.Show();
        }

        private void ED_ViewCustTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTable rr = new ViewTable();
            rr.Show();
        }

        private void ed_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEd_Save_Click(object sender, EventArgs e)
        {
            
            double cusBal, cusDownPayment, cusAmount;
            string cusfName,  cusPhone, 

           
            cuslName = txtBoxED_Lname.Text;
            cusfName = txtBoxED_Fname.Text;
            cusPhone = txtBoxED_PhoneNum.Text;
            cusBal = double.Parse(txtBoxBalance.Text);
            cusDownPayment = double.Parse(txtBoxDownPayment.Text);
            cusAmount = double.Parse(txtTotalAmount.Text);


            //CONNECT
            string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
            SqlConnection connCustomer = new SqlConnection(connString);
            


            string sqlUPDATEstring = @" UPDATE CUSTOMER SET CUS_LNAME =  '" + cuslName + "', CUS_FNAME = '"
                                      + cusfName + "', CUS_BALANCE = '" + cusBal + "', CUS_DOWNPAYMENT = '" + cusDownPayment + "',CUS_AMOUNT = " + cusAmount + " WHERE CUS_JOBORDER = " + txtJobOrder.Text;


            SqlCommand UPDATEcmd = new SqlCommand(sqlUPDATEstring, connCustomer);
            connCustomer.Open();
            UPDATEcmd.ExecuteNonQuery();  


            connCustomer.Close();
            //connCustomer.Dispose();
            MessageBox.Show("Done");
            

            this.Close();
        }

        private void btnED_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgResult == DialogResult.Yes)
            {

                string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
                SqlConnection connCustomer = new SqlConnection(connString);
                connCustomer.Open();


                string sqlDELETEstring = @"DELETE FROM CUSTOMER WHERE (CUS_JOBORDER = '" + txtJobOrder.Text + "')";//

                SqlCommand cmdDELETE = new SqlCommand(sqlDELETEstring);

                cmdDELETE.Connection = connCustomer;
                
                cmdDELETE.ExecuteNonQuery();
                
                connCustomer.Close();
                connCustomer.Dispose();
                MessageBox.Show("Done");
                this.Close();
            }

        }

        private void KeyCode(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
                SqlConnection connCustomer = new SqlConnection(connString);
                connCustomer.Open();

                string sqlSelectStatement = @"select * from CUSTOMER where CUS_JOBORDER= '" + txtJobOrder.Text + "'";
                SqlCommand cmdTxt = new SqlCommand(sqlSelectStatement, connCustomer);
                SqlDataReader dtrCustomer = cmdTxt.ExecuteReader();
                dtrCustomer.Read();

                try
                {
                    if ((dtrCustomer["CUS_LNAME"].ToString().Trim().Length != 0))
                    {
                        //ENABLE OTHER CONTROLS
                        txtBoxED_Lname.Enabled = true;
                        txtBoxED_Fname.Enabled = true;
                        
                        txtBoxED_PhoneNum.Enabled = true;
                        txtBoxBalance.Enabled = true;
                        txtBoxDownPayment.Enabled = true;
                    }


                    //FILL UP THOSE OBJECT BY GETTING THE DATA FROM TABLE Student
                    txtBoxED_Lname.Text = dtrCustomer["CUS_LNAME"].ToString();
                    txtBoxED_Fname.Text = dtrCustomer["CUS_FNAME"].ToString();
                    txtBoxED_PhoneNum.Text = dtrCustomer["CUS_PHONE"].ToString();
                   txtBoxBalance.Text = dtrCustomer["CUS_BALANCE"].ToString();
                   txtBoxDownPayment.Text = dtrCustomer["CUS_DOWNPAYMENT"].ToString();
                   // txtBoxEd_Date.Text = dtrCustomer["CUS_DATE"].ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No Record Found", "Warning! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //MessageBox.Show(ex.Message);

                }
                connCustomer.Close();
                connCustomer.Dispose();
            }
        }

        private void textCusCode(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void LName(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void FName(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void MI(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void Area(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void Phone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void Bal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }   

        private void EditDelete_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxED_Bal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
                SqlConnection connCustomer = new SqlConnection(connString);
                connCustomer.Open();

                string sqlSelectStatement = @"select * from CUSTOMER where CUS_JOBORDER= '" + txtJobOrder.Text + "'";
                SqlCommand cmdTxt = new SqlCommand(sqlSelectStatement, connCustomer);
                SqlDataReader dtrCustomer = cmdTxt.ExecuteReader();
                dtrCustomer.Read();

                try
                {
                    if ((dtrCustomer["CUS_LNAME"].ToString().Trim().Length != 0))
                    {
                        //ENABLE OTHER CONTROLS
                        txtJobOrder.Enabled = false;
                        txtBoxED_Lname.Enabled = true;
                        txtBoxED_Fname.Enabled = true;
                        txtBoxED_PhoneNum.Enabled = true;
                        txtBoxBalance.Enabled = false;
                        txtBoxDownPayment.Enabled = true;
                        txtBoxStatus.Enabled = true;
                        txtTotalAmount.Enabled = false;
                    }


                    //FILL UP THOSE OBJECT BY GETTING THE DATA FROM TABLE Student
                    txtBoxED_Lname.Text = dtrCustomer["CUS_LNAME"].ToString();
                    txtBoxED_Fname.Text = dtrCustomer["CUS_FNAME"].ToString();
                    txtBoxED_PhoneNum.Text = dtrCustomer["CUS_PHONE"].ToString();
                    txtBoxBalance.Text = dtrCustomer["CUS_BALANCE"].ToString();
                    txtBoxDownPayment.Text = dtrCustomer["CUS_DOWNPAYMENT"].ToString();
                    txtBoxStatus.Text = dtrCustomer["CUS_STATUS"].ToString();
                    txtTotalAmount.Text = dtrCustomer["CUS_AMOUNT"].ToString();
                    
                   
                    // txtBoxEd_Date.Text = dtrCustomer["CUS_DATE"].ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No Record Found", "Warning! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //MessageBox.Show(ex.Message);

                }
                connCustomer.Close();
                connCustomer.Dispose();

                txtBoxBalance.Text = ((double.Parse(txtTotalAmount.Text) - double.Parse(txtBoxDownPayment.Text)).ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtJobOrder.Enabled = true;
            txtBoxED_Lname.Text = " ";
            txtBoxED_Fname.Text = " ";
            txtBoxED_PhoneNum.Text = " ";
            txtBoxBalance.Text = " ";
            txtBoxDownPayment.Text = " ";
            txtBoxStatus.Text = " ";
            txtTotalAmount.Text = " ";
            txtBoxED_Lname.Enabled = false;
            txtBoxED_Fname.Enabled = false;
            txtBoxED_PhoneNum.Enabled = false;
            txtBoxDownPayment.Enabled = false;
            txtBoxStatus.Enabled = false;
            txtJobOrder.Text = " ";

        }

        private void txtBoxDownPayment_TextChanged(object sender, EventArgs e)
        {
            txtBoxBalance.Text = ((double.Parse(txtTotalAmount.Text) - double.Parse(txtBoxDownPayment.Text)).ToString());
        }

 
   

   

    }
}
