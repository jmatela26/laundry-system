namespace _131L_EXER2
{
    partial class EditDelete
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
            this.txtBoxED_Lname = new System.Windows.Forms.TextBox();
            this.txtBoxED_Fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxED_PhoneNum = new System.Windows.Forms.TextBox();
            this.BtnEd_Save = new System.Windows.Forms.Button();
            this.btnED_Delete = new System.Windows.Forms.Button();
            this.BtnEd_Cancel = new System.Windows.Forms.Button();
            this.txtJobOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDownPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ED_AddCust = new System.Windows.Forms.ToolStripMenuItem();
            this.ED_ViewCustTable = new System.Windows.Forms.ToolStripMenuItem();
            this.ed_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxED_Lname
            // 
            this.txtBoxED_Lname.Enabled = false;
            this.txtBoxED_Lname.Location = new System.Drawing.Point(145, 98);
            this.txtBoxED_Lname.Name = "txtBoxED_Lname";
            this.txtBoxED_Lname.Size = new System.Drawing.Size(111, 20);
            this.txtBoxED_Lname.TabIndex = 2;
            this.txtBoxED_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LName);
            // 
            // txtBoxED_Fname
            // 
            this.txtBoxED_Fname.Enabled = false;
            this.txtBoxED_Fname.Location = new System.Drawing.Point(282, 98);
            this.txtBoxED_Fname.Name = "txtBoxED_Fname";
            this.txtBoxED_Fname.Size = new System.Drawing.Size(102, 20);
            this.txtBoxED_Fname.TabIndex = 3;
            this.txtBoxED_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone No. :";
            // 
            // txtBoxED_PhoneNum
            // 
            this.txtBoxED_PhoneNum.Enabled = false;
            this.txtBoxED_PhoneNum.Location = new System.Drawing.Point(145, 175);
            this.txtBoxED_PhoneNum.Name = "txtBoxED_PhoneNum";
            this.txtBoxED_PhoneNum.Size = new System.Drawing.Size(111, 20);
            this.txtBoxED_PhoneNum.TabIndex = 13;
            this.txtBoxED_PhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone);
            // 
            // BtnEd_Save
            // 
            this.BtnEd_Save.Location = new System.Drawing.Point(47, 273);
            this.BtnEd_Save.Name = "BtnEd_Save";
            this.BtnEd_Save.Size = new System.Drawing.Size(92, 27);
            this.BtnEd_Save.TabIndex = 15;
            this.BtnEd_Save.Text = "Save";
            this.BtnEd_Save.UseVisualStyleBackColor = true;
            this.BtnEd_Save.Click += new System.EventHandler(this.BtnEd_Save_Click);
            // 
            // btnED_Delete
            // 
            this.btnED_Delete.Location = new System.Drawing.Point(145, 273);
            this.btnED_Delete.Name = "btnED_Delete";
            this.btnED_Delete.Size = new System.Drawing.Size(87, 27);
            this.btnED_Delete.TabIndex = 16;
            this.btnED_Delete.Text = "Delete";
            this.btnED_Delete.UseVisualStyleBackColor = true;
            this.btnED_Delete.Click += new System.EventHandler(this.btnED_Delete_Click);
            // 
            // BtnEd_Cancel
            // 
            this.BtnEd_Cancel.Location = new System.Drawing.Point(419, 267);
            this.BtnEd_Cancel.Name = "BtnEd_Cancel";
            this.BtnEd_Cancel.Size = new System.Drawing.Size(89, 33);
            this.BtnEd_Cancel.TabIndex = 17;
            this.BtnEd_Cancel.Text = "Cancel";
            this.BtnEd_Cancel.UseVisualStyleBackColor = true;
            this.BtnEd_Cancel.Click += new System.EventHandler(this.BtnEd_Cancel_Click);
            // 
            // txtJobOrder
            // 
            this.txtJobOrder.Location = new System.Drawing.Point(216, 36);
            this.txtJobOrder.Name = "txtJobOrder";
            this.txtJobOrder.Size = new System.Drawing.Size(114, 20);
            this.txtJobOrder.TabIndex = 20;
            this.txtJobOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyCode);
            this.txtJobOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCusCode);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Job Order :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 27);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Enabled = false;
            this.txtBoxBalance.Location = new System.Drawing.Point(145, 141);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(111, 20);
            this.txtBoxBalance.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Balance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Down Payment :";
            // 
            // txtBoxDownPayment
            // 
            this.txtBoxDownPayment.Enabled = false;
            this.txtBoxDownPayment.Location = new System.Drawing.Point(368, 137);
            this.txtBoxDownPayment.Name = "txtBoxDownPayment";
            this.txtBoxDownPayment.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDownPayment.TabIndex = 26;
            this.txtBoxDownPayment.TextChanged += new System.EventHandler(this.txtBoxDownPayment_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Status : ";
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Enabled = false;
            this.txtBoxStatus.Location = new System.Drawing.Point(368, 175);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStatus.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total Amount :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(145, 205);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 31;
            this.txtTotalAmount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ED_AddCust
            // 
            this.ED_AddCust.Name = "ED_AddCust";
            this.ED_AddCust.Size = new System.Drawing.Size(96, 20);
            this.ED_AddCust.Text = "Add Customer";
            this.ED_AddCust.Click += new System.EventHandler(this.ED_AddCust_Click);
            // 
            // ED_ViewCustTable
            // 
            this.ED_ViewCustTable.Name = "ED_ViewCustTable";
            this.ED_ViewCustTable.Size = new System.Drawing.Size(131, 20);
            this.ED_ViewCustTable.Text = "View Customer Table";
            this.ED_ViewCustTable.Click += new System.EventHandler(this.ED_ViewCustTable_Click);
            // 
            // ed_exit
            // 
            this.ed_exit.Name = "ed_exit";
            this.ed_exit.Size = new System.Drawing.Size(37, 20);
            this.ed_exit.Text = "Exit";
            this.ed_exit.Click += new System.EventHandler(this.ed_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ED_AddCust,
            this.ED_ViewCustTable,
            this.ed_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxDownPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJobOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEd_Cancel);
            this.Controls.Add(this.btnED_Delete);
            this.Controls.Add(this.BtnEd_Save);
            this.Controls.Add(this.txtBoxED_PhoneNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxED_Fname);
            this.Controls.Add(this.txtBoxED_Lname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditDelete";
            this.Text = "Edit/Delete Customer";
            this.Load += new System.EventHandler(this.EditDelete_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxED_Lname;
        private System.Windows.Forms.TextBox txtBoxED_Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxED_PhoneNum;
        private System.Windows.Forms.Button BtnEd_Save;
        private System.Windows.Forms.Button btnED_Delete;
        private System.Windows.Forms.Button BtnEd_Cancel;
        private System.Windows.Forms.TextBox txtJobOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDownPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ED_AddCust;
        private System.Windows.Forms.ToolStripMenuItem ED_ViewCustTable;
        private System.Windows.Forms.ToolStripMenuItem ed_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}