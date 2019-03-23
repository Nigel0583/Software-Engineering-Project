namespace CarSYS
{
    partial class frmRemoveCustomer
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grpRemoveCustomer = new System.Windows.Forms.GroupBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cboRemoveCustomer = new System.Windows.Forms.ComboBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.grpRemoveCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpRemoveCustomer
            // 
            this.grpRemoveCustomer.Controls.Add(this.txtUpdate);
            this.grpRemoveCustomer.Controls.Add(this.lblUpdateStatus);
            this.grpRemoveCustomer.Controls.Add(this.lblCustID);
            this.grpRemoveCustomer.Controls.Add(this.txtCustomerID);
            this.grpRemoveCustomer.Controls.Add(this.txtLicence);
            this.grpRemoveCustomer.Controls.Add(this.lblEmail);
            this.grpRemoveCustomer.Controls.Add(this.txtEmail);
            this.grpRemoveCustomer.Controls.Add(this.lblPhone);
            this.grpRemoveCustomer.Controls.Add(this.txtPhone);
            this.grpRemoveCustomer.Controls.Add(this.lblLicence);
            this.grpRemoveCustomer.Controls.Add(this.lblSurname);
            this.grpRemoveCustomer.Controls.Add(this.txtSurname);
            this.grpRemoveCustomer.Controls.Add(this.btnRemoveCustomer);
            this.grpRemoveCustomer.Controls.Add(this.txtFirstName);
            this.grpRemoveCustomer.Controls.Add(this.lblFirstName);
            this.grpRemoveCustomer.Location = new System.Drawing.Point(12, 89);
            this.grpRemoveCustomer.Name = "grpRemoveCustomer";
            this.grpRemoveCustomer.Size = new System.Drawing.Size(365, 209);
            this.grpRemoveCustomer.TabIndex = 11;
            this.grpRemoveCustomer.TabStop = false;
            this.grpRemoveCustomer.Text = "Remove Customer";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(135, 136);
            this.txtUpdate.MaxLength = 12;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(103, 20);
            this.txtUpdate.TabIndex = 54;
            this.txtUpdate.Text = "R";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(10, 143);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(81, 13);
            this.lblUpdateStatus.TabIndex = 53;
            this.lblUpdateStatus.Text = "Updated Status";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(199, 20);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 52;
            this.lblCustID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(270, 17);
            this.txtCustomerID.MaxLength = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(66, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(81, 79);
            this.txtLicence.MaxLength = 12;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.ReadOnly = true;
            this.txtLicence.Size = new System.Drawing.Size(92, 20);
            this.txtLicence.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 108);
            this.txtEmail.MaxLength = 12;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(180, 85);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 38;
            this.lblPhone.Text = "Phone No.";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(244, 82);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(92, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(10, 82);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(65, 13);
            this.lblLicence.TabIndex = 25;
            this.lblLicence.Text = "Licence No.";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(189, 46);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(244, 43);
            this.txtSurname.MaxLength = 12;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(92, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(81, 169);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(255, 34);
            this.btnRemoveCustomer.TabIndex = 10;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(81, 43);
            this.txtFirstName.MaxLength = 12;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(92, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // cboRemoveCustomer
            // 
            this.cboRemoveCustomer.FormattingEnabled = true;
            this.cboRemoveCustomer.Location = new System.Drawing.Point(93, 49);
            this.cboRemoveCustomer.Name = "cboRemoveCustomer";
            this.cboRemoveCustomer.Size = new System.Drawing.Size(255, 21);
            this.cboRemoveCustomer.TabIndex = 12;
            this.cboRemoveCustomer.Text = "RemoveCustomer";
            this.cboRemoveCustomer.SelectedIndexChanged += new System.EventHandler(this.cboRemoveCustomer_SelectedIndexChanged);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(30, 57);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(51, 13);
            this.lblCust.TabIndex = 13;
            this.lblCust.Text = "Customer";
            // 
            // frmRemoveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 310);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.cboRemoveCustomer);
            this.Controls.Add(this.grpRemoveCustomer);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRemoveCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCustomer";
            this.Load += new System.EventHandler(this.frmRemoveCustomer_Load);
            this.grpRemoveCustomer.ResumeLayout(false);
            this.grpRemoveCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpRemoveCustomer;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cboRemoveCustomer;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Label lblCust;
    }
}