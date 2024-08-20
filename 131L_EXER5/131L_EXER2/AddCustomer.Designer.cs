namespace _131L_EXER2
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxCusCode = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.txtBoxAreaCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMI = new System.Windows.Forms.TextBox();
            this.txtboxFname = new System.Windows.Forms.TextBox();
            this.txtboxLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuEditDeleteCust = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerTable = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_balance = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 25);
            this.button1.TabIndex = 46;
            this.button1.Text = "Save Using Data Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxCusCode
            // 
            this.txtBoxCusCode.Location = new System.Drawing.Point(113, 85);
            this.txtBoxCusCode.MaxLength = 5;
            this.txtBoxCusCode.Name = "txtBoxCusCode";
            this.txtBoxCusCode.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCusCode.TabIndex = 45;
            this.txtBoxCusCode.TextChanged += new System.EventHandler(this.txtBoxCusCode_TextChanged);
            this.txtBoxCusCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CusCode);
            // 
            // txtBoxPhoneNo
            // 
            this.txtBoxPhoneNo.Location = new System.Drawing.Point(113, 209);
            this.txtBoxPhoneNo.Name = "txtBoxPhoneNo";
            this.txtBoxPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPhoneNo.TabIndex = 44;
            this.txtBoxPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone);
            // 
            // txtBoxAreaCode
            // 
            this.txtBoxAreaCode.Location = new System.Drawing.Point(113, 171);
            this.txtBoxAreaCode.MaxLength = 3;
            this.txtBoxAreaCode.Name = "txtBoxAreaCode";
            this.txtBoxAreaCode.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAreaCode.TabIndex = 43;
            this.txtBoxAreaCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CusAreaCode);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Phone No. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Area Code :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "M.I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "First Name";
            // 
            // txtBoxMI
            // 
            this.txtBoxMI.Location = new System.Drawing.Point(402, 119);
            this.txtBoxMI.MaxLength = 2;
            this.txtBoxMI.Name = "txtBoxMI";
            this.txtBoxMI.Size = new System.Drawing.Size(57, 20);
            this.txtBoxMI.TabIndex = 2;
            this.txtBoxMI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Initial);
            // 
            // txtboxFname
            // 
            this.txtboxFname.Location = new System.Drawing.Point(233, 120);
            this.txtboxFname.MaxLength = 30;
            this.txtboxFname.Name = "txtboxFname";
            this.txtboxFname.Size = new System.Drawing.Size(136, 20);
            this.txtboxFname.TabIndex = 15;
            this.txtboxFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CusFName);
            // 
            // txtboxLname
            // 
            this.txtboxLname.Location = new System.Drawing.Point(113, 120);
            this.txtboxLname.MaxLength = 30;
            this.txtboxLname.Name = "txtboxLname";
            this.txtboxLname.Size = new System.Drawing.Size(100, 20);
            this.txtboxLname.TabIndex = 15;
            this.txtboxLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CusLName);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cus Code :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditDeleteCust,
            this.viewCustomerTable,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "Edit/Delete Customer";
            // 
            // MenuEditDeleteCust
            // 
            this.MenuEditDeleteCust.Name = "MenuEditDeleteCust";
            this.MenuEditDeleteCust.Size = new System.Drawing.Size(132, 20);
            this.MenuEditDeleteCust.Text = "Edit/Delete Customer";
            this.MenuEditDeleteCust.Click += new System.EventHandler(this.MenuEditDeleteCust_Click);
            // 
            // viewCustomerTable
            // 
            this.viewCustomerTable.Name = "viewCustomerTable";
            this.viewCustomerTable.Size = new System.Drawing.Size(131, 20);
            this.viewCustomerTable.Text = "View Customer Table";
            this.viewCustomerTable.Click += new System.EventHandler(this.viewCustomerTable_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Balance :";
            // 
            // txtbox_balance
            // 
            this.txtbox_balance.Location = new System.Drawing.Point(113, 243);
            this.txtbox_balance.Name = "txtbox_balance";
            this.txtbox_balance.Size = new System.Drawing.Size(100, 20);
            this.txtbox_balance.TabIndex = 49;
            this.txtbox_balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Balance);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 25);
            this.button3.TabIndex = 50;
            this.button3.Text = "Save NOT Using Data Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 324);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtbox_balance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxCusCode);
            this.Controls.Add(this.txtBoxPhoneNo);
            this.Controls.Add(this.txtBoxAreaCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMI);
            this.Controls.Add(this.txtboxFname);
            this.Controls.Add(this.txtboxLname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCusCode;
        private System.Windows.Forms.TextBox txtBoxPhoneNo;
        private System.Windows.Forms.TextBox txtBoxAreaCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxMI;
        private System.Windows.Forms.TextBox txtboxFname;
        private System.Windows.Forms.TextBox txtboxLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuEditDeleteCust;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerTable;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_balance;
        private System.Windows.Forms.Button button3;


    }
}