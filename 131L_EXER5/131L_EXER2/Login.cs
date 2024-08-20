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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             string connstring = @"Data Source=TOBI;Initial Catalog=exercise5;Integrated Security=True";
            SqlConnection conLogin = new SqlConnection(connstring);
            conLogin.Open();

            SqlCommand cmd = new SqlCommand("SELECT Username, Pass from USERS WHERE Username='" + txtUser.Text + "' AND Pass='" + txtPass.Text + "'", conLogin);

           SqlDataReader rdr = cmd.ExecuteReader();
            
            if (rdr.Read())
            {
                this.Hide();
                MessageBox.Show("Welcome " + txtUser.Text + "!");
                this.Hide();
                Login home = new Login();
                home.Closed += (s, args) => this.Close();
            //    home.Show();

                
                Menu form = new Menu();
                this.Hide();
                form.ShowDialog();
                this.Close();
            
            }
            else
                MessageBox.Show("Incorrect Username or Password! Please try again.");







        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        }
    }

