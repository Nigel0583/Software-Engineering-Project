namespace CarSYS
{
    partial class frmCollectCar
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
            this.grpCollectCar = new System.Windows.Forms.GroupBox();
            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.txtBookingStatus = new System.Windows.Forms.TextBox();
            this.lblBookedCar = new System.Windows.Forms.Label();
            this.txtStatusCar = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblUpdateAvailability = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblRegNO = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnCollectCar = new System.Windows.Forms.Button();
            this.cboCollectCar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCollectCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(447, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpCollectCar
            // 
            this.grpCollectCar.Controls.Add(this.lblBookingStatus);
            this.grpCollectCar.Controls.Add(this.txtBookingStatus);
            this.grpCollectCar.Controls.Add(this.lblBookedCar);
            this.grpCollectCar.Controls.Add(this.txtStatusCar);
            this.grpCollectCar.Controls.Add(this.txtTotal);
            this.grpCollectCar.Controls.Add(this.lblTotal);
            this.grpCollectCar.Controls.Add(this.lblStatus);
            this.grpCollectCar.Controls.Add(this.txtStatus);
            this.grpCollectCar.Controls.Add(this.txtEndDate);
            this.grpCollectCar.Controls.Add(this.lblUpdateAvailability);
            this.grpCollectCar.Controls.Add(this.lblStart);
            this.grpCollectCar.Controls.Add(this.txtStartDate);
            this.grpCollectCar.Controls.Add(this.lblRegNO);
            this.grpCollectCar.Controls.Add(this.txtReg);
            this.grpCollectCar.Controls.Add(this.lblCustomerID);
            this.grpCollectCar.Controls.Add(this.txtCustomerID);
            this.grpCollectCar.Controls.Add(this.txtBookingID);
            this.grpCollectCar.Controls.Add(this.lblBookingID);
            this.grpCollectCar.Controls.Add(this.btnCollectCar);
            this.grpCollectCar.Location = new System.Drawing.Point(26, 89);
            this.grpCollectCar.Name = "grpCollectCar";
            this.grpCollectCar.Size = new System.Drawing.Size(485, 209);
            this.grpCollectCar.TabIndex = 23;
            this.grpCollectCar.TabStop = false;
            this.grpCollectCar.Text = "Collect Car";
            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.AutoSize = true;
            this.lblBookingStatus.Location = new System.Drawing.Point(20, 138);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(79, 13);
            this.lblBookingStatus.TabIndex = 53;
            this.lblBookingStatus.Text = "Booking Status";
            // 
            // txtBookingStatus
            // 
            this.txtBookingStatus.Location = new System.Drawing.Point(117, 131);
            this.txtBookingStatus.MaxLength = 12;
            this.txtBookingStatus.Name = "txtBookingStatus";
            this.txtBookingStatus.ReadOnly = true;
            this.txtBookingStatus.Size = new System.Drawing.Size(103, 20);
            this.txtBookingStatus.TabIndex = 6;
            this.txtBookingStatus.Text = "O";
            // 
            // lblBookedCar
            // 
            this.lblBookedCar.AutoSize = true;
            this.lblBookedCar.Location = new System.Drawing.Point(230, 111);
            this.lblBookedCar.Name = "lblBookedCar";
            this.lblBookedCar.Size = new System.Drawing.Size(56, 13);
            this.lblBookedCar.TabIndex = 51;
            this.lblBookedCar.Text = "Car Status";
            // 
            // txtStatusCar
            // 
            this.txtStatusCar.Location = new System.Drawing.Point(327, 108);
            this.txtStatusCar.MaxLength = 12;
            this.txtStatusCar.Name = "txtStatusCar";
            this.txtStatusCar.ReadOnly = true;
            this.txtStatusCar.Size = new System.Drawing.Size(103, 20);
            this.txtStatusCar.TabIndex = 10;
            this.txtStatusCar.Text = "O";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(327, 53);
            this.txtTotal.MaxLength = 12;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(228, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Total";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 108);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(117, 105);
            this.txtStatus.MaxLength = 12;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(103, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(327, 79);
            this.txtEndDate.MaxLength = 12;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(103, 20);
            this.txtEndDate.TabIndex = 9;
            // 
            // lblUpdateAvailability
            // 
            this.lblUpdateAvailability.AutoSize = true;
            this.lblUpdateAvailability.Location = new System.Drawing.Point(228, 79);
            this.lblUpdateAvailability.Name = "lblUpdateAvailability";
            this.lblUpdateAvailability.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateAvailability.TabIndex = 44;
            this.lblUpdateAvailability.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(20, 79);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 43;
            this.lblStart.Text = "Start Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(117, 79);
            this.txtStartDate.MaxLength = 12;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(103, 20);
            this.txtStartDate.TabIndex = 4;
            // 
            // lblRegNO
            // 
            this.lblRegNO.AutoSize = true;
            this.lblRegNO.Location = new System.Drawing.Point(20, 53);
            this.lblRegNO.Name = "lblRegNO";
            this.lblRegNO.Size = new System.Drawing.Size(63, 13);
            this.lblRegNO.TabIndex = 41;
            this.lblRegNO.Text = "Registration";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(117, 53);
            this.txtReg.MaxLength = 12;
            this.txtReg.Name = "txtReg";
            this.txtReg.ReadOnly = true;
            this.txtReg.Size = new System.Drawing.Size(103, 20);
            this.txtReg.TabIndex = 3;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(230, 27);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerID.TabIndex = 39;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(327, 27);
            this.txtCustomerID.MaxLength = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(103, 20);
            this.txtCustomerID.TabIndex = 7;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(117, 27);
            this.txtBookingID.MaxLength = 12;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(103, 20);
            this.txtBookingID.TabIndex = 2;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(20, 27);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 36;
            this.lblBookingID.Text = "Booking ID";
            // 
            // btnCollectCar
            // 
            this.btnCollectCar.Location = new System.Drawing.Point(233, 138);
            this.btnCollectCar.Name = "btnCollectCar";
            this.btnCollectCar.Size = new System.Drawing.Size(197, 52);
            this.btnCollectCar.TabIndex = 11;
            this.btnCollectCar.Text = "Collect Car";
            this.btnCollectCar.UseVisualStyleBackColor = true;
            this.btnCollectCar.Click += new System.EventHandler(this.btnCollectCar_Click);
            // 
            // cboCollectCar
            // 
            this.cboCollectCar.FormattingEnabled = true;
            this.cboCollectCar.Location = new System.Drawing.Point(112, 42);
            this.cboCollectCar.Name = "cboCollectCar";
            this.cboCollectCar.Size = new System.Drawing.Size(121, 21);
            this.cboCollectCar.TabIndex = 1;
            this.cboCollectCar.SelectedIndexChanged += new System.EventHandler(this.cboCollectCar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Booking ID";
            // 
            // frmCollectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCollectCar);
            this.Controls.Add(this.grpCollectCar);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCollectCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCollectCar";
            this.Load += new System.EventHandler(this.frmCollectCar_Load);
            this.grpCollectCar.ResumeLayout(false);
            this.grpCollectCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpCollectCar;
        private System.Windows.Forms.Button btnCollectCar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblUpdateAvailability;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblRegNO;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.ComboBox cboCollectCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookedCar;
        private System.Windows.Forms.TextBox txtStatusCar;
        private System.Windows.Forms.Label lblBookingStatus;
        private System.Windows.Forms.TextBox txtBookingStatus;
    }
}