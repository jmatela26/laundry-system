using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using _131L_EXER2.Properties;
using _131L_EXER2.Models;

namespace _131L_EXER2
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuEditDeleteCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDelete nn = new EditDelete();
            nn.Show();
        }
              

 
        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtBoxCusCode.Text.Trim() != " " && txtboxFname.Text.Trim() != " " && txtboxLname.Text.Trim() != " " && txtBoxPhoneNo.Text.Trim() != " "
            //    && txtBoxDownPayment.Text.Trim() != " " && txtQty1.Text.Trim() != " " && cmboType1.Text.Trim() != " "
            //    && cmboBoxStatus.Text.Trim() != " ")




            if (IsNull())
            {
                Save.Enabled = false;
            }
            else
                Save.Enabled = true;

             
                double cusCode, cusAmount, cusBalance, cusDownPayment;
                string cusfName, cuslName,  cusDate, cusPhone, cusStatus;
                

                //cusCode = int.Parse(txtBoxCusCode.Text);
                
                
                    cuslName = txtboxLname.Text;
                    cusfName = txtboxFname.Text;
                    cusPhone = txtBoxPhoneNo.Text;
                    cusAmount = double.Parse(txtTotalFinal.Text);
                    cusDate = dateTimePicker1.Value.Date.ToShortDateString();
                    cusBalance = double.Parse(txtBoxBalance.Text);
                    cusDownPayment = double.Parse(txtBoxDownPayment.Text);
                    cusStatus = cmboBoxStatus.Text;


               

                //cus

                DataSet dsCustomer = new DataSet();
                DataTable dtCustomer = new DataTable();


                string connString = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
                SqlConnection connCustomer = new SqlConnection(connString);
                connCustomer.Open();


                string sqlSelectStatement = @"SELECT * FROM CUSTOMER";


                SqlDataAdapter daCustomer = new SqlDataAdapter(sqlSelectStatement, connCustomer);


                SqlCommandBuilder cbCustomer = new SqlCommandBuilder(daCustomer);

                daCustomer.Fill(dtCustomer);


                DataRow drNewRow = dtCustomer.NewRow();
                //drNewRow["CUS_JOBORDER"] = cusCode;
                drNewRow["CUS_LNAME"] = cuslName;
                drNewRow["CUS_FNAME"] = cusfName;
                drNewRow["CUS_PHONE"] = cusPhone;
                drNewRow["CUS_DATE"] = cusDate;
                drNewRow["CUS_AMOUNT"] = cusAmount;
                drNewRow["CUS_BALANCE"] = cusBalance;
                drNewRow["CUS_DOWNPAYMENT"] = cusDownPayment;
                drNewRow["CUS_STATUS"] = cusStatus;

           

                //ADD THE NEW DATA IN THE DATA TABLE
                dtCustomer.Rows.Add(drNewRow);

                //SAVE IT IN THE DATABASE
                
               
                daCustomer.Update(dtCustomer);

                /*string sqlSelect = @"SELECT CUS_JOBORDER FROM CUSTOMER";
                SqlDataAdapter daCustomer = new SqlDataAdapter(sqlSelect, connCustomer);*/
          
                

                //string sqlGet = @"select CUS_JOBORDER from CUSTOMER where CUS_LNAME = '" + txtboxLname +"' ";
                //SqlCommand cmdTxt = new SqlCommand(sqlGet, connCustomer);
                //SqlDataReader dtrCustomer = cmdTxt.ExecuteReader();
                //dtrCustomer.Read();



                //    //FILL UP THOSE OBJECT BY GETTING THE DATA FROM TABLE Student

                //    txtBoxCusCode.Text = dtrCustomer["CUS_JOBORDER"].ToString();

                //string sqlCustomer = @"select CUS_PHONE from CUSTOMER where CUS_JOBORDER= '" + txtboxLname.Text + "'";
                //SqlCommand cmdTxt = new SqlCommand(sqlSelectStatement, connCustomer);
                //SqlDataReader dtrCustomer = cmdTxt.ExecuteReader();
                //dtrCustomer.Read();
                
                //txtBoxCusCode.Text  = dtrCustomer["CUS_JOBORDER"].ToString();

              
                MessageBox.Show("Saved!" + txtBoxCusCode.Text);
       
                //CLOSE THE DATA SOURCE
                connCustomer.Close();
                connCustomer.Dispose();
                this.Close();
            }
  
        
        private void CusCode(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Lname(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Fname(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCustomerTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTable vv = new ViewTable();
            vv.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int numOfDays;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            




            if (cmboType1.SelectedIndex == 0)

                txtTotal1.Text = (double.Parse(txtQty1.Text) * 25).ToString();
            else if (cmboType1.SelectedIndex == 1)
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 75).ToString();
            else if (cmboType1.SelectedIndex == 2)
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 65).ToString();
            else if (cmboType1.SelectedIndex == 3)
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 60).ToString();
            else if (cmboType1.SelectedIndex == 4)
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 120).ToString();
            else if (cmboType1.SelectedIndex == 5)
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 60).ToString();

            //else if (cmboType1.SelectedIndex == 4)
            //    txtTotal1.Text = null;
           
         
            /*if (txtQty1.Text != "" && cmboType1.Text != "")
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 25).ToString();
            if (txtQty2.Text != "" && cmboType2.Text != "")
                txtTotal2.Text = (double.Parse(txtQty2.Text) * 50).ToString();
            if (txtQty3.Text != "" && cmboType3.Text != "")
                txtTotal3.Text = (double.Parse(txtQty3.Text) * 65).ToString();
            if (txtQty4.Text != "" && cmboType4.Text != "")
                txtTotal4.Text = (double.Parse(txtQty4.Text) * 250).ToString();*/

            //txtTotalFinal.Text = txtTotal1.Text;
        }
        
        private void btnCompute_Click(object sender, EventArgs e)
        {
            //if (txtBoxDownPayment.Text != "")
            //{
            //    btnCompute.Enabled = false;
            //}
            //else
            //    btnCompute.Enabled = true;
                    

            /*if (txtQty1.Text != "" && cmboType1.Text != "")
                txtTotal1.Text = (double.Parse(txtQty1.Text) * 25).ToString();
            if (txtQty2.Text != "" && cmboType2.Text != "")
                txtTotal2.Text = (double.Parse(txtQty2.Text) * 50).ToString();
            if (txtQty3.Text != "" && cmboType3.Text != "")
                txtTotal3.Text = (double.Parse(txtQty3.Text) * 65).ToString();
            if (txtQty4.Text != "" && cmboType4.Text != "")
                txtTotal4.Text = (double.Parse(txtQty4.Text) * 250).ToString();

            txtTotalFinal.Text = (double.Parse(txtTotal1.Text) + double.Parse(txtTotal2.Text) + double.Parse(txtTotal3.Text) + double.Parse(txtTotal4.Text)).ToString();*/
          
           // txtBoxBalance.Text = ((double.Parse(txtTotalFinal.Text) - double.Parse(txtBoxDownPayment.Text)).ToString());
          
        }
       

     
        
                //if (cusDownPayment <= cusAmount)
                //{
                //    cusBalance = cusAmount - cusDownPayment;
                //}
                //else
                //    txtbox_balance.Text = null;
  
         



        private void txtbox_balance_TextChanged(object sender, EventArgs e)
        {

        }

        private void DownPayment(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBoxDownPayment_TextChange(object sender, EventArgs e)
        {

        }

        private void txtTotalFinal_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtQty1_TextChanged(object sender, EventArgs e)
        {

            if (txtQty1.Text != "")
            {
                txtTotal1.Text = "0";
            }
            else
                txtTotal1.Text = "0";

            if (txtQty1.Text != "")
            {
                cmboType1.Text = "";
            }
            else
                cmboType1.Text = "";

            if (txtQty1.Text != "")
            {
                cmboType1.Enabled = true;
            }
            else
                cmboType1.Enabled = false;

            if (txtQty1.Text != "")
            {
                AddBut.Enabled = true;
            }
            else
                AddBut.Enabled = false;

            if (txtQty1.Text != "")
            {
                RemoveBut.Enabled = true;
            }
            else
                RemoveBut.Enabled = false;
        }

        private void txtTotal1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
          //  txtBoxBalance.Text = ((double.Parse(txtTotalFinal.Text) - double.Parse(txtBoxDownPayment.Text)).ToString());

            txtBoxDownPayment.Enabled = true;
            txtFullAmt.Enabled = true;

            int sum;
            sum = Convert.ToInt32(txtTotal1.Text);
            sum = int.Parse(txtTotal1.Text);
            
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            int count_row = dataGridView1.Rows.Count;
            txtTotalFinal.Text = sum.ToString();

           


            int row = 0;
            

            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["Qty", row].Value = txtQty1.Text;
            dataGridView1["LaundryType", row].Value = cmboType1.Text;


            /*Wash Dry Fold - P 25.00
Wash Dry Press - P 75.00
Comforter - P 65.00
Bed Sheet Towel Blanket - P 60.00
Car Seat Cover  - P 120.00
Curtain - P 60.00*/

            if (cmboType1.Text == "Wash Dry Fold")
            {
                dataGridView1["UnitPrice", row].Value = "25";
            }

            if (cmboType1.Text == "Wash Dry Press")
            {
                dataGridView1["UnitPrice", row].Value = "75";
            }

            if (cmboType1.Text == "Comforter")
            {
                dataGridView1["UnitPrice", row].Value = "65";
            }

            if (cmboType1.Text == "Bed Sheet Towel Blanket")
            {
                dataGridView1["UnitPrice", row].Value = "60";
            }

            if (cmboType1.Text == "Curtain")
            {
                dataGridView1["UnitPrice", row].Value = "60";
            }

            if (cmboType1.Text == "Car Seat Cover")
            {
                dataGridView1["UnitPrice", row].Value = "120";
            }


            dataGridView1["TotalPrice", row].Value = txtTotal1.Text;



            if (IsValidated())
            {
                
            }

           

               

                //dataGridView1.DataSource = null;
                //dataGridView1.DataSource = item;

            //    cmboType1.SelectedIndex = -1;
            //    txtQty1.Clear();
                

            //}
            //decimal totalAmount = dataGridView1.Rows.Count

            
        }

        private bool IsValidated()
        {
            if (txtboxLname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer's last name and first name is required","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txtboxFname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer's last name and first name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtBoxPhoneNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer's phone number  is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtQty1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(txtQty1.Text.Trim(), out tempQuantity);

                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be an integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty1.Focus();
                    return false;
                }
            }

            if (cmboType1.SelectedIndex == -1)
            {
                MessageBox.Show("Laundry Type is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }
            
            return true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int sum;
            //sum = Convert.ToInt32(txtTotal1.Text);
            //sum = int.Parse(txtTotal1.Text);

            //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //{
            //    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            //}
            //int count_row = dataGridView1.Rows.Count;
            //txtTotalFinal.Text = sum.ToString();
            int diff;
            diff = Convert.ToInt32(txtTotal1.Text);
            diff = int.Parse(txtTotal1.Text);
           // diff += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                diff += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            int count_row = dataGridView1.Rows.Count;
            txtTotalFinal.Text = diff.ToString();
            //txtTotalFinal.Text = "";
            //txtBoxBalance.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
          
        }
        private List<LaundryItem> LaundryShop = new List<LaundryItem>();
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            //dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Width));
            //e.Graphics.DrawImage(bm, 200, 100);

            LaundryItem item = new LaundryItem()
            {
                Quantity = Convert.ToInt16(txtQty1.Text.Trim()),
                ItemName = cmboType1.Text,
                Price = Convert.ToDecimal(txtTotal1.Text.Trim()),


            };
             LaundryShop.Add(item);

            Image image = Resources.LeiMitch3;
            e.Graphics.DrawImage(image,0,0, image.Width,image.Height);

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 20 ,FontStyle.Regular), Brushes.Black, new Point(475, 1020));
            e.Graphics.DrawString("Customer Number: " + txtBoxCusCode.Text.Trim(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString("Name: " + txtboxLname.Text.Trim() + ", " + txtboxFname.Text.Trim(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 350));
            e.Graphics.DrawString("Phone: " + txtBoxPhoneNo.Text.Trim(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 400));

            e.Graphics.DrawString("************************************************************************", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 450));
            e.Graphics.DrawString("Laundry Services", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 470));
            e.Graphics.DrawString("************************************************************************", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 500));

            e.Graphics.DrawString("Quantity", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(30, 520));
            e.Graphics.DrawString("Type", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(380, 520));
            e.Graphics.DrawString("Total", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, 520));
            e.Graphics.DrawString("************************************************************************", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 550));

            
            int yPos = 600;

           

            foreach (var i in LaundryShop)
            {
                e.Graphics.DrawString(txtQty1.Text.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(cmboType1.Text.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, yPos));
                e.Graphics.DrawString(txtTotal1.Text.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, yPos
                      ));
                yPos += 30;

            }

            e.Graphics.DrawString("Total Amount: " + txtTotalFinal.Text.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 950));
            


           
            
        }

        private void txtboxLname_TextChanged(object sender, EventArgs e)
        {
            //if (txtboxLname.Text.Trim() != " " && txtboxFname.Text.Trim() != " ")
            //{
            //    Save.Enabled = true;
            //}
            //else
            //    Save.Enabled = false;
           //if( IsNull())
        }

        private bool IsNull()
        {
            if (txtboxLname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer's last name and first name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtboxFname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer's last name and first name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtBoxPhoneNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Customer's phone number  is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtQty1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Quantity is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty1.Clear();
                return false;
            }
            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(txtQty1.Text.Trim(), out tempQuantity);

                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be an integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQty1.Focus();
                    return false;
                }
            }

            if (cmboType1.SelectedIndex == -1)
            {
                MessageBox.Show("Laundry Type is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmboType1.Text = "";
                return false;
            }
            if (txtBoxDownPayment.Text.Trim() == string.Empty)
            {
                int tempDownPayment;
                bool isNumeric = int.TryParse(txtBoxDownPayment.Text.Trim(), out tempDownPayment);
                
                if (!isNumeric)
                {
                    MessageBox.Show("Quantity should be an integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxDownPayment.Focus();
                    return false;
                }
            }
            return true;
        }

        private void txtboxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDownPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxDownPayment.Text != "")
            {
                Save.Enabled = true;
                
            }
            else 
                Save.Enabled = false;

            if (txtBoxDownPayment.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
             
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button4.Enabled = true;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            int count_row = dataGridView1.Rows.Count;

            if (radioButton2.Checked)
            {
                
                txtBoxBalance.Text = ((double.Parse(txtTotalFinal.Text) - double.Parse(txtBoxDownPayment.Text)).ToString());
                txtChange.Text = ((double.Parse(txtFullAmt.Text) - double.Parse(txtBoxDownPayment.Text)).ToString());

                if (double.Parse(txtBoxDownPayment.Text) > double.Parse(txtTotalFinal.Text))
                {
                    txtChange.Text = "0";
                    txtBoxBalance.Text = "0";
                    MessageBox.Show("Please enter another amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }
            }
            if (radioButton1.Checked)
            {
                txtBoxBalance.Text = ((double.Parse(txtTotalFinal.Text) - double.Parse(txtFullAmt.Text)).ToString());
                txtChange.Text = ((double.Parse(txtFullAmt.Text) - double.Parse(txtTotalFinal.Text)).ToString());

                if (double.Parse(txtFullAmt.Text) < double.Parse(txtTotalFinal.Text))
                {
                    txtChange.Text = "0";
                    txtBoxBalance.Text = "0";
                    MessageBox.Show("Your payment is insufficient! Please enter another amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }
            }

            

            
            txtTotalFinal.Text = sum.ToString();
                


            if (double.Parse(txtBoxBalance.Text.ToString()) < 0)
            {
                txtBoxBalance.Text = "0";
            }
            //else
            //    txtChange.Text = "0";
            //   txtChange.Text = ((double.Parse(txtBoxDownPayment.Text) - double.Parse(txtTotalFinal.Text)).ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtQty1.Text = "";
            cmboType1.Text = "";
            txtBoxPhoneNo.Text = "";
            txtboxLname.Text = "";
            txtboxFname.Text = "";
            txtBoxDownPayment.Text = "";
            cmboBoxStatus.Text = "";
            txtTotalFinal.Text = "0";
            txtBoxBalance.Text = "0";
            txtChange.Text = "0";
            txtFullAmt.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            button6.Enabled = false;
            button4.Enabled = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void txtBoxBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxDownPayment.Enabled = false;
            txtFullAmt.Enabled = true;
            txtBoxDownPayment.Clear();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxDownPayment.Enabled = true;
            txtFullAmt.Enabled = true;
        }

        private void FullAmt_TextChanged(object sender, EventArgs e)
        {

            
            
            if (txtFullAmt.Text != "")
            {
                Save.Enabled = true;

            }
            else
                Save.Enabled = false;

            if (txtFullAmt.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void TotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCusCode_TextChanged(object sender, EventArgs e)
        {

        }

    }
}