namespace CarSYS
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAddCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpCustomer = new System.Windows.Forms.DateTimePicker();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpAddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(307, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpAddCustomer
            // 
            this.grpAddCustomer.Controls.Add(this.lblCustID);
            this.grpAddCustomer.Controls.Add(this.txtCustomerID);
            this.grpAddCustomer.Controls.Add(this.lblDOB);
            this.grpAddCustomer.Controls.Add(this.dtpCustomer);
            this.grpAddCustomer.Controls.Add(this.txtLicence);
            this.grpAddCustomer.Controls.Add(this.lblEmail);
            this.grpAddCustomer.Controls.Add(this.txtEmail);
            this.grpAddCustomer.Controls.Add(this.txtZipCode);
            this.grpAddCustomer.Controls.Add(this.lblZipCode);
            this.grpAddCustomer.Controls.Add(this.lblCountry);
            this.grpAddCustomer.Controls.Add(this.txtCountry);
            this.grpAddCustomer.Controls.Add(this.lblAddress);
            this.grpAddCustomer.Controls.Add(this.txtAddress);
            this.grpAddCustomer.Controls.Add(this.lblPhone);
            this.grpAddCustomer.Controls.Add(this.txtPhone);
            this.grpAddCustomer.Controls.Add(this.lblLicence);
            this.grpAddCustomer.Controls.Add(this.lblSurname);
            this.grpAddCustomer.Controls.Add(this.txtSurname);
            this.grpAddCustomer.Controls.Add(this.btnAddCustomer);
            this.grpAddCustomer.Controls.Add(this.txtFirstName);
            this.grpAddCustomer.Controls.Add(this.lblFirstName);
            this.grpAddCustomer.Location = new System.Drawing.Point(12, 41);
            this.grpAddCustomer.Name = "grpAddCustomer";
            this.grpAddCustomer.Size = new System.Drawing.Size(365, 281);
            this.grpAddCustomer.TabIndex = 10;
            this.grpAddCustomer.TabStop = false;
            this.grpAddCustomer.Text = "Enter customer  details";
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
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(32, 222);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(30, 13);
            this.lblDOB.TabIndex = 50;
            this.lblDOB.Text = "DOB";
            // 
            // dtpCustomer
            // 
            this.dtpCustomer.Location = new System.Drawing.Point(81, 215);
            this.dtpCustomer.Name = "dtpCustomer";
            this.dtpCustomer.Size = new System.Drawing.Size(255, 20);
            this.dtpCustomer.TabIndex = 10;
            this.dtpCustomer.Value = new System.DateTime(2019, 2, 24, 0, 0, 0, 0);
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(81, 79);
            this.txtLicence.MaxLength = 12;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.Size = new System.Drawing.Size(92, 20);
            this.txtLicence.TabIndex = 4;
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
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmail.Location = new System.Drawing.Point(81, 108);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "example@email.com";
            this.txtEmail.Enter += new System.EventHandler(this.EmailTextEnter);
            this.txtEmail.Leave += new System.EventHandler(this.EmailTextLeave);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(244, 172);
            this.txtZipCode.MaxLength = 18;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(92, 20);
            this.txtZipCode.TabIndex = 9;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(188, 179);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 43;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(30, 179);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 42;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtCountry.Location = new System.Drawing.Point(81, 172);
            this.txtCountry.MaxLength = 56;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(92, 20);
            this.txtCountry.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(30, 153);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 40;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 146);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(255, 20);
            this.txtAddress.TabIndex = 7;
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
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPhone.Location = new System.Drawing.Point(244, 82);
            this.txtPhone.MaxLength = 18;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(92, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "+353861234567";
            this.txtPhone.Enter += new System.EventHandler(this.phoneTextEnter);
            this.txtPhone.Leave += new System.EventHandler(this.phoneTextLeave);
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
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(92, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(81, 241);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(255, 34);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(91, 43);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(92, 20);
            this.txtFirstName.TabIndex = 2;
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
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 348);
            this.Controls.Add(this.grpAddCustomer);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.grpAddCustomer.ResumeLayout(false);
            this.grpAddCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpAddCustomer;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpCustomer;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustomerID;
    }
}