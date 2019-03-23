namespace CarSYS
{
    partial class frmReturnCar
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
            this.grpReturnCar = new System.Windows.Forms.GroupBox();
            this.btnLateReturn = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblUpdateAvailability = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblRegNO = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboReturnCar = new System.Windows.Forms.ComboBox();
            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.txtBookingStatus = new System.Windows.Forms.TextBox();
            this.lblBookedCar = new System.Windows.Forms.Label();
            this.txtStatusCar = new System.Windows.Forms.TextBox();
            this.grdTotalCost = new System.Windows.Forms.DataGridView();
            this.lblLate = new System.Windows.Forms.Label();
            this.pdReturn = new System.Windows.Forms.PrintDialog();
            this.pdtReturn = new System.Drawing.Printing.PrintDocument();
            this.grpReturnCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalCost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpReturnCar
            // 
            this.grpReturnCar.Controls.Add(this.lblLate);
            this.grpReturnCar.Controls.Add(this.grdTotalCost);
            this.grpReturnCar.Controls.Add(this.lblBookingStatus);
            this.grpReturnCar.Controls.Add(this.txtBookingStatus);
            this.grpReturnCar.Controls.Add(this.lblBookedCar);
            this.grpReturnCar.Controls.Add(this.txtStatusCar);
            this.grpReturnCar.Controls.Add(this.btnLateReturn);
            this.grpReturnCar.Controls.Add(this.txtTotal);
            this.grpReturnCar.Controls.Add(this.lblTotal);
            this.grpReturnCar.Controls.Add(this.lblStatus);
            this.grpReturnCar.Controls.Add(this.txtStatus);
            this.grpReturnCar.Controls.Add(this.txtEndDate);
            this.grpReturnCar.Controls.Add(this.lblUpdateAvailability);
            this.grpReturnCar.Controls.Add(this.lblStart);
            this.grpReturnCar.Controls.Add(this.txtStartDate);
            this.grpReturnCar.Controls.Add(this.lblRegNO);
            this.grpReturnCar.Controls.Add(this.lblCustomerID);
            this.grpReturnCar.Controls.Add(this.txtCustomerID);
            this.grpReturnCar.Controls.Add(this.txtBookingID);
            this.grpReturnCar.Controls.Add(this.lblBookingID);
            this.grpReturnCar.Controls.Add(this.txtReg);
            this.grpReturnCar.Controls.Add(this.btnReturnCar);
            this.grpReturnCar.Location = new System.Drawing.Point(12, 69);
            this.grpReturnCar.Name = "grpReturnCar";
            this.grpReturnCar.Size = new System.Drawing.Size(429, 263);
            this.grpReturnCar.TabIndex = 22;
            this.grpReturnCar.TabStop = false;
            this.grpReturnCar.Text = "Return Car";
            // 
            // btnLateReturn
            // 
            this.btnLateReturn.Location = new System.Drawing.Point(11, 217);
            this.btnLateReturn.Name = "btnLateReturn";
            this.btnLateReturn.Size = new System.Drawing.Size(197, 40);
            this.btnLateReturn.TabIndex = 74;
            this.btnLateReturn.Text = "Late Return";
            this.btnLateReturn.UseVisualStyleBackColor = true;
            this.btnLateReturn.Click += new System.EventHandler(this.btnLateReturn_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(315, 52);
            this.txtTotal.MaxLength = 12;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 68;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(216, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "Total";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 66;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(105, 104);
            this.txtStatus.MaxLength = 12;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(103, 20);
            this.txtStatus.TabIndex = 65;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(315, 78);
            this.txtEndDate.MaxLength = 12;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(103, 20);
            this.txtEndDate.TabIndex = 64;
            // 
            // lblUpdateAvailability
            // 
            this.lblUpdateAvailability.AutoSize = true;
            this.lblUpdateAvailability.Location = new System.Drawing.Point(216, 78);
            this.lblUpdateAvailability.Name = "lblUpdateAvailability";
            this.lblUpdateAvailability.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateAvailability.TabIndex = 63;
            this.lblUpdateAvailability.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(8, 78);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 62;
            this.lblStart.Text = "Start Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(105, 78);
            this.txtStartDate.MaxLength = 12;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(103, 20);
            this.txtStartDate.TabIndex = 61;
            // 
            // lblRegNO
            // 
            this.lblRegNO.AutoSize = true;
            this.lblRegNO.Location = new System.Drawing.Point(8, 52);
            this.lblRegNO.Name = "lblRegNO";
            this.lblRegNO.Size = new System.Drawing.Size(63, 13);
            this.lblRegNO.TabIndex = 60;
            this.lblRegNO.Text = "Registration";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(218, 26);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerID.TabIndex = 58;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(315, 26);
            this.txtCustomerID.MaxLength = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(103, 20);
            this.txtCustomerID.TabIndex = 57;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(105, 26);
            this.txtBookingID.MaxLength = 12;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(103, 20);
            this.txtBookingID.TabIndex = 56;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(8, 26);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 55;
            this.lblBookingID.Text = "Booking ID";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(105, 52);
            this.txtReg.MaxLength = 12;
            this.txtReg.Name = "txtReg";
            this.txtReg.ReadOnly = true;
            this.txtReg.Size = new System.Drawing.Size(103, 20);
            this.txtReg.TabIndex = 59;
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(221, 217);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(197, 40);
            this.btnReturnCar.TabIndex = 20;
            this.btnReturnCar.Text = "ReturnCar";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Booking ID";
            // 
            // cboReturnCar
            // 
            this.cboReturnCar.FormattingEnabled = true;
            this.cboReturnCar.Location = new System.Drawing.Point(117, 42);
            this.cboReturnCar.Name = "cboReturnCar";
            this.cboReturnCar.Size = new System.Drawing.Size(121, 21);
            this.cboReturnCar.TabIndex = 54;
            this.cboReturnCar.SelectedIndexChanged += new System.EventHandler(this.cboReturnCar_SelectedIndexChanged);
            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.AutoSize = true;
            this.lblBookingStatus.Location = new System.Drawing.Point(8, 137);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(79, 13);
            this.lblBookingStatus.TabIndex = 78;
            this.lblBookingStatus.Text = "Booking Status";
            // 
            // txtBookingStatus
            // 
            this.txtBookingStatus.Location = new System.Drawing.Point(105, 130);
            this.txtBookingStatus.MaxLength = 12;
            this.txtBookingStatus.Name = "txtBookingStatus";
            this.txtBookingStatus.ReadOnly = true;
            this.txtBookingStatus.Size = new System.Drawing.Size(103, 20);
            this.txtBookingStatus.TabIndex = 77;
            this.txtBookingStatus.Text = "R";
            // 
            // lblBookedCar
            // 
            this.lblBookedCar.AutoSize = true;
            this.lblBookedCar.Location = new System.Drawing.Point(218, 110);
            this.lblBookedCar.Name = "lblBookedCar";
            this.lblBookedCar.Size = new System.Drawing.Size(56, 13);
            this.lblBookedCar.TabIndex = 76;
            this.lblBookedCar.Text = "Car Status";
            // 
            // txtStatusCar
            // 
            this.txtStatusCar.Location = new System.Drawing.Point(315, 107);
            this.txtStatusCar.MaxLength = 12;
            this.txtStatusCar.Name = "txtStatusCar";
            this.txtStatusCar.ReadOnly = true;
            this.txtStatusCar.Size = new System.Drawing.Size(103, 20);
            this.txtStatusCar.TabIndex = 75;
            this.txtStatusCar.Text = "A";
            // 
            // grdTotalCost
            // 
            this.grdTotalCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotalCost.Location = new System.Drawing.Point(293, 130);
            this.grdTotalCost.Name = "grdTotalCost";
            this.grdTotalCost.Size = new System.Drawing.Size(125, 81);
            this.grdTotalCost.TabIndex = 79;
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(197, 153);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(90, 13);
            this.lblLate.TabIndex = 80;
            this.lblLate.Text = "Total and late fee";
            // 
            // pdReturn
            // 
            this.pdReturn.UseEXDialog = true;
            // 
            // pdtReturn
            // 
            this.pdtReturn.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdtReturn_PrintPage);
            // 
            // frmReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpReturnCar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboReturnCar);
            this.Name = "frmReturnCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturnCar";
            this.Load += new System.EventHandler(this.frmReturnCar_Load);
            this.grpReturnCar.ResumeLayout(false);
            this.grpReturnCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpReturnCar;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblUpdateAvailability;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblRegNO;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboReturnCar;
        private System.Windows.Forms.Button btnLateReturn;
        private System.Windows.Forms.Label lblBookingStatus;
        private System.Windows.Forms.TextBox txtBookingStatus;
        private System.Windows.Forms.Label lblBookedCar;
        private System.Windows.Forms.TextBox txtStatusCar;
        private System.Windows.Forms.DataGridView grdTotalCost;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.PrintDialog pdReturn;
        private System.Drawing.Printing.PrintDocument pdtReturn;
    }
}