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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void MenuEditDeleteCust_Click(object sender, EventArgs e)
        {
            EditDelete nn = new EditDelete();
            nn.Show();
        }

        private void viewCustomerTable_Click(object sender, EventArgs e)
        {
            ViewTable rr = new ViewTable();
            rr.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_CusCode(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void textBox_CusAreaCode(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void textBox_CusLName(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void textBox_CusFName(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void textBox_Initial(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cusCode, cusArea, cusPhone;
            double cusBal;
            string cusfName, cuslName, cusInitial;

            cusCode = int.Parse(txtBoxCusCode.Text);
            cuslName = txtboxLname.Text.ToString();
            cusfName = txtboxFname.Text.ToString();
            cusInitial = txtBoxMI.Text.ToString();
            cusArea = int.Parse(txtBoxAreaCode.Text);
            cusPhone = int.Parse(txtBoxPhoneNo.Text);
            cusBal = int.Parse(txtbox_balance.Text);

            
            DataSet dsCustomer = new DataSet();
            DataTable dtCustomer = new DataTable();

            
            string connString = @"Data Source=HP-PC\SQLEXPRESS;Initial Catalog=exercise5;Integrated Security=True";
            SqlConnection connCustomer = new SqlConnection(connString);
            connCustomer.Open();

            
            string sqlSelectStatement = @"SELECT * FROM CUSTOMER";

            
            SqlDataAdapter daCustomer = new SqlDataAdapter(sqlSelectStatement, connCustomer);


            SqlCommandBuilder cbCustomer = new SqlCommandBuilder(daCustomer);

            daCustomer.Fill(dtCustomer);


            DataRow drNewRow = dtCustomer.NewRow();
            drNewRow["CUS_CODE"] = cusCode;
            drNewRow["CUS_LNAME"] = cuslName;
            drNewRow["CUS_FNAME"] = cusfName;
            drNewRow["CUS_INITIAL"] = cusInitial;
            drNewRow["CUS_AREACODE"] = cusArea;
            drNewRow["CUS_PHONE"] = cusPhone;
            drNewRow["CUS_BALANCE"] = cusBal;

            //ADD THE NEW DATA IN THE DATA TABLE
            dtCustomer.Rows.Add(drNewRow);

            //SAVE IT IN THE DATABASE
            daCustomer.Update(dtCustomer);

            MessageBox.Show("Saved!");

            //CLOSE THE DATA SOURCE
            connCustomer.Close();
            connCustomer.Dispose();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int cusCode, cusArea, cusPhone;
                double cusBal;
                string cusfName, cuslName, cusInitial;

                cusCode = int.Parse(txtBoxCusCode.Text);
                cuslName = txtboxLname.Text.ToString();
                cusfName = txtboxFname.Text.ToString();
                cusInitial = txtBoxMI.Text.ToString();
                cusArea = int.Parse(txtBoxAreaCode.Text);
                cusPhone = int.Parse(txtBoxPhoneNo.Text);
                cusBal = int.Parse(txtbox_balance.Text);


                //ACCESS THE DATA SOURCE
                string connString = @"Data Source=HP-PC\SQLEXPRESS;Initial Catalog=exercise5;Integrated Security=True";
                SqlConnection connCustomer = new SqlConnection(connString);
                connCustomer.Open();

                string sqlInsertStatement = @"Insert into Customer (cus_code, cus_lname, cus_fname, cus_initial, cus_areacode, cus_phone, cus_balance) 
                                                              Values (" + cusCode + ",'" + cuslName + cusfName + cusInitial + cusArea + cusPhone + cusBal + "')";

                SqlCommand cmdTxt = new SqlCommand(sqlInsertStatement, connCustomer);

                cmdTxt.ExecuteNonQuery();
                MessageBox.Show("Saving is done!");

                connCustomer.Close();
                connCustomer.Dispose();
                this.Close();    //CLOSE THE FORM
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textBox_Phone(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void textBox_Balance(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            } 
        }

        private void txtBoxCusCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
