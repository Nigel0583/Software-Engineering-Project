namespace CarSYS
{
    partial class frmMakeBooking
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
            this.grpMakeBooking = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCarCategory = new System.Windows.Forms.ComboBox();
            this.grpChoseCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.grdSelectCar = new System.Windows.Forms.DataGridView();
            this.grpChoseCar = new System.Windows.Forms.GroupBox();
            this.grdTotalCost = new System.Windows.Forms.DataGridView();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCostDay = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtRegChosen = new System.Windows.Forms.TextBox();
            this.lblRegChosen = new System.Windows.Forms.Label();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.grpMakeBooking.SuspendLayout();
            this.grpChoseCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectCar)).BeginInit();
            this.grpChoseCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalCost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(775, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpMakeBooking
            // 
            this.grpMakeBooking.Controls.Add(this.lblFrom);
            this.grpMakeBooking.Controls.Add(this.lblTo);
            this.grpMakeBooking.Controls.Add(this.dtpFrom);
            this.grpMakeBooking.Controls.Add(this.dtpTo);
            this.grpMakeBooking.Controls.Add(this.btnSelectCar);
            this.grpMakeBooking.Location = new System.Drawing.Point(12, 303);
            this.grpMakeBooking.Name = "grpMakeBooking";
            this.grpMakeBooking.Size = new System.Drawing.Size(287, 111);
            this.grpMakeBooking.TabIndex = 11;
            this.grpMakeBooking.TabStop = false;
            this.grpMakeBooking.Text = "Select Dates + Car Type";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(26, 19);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(26, 46);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFrom.Location = new System.Drawing.Point(62, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(176, 20);
            this.dtpFrom.TabIndex = 12;
            this.dtpFrom.Value = new System.DateTime(2019, 2, 24, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTo.Location = new System.Drawing.Point(62, 46);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(176, 20);
            this.dtpTo.TabIndex = 13;
            this.dtpTo.Value = new System.DateTime(2019, 2, 24, 0, 0, 0, 0);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(29, 81);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(209, 24);
            this.btnSelectCar.TabIndex = 14;
            this.btnSelectCar.Text = "Select Car";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Car Type";
            // 
            // cboCarCategory
            // 
            this.cboCarCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCarCategory.FormattingEnabled = true;
            this.cboCarCategory.Location = new System.Drawing.Point(90, 256);
            this.cboCarCategory.MaxDropDownItems = 10;
            this.cboCarCategory.Name = "cboCarCategory";
            this.cboCarCategory.Size = new System.Drawing.Size(176, 21);
            this.cboCarCategory.TabIndex = 10;
            this.cboCarCategory.Tag = "";
            this.cboCarCategory.Text = "CarType";
            this.cboCarCategory.SelectedIndexChanged += new System.EventHandler(this.cboCarCategory_SelectedIndexChanged);
            // 
            // grpChoseCustomer
            // 
            this.grpChoseCustomer.Controls.Add(this.lblCustID);
            this.grpChoseCustomer.Controls.Add(this.txtCustomerID);
            this.grpChoseCustomer.Controls.Add(this.txtLicence);
            this.grpChoseCustomer.Controls.Add(this.lblEmail);
            this.grpChoseCustomer.Controls.Add(this.txtEmail);
            this.grpChoseCustomer.Controls.Add(this.lblPhone);
            this.grpChoseCustomer.Controls.Add(this.txtPhone);
            this.grpChoseCustomer.Controls.Add(this.lblLicence);
            this.grpChoseCustomer.Controls.Add(this.txtSurname);
            this.grpChoseCustomer.Controls.Add(this.txtFirstName);
            this.grpChoseCustomer.Controls.Add(this.lblName);
            this.grpChoseCustomer.Location = new System.Drawing.Point(12, 84);
            this.grpChoseCustomer.Name = "grpChoseCustomer";
            this.grpChoseCustomer.Size = new System.Drawing.Size(287, 149);
            this.grpChoseCustomer.TabIndex = 9;
            this.grpChoseCustomer.TabStop = false;
            this.grpChoseCustomer.Text = "Customer";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(122, 13);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 64;
            this.lblCustID.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(194, 10);
            this.txtCustomerID.MaxLength = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(66, 20);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(71, 62);
            this.txtLicence.MaxLength = 12;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.ReadOnly = true;
            this.txtLicence.Size = new System.Drawing.Size(92, 20);
            this.txtLicence.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 118);
            this.txtEmail.MaxLength = 12;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 93);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 62;
            this.lblPhone.Text = "Phone No.";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(71, 90);
            this.txtPhone.MaxLength = 12;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(92, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(6, 65);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(65, 13);
            this.lblLicence.TabIndex = 61;
            this.lblLicence.Text = "Licence No.";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(168, 36);
            this.txtSurname.MaxLength = 12;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(92, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(71, 36);
            this.txtFirstName.MaxLength = 12;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(92, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 59;
            this.lblName.Text = "Name";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(90, 57);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(176, 21);
            this.cboCustomer.TabIndex = 2;
            this.cboCustomer.Text = "Customer";
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // grdSelectCar
            // 
            this.grdSelectCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectCar.Location = new System.Drawing.Point(6, 19);
            this.grdSelectCar.Name = "grdSelectCar";
            this.grdSelectCar.Size = new System.Drawing.Size(539, 243);
            this.grdSelectCar.TabIndex = 16;
            this.grdSelectCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectCar_CellContentClick);
            // 
            // grpChoseCar
            // 
            this.grpChoseCar.Controls.Add(this.grdTotalCost);
            this.grpChoseCar.Controls.Add(this.txtCost);
            this.grpChoseCar.Controls.Add(this.lblCostDay);
            this.grpChoseCar.Controls.Add(this.lblCost);
            this.grpChoseCar.Controls.Add(this.txtRegChosen);
            this.grpChoseCar.Controls.Add(this.lblRegChosen);
            this.grpChoseCar.Controls.Add(this.grdSelectCar);
            this.grpChoseCar.Location = new System.Drawing.Point(305, 38);
            this.grpChoseCar.Name = "grpChoseCar";
            this.grpChoseCar.Size = new System.Drawing.Size(553, 335);
            this.grpChoseCar.TabIndex = 15;
            this.grpChoseCar.TabStop = false;
            this.grpChoseCar.Text = "Chose Car";
            // 
            // grdTotalCost
            // 
            this.grdTotalCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotalCost.Location = new System.Drawing.Point(397, 265);
            this.grdTotalCost.Name = "grdTotalCost";
            this.grdTotalCost.Size = new System.Drawing.Size(148, 64);
            this.grdTotalCost.TabIndex = 19;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(285, 295);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(46, 20);
            this.txtCost.TabIndex = 18;
            // 
            // lblCostDay
            // 
            this.lblCostDay.AutoSize = true;
            this.lblCostDay.Location = new System.Drawing.Point(215, 298);
            this.lblCostDay.Name = "lblCostDay";
            this.lblCostDay.Size = new System.Drawing.Size(66, 13);
            this.lblCostDay.TabIndex = 23;
            this.lblCostDay.Text = "Cost per day";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(337, 298);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(54, 13);
            this.lblCost.TabIndex = 21;
            this.lblCost.Text = "Total cost";
            // 
            // txtRegChosen
            // 
            this.txtRegChosen.Location = new System.Drawing.Point(91, 294);
            this.txtRegChosen.Name = "txtRegChosen";
            this.txtRegChosen.ReadOnly = true;
            this.txtRegChosen.Size = new System.Drawing.Size(118, 20);
            this.txtRegChosen.TabIndex = 17;
            // 
            // lblRegChosen
            // 
            this.lblRegChosen.AutoSize = true;
            this.lblRegChosen.Location = new System.Drawing.Point(3, 298);
            this.lblRegChosen.Name = "lblRegChosen";
            this.lblRegChosen.Size = new System.Drawing.Size(82, 13);
            this.lblRegChosen.TabIndex = 19;
            this.lblRegChosen.Text = "Car Registration";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(311, 388);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(260, 43);
            this.btnCancelBooking.TabIndex = 20;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Location = new System.Drawing.Point(598, 388);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(260, 43);
            this.btnMakeBooking.TabIndex = 21;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Location = new System.Drawing.Point(89, 19);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(63, 13);
            this.lblBookingNo.TabIndex = 17;
            this.lblBookingNo.Text = "Booking No";
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.Location = new System.Drawing.Point(174, 19);
            this.txtBookingNo.MaxLength = 12;
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.ReadOnly = true;
            this.txtBookingNo.Size = new System.Drawing.Size(92, 20);
            this.txtBookingNo.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(34, 60);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 19;
            this.lblCustomer.Text = "Customer";
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 440);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtBookingNo);
            this.Controls.Add(this.lblBookingNo);
            this.Controls.Add(this.grpChoseCar);
            this.Controls.Add(this.grpChoseCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.grpMakeBooking);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.cboCarCategory);
            this.Name = "frmMakeBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeBooking";
            this.Load += new System.EventHandler(this.frmMakeBooking_Load);
            this.grpMakeBooking.ResumeLayout(false);
            this.grpMakeBooking.PerformLayout();
            this.grpChoseCustomer.ResumeLayout(false);
            this.grpChoseCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectCar)).EndInit();
            this.grpChoseCar.ResumeLayout(false);
            this.grpChoseCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpMakeBooking;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cboCarCategory;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.GroupBox grpChoseCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.DataGridView grdSelectCar;
        private System.Windows.Forms.GroupBox grpChoseCar;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.TextBox txtBookingNo;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtRegChosen;
        private System.Windows.Forms.Label lblRegChosen;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCostDay;
        private System.Windows.Forms.DataGridView grdTotalCost;
        private System.Windows.Forms.Label lblCustomer;
    }
}