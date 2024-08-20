namespace _131L_EXER2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonViewCustomerTable = new System.Windows.Forms.Button();
            this.buttonEditDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewCustomerTable
            // 
            this.buttonViewCustomerTable.BackColor = System.Drawing.Color.Transparent;
            this.buttonViewCustomerTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonViewCustomerTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewCustomerTable.Location = new System.Drawing.Point(159, 229);
            this.buttonViewCustomerTable.Name = "buttonViewCustomerTable";
            this.buttonViewCustomerTable.Size = new System.Drawing.Size(219, 37);
            this.buttonViewCustomerTable.TabIndex = 5;
            this.buttonViewCustomerTable.Text = "View Customer Table";
            this.buttonViewCustomerTable.UseVisualStyleBackColor = false;
            this.buttonViewCustomerTable.Click += new System.EventHandler(this.buttonViewCustomerTable_Click);
            // 
            // buttonEditDeleteCustomer
            // 
            this.buttonEditDeleteCustomer.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditDeleteCustomer.ForeColor = System.Drawing.Color.Black;
            this.buttonEditDeleteCustomer.Location = new System.Drawing.Point(159, 175);
            this.buttonEditDeleteCustomer.Name = "buttonEditDeleteCustomer";
            this.buttonEditDeleteCustomer.Size = new System.Drawing.Size(219, 38);
            this.buttonEditDeleteCustomer.TabIndex = 4;
            this.buttonEditDeleteCustomer.Text = "Edit/Delete Customer";
            this.buttonEditDeleteCustomer.UseVisualStyleBackColor = false;
            this.buttonEditDeleteCustomer.Click += new System.EventHandler(this.buttonEditDeleteCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddCustomer.Location = new System.Drawing.Point(159, 121);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(219, 39);
            this.buttonAddCustomer.TabIndex = 3;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 382);
            this.Controls.Add(this.buttonViewCustomerTable);
            this.Controls.Add(this.buttonEditDeleteCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewCustomerTable;
        private System.Windows.Forms.Button buttonEditDeleteCustomer;
        private System.Windows.Forms.Button buttonAddCustomer;
    }
}