namespace CarSYS
{
    partial class frmCancelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelBooking));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.grpCancelBooking = new System.Windows.Forms.GroupBox();
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
            this.cboCancelBooking = new System.Windows.Forms.ComboBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.grpCancelBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(195, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(21, 218);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(197, 34);
            this.btnCancelBooking.TabIndex = 9;
            this.btnCancelBooking.Text = "Cancel Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // grpCancelBooking
            // 
            this.grpCancelBooking.Controls.Add(this.txtTotal);
            this.grpCancelBooking.Controls.Add(this.lblTotal);
            this.grpCancelBooking.Controls.Add(this.lblStatus);
            this.grpCancelBooking.Controls.Add(this.txtStatus);
            this.grpCancelBooking.Controls.Add(this.txtEndDate);
            this.grpCancelBooking.Controls.Add(this.lblUpdateAvailability);
            this.grpCancelBooking.Controls.Add(this.btnCancelBooking);
            this.grpCancelBooking.Controls.Add(this.lblStart);
            this.grpCancelBooking.Controls.Add(this.txtStartDate);
            this.grpCancelBooking.Controls.Add(this.lblRegNO);
            this.grpCancelBooking.Controls.Add(this.txtReg);
            this.grpCancelBooking.Controls.Add(this.lblCustomerID);
            this.grpCancelBooking.Controls.Add(this.txtCustomerID);
            this.grpCancelBooking.Controls.Add(this.txtBookingID);
            this.grpCancelBooking.Controls.Add(this.lblBookingID);
            this.grpCancelBooking.Location = new System.Drawing.Point(12, 84);
            this.grpCancelBooking.Name = "grpCancelBooking";
            this.grpCancelBooking.Size = new System.Drawing.Size(248, 277);
            this.grpCancelBooking.TabIndex = 11;
            this.grpCancelBooking.TabStop = false;
            this.grpCancelBooking.Text = "Cancel Booking";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(115, 179);
            this.txtTotal.MaxLength = 12;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(16, 153);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(115, 153);
            this.txtStatus.MaxLength = 12;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(103, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(115, 129);
            this.txtEndDate.MaxLength = 12;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(103, 20);
            this.txtEndDate.TabIndex = 6;
            // 
            // lblUpdateAvailability
            // 
            this.lblUpdateAvailability.AutoSize = true;
            this.lblUpdateAvailability.Location = new System.Drawing.Point(16, 129);
            this.lblUpdateAvailability.Name = "lblUpdateAvailability";
            this.lblUpdateAvailability.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateAvailability.TabIndex = 30;
            this.lblUpdateAvailability.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(16, 103);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 29;
            this.lblStart.Text = "Start Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(115, 103);
            this.txtStartDate.MaxLength = 12;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(103, 20);
            this.txtStartDate.TabIndex = 5;
            // 
            // lblRegNO
            // 
            this.lblRegNO.AutoSize = true;
            this.lblRegNO.Location = new System.Drawing.Point(18, 77);
            this.lblRegNO.Name = "lblRegNO";
            this.lblRegNO.Size = new System.Drawing.Size(63, 13);
            this.lblRegNO.TabIndex = 27;
            this.lblRegNO.Text = "Registration";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(115, 77);
            this.txtReg.MaxLength = 12;
            this.txtReg.Name = "txtReg";
            this.txtReg.ReadOnly = true;
            this.txtReg.Size = new System.Drawing.Size(103, 20);
            this.txtReg.TabIndex = 4;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(18, 51);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
            this.lblCustomerID.TabIndex = 25;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(115, 51);
            this.txtCustomerID.MaxLength = 12;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(103, 20);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(115, 25);
            this.txtBookingID.MaxLength = 12;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.Size = new System.Drawing.Size(103, 20);
            this.txtBookingID.TabIndex = 2;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(18, 25);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 22;
            this.lblBookingID.Text = "Booking ID";
            // 
            // cboCancelBooking
            // 
            this.cboCancelBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCancelBooking.FormattingEnabled = true;
            this.cboCancelBooking.Location = new System.Drawing.Point(78, 57);
            this.cboCancelBooking.Name = "cboCancelBooking";
            this.cboCancelBooking.Size = new System.Drawing.Size(182, 21);
            this.cboCancelBooking.TabIndex = 1;
            this.cboCancelBooking.SelectedIndexChanged += new System.EventHandler(this.cboRemoveCar_SelectedIndexChanged);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Location = new System.Drawing.Point(9, 57);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(66, 13);
            this.lblBooking.TabIndex = 22;
            this.lblBooking.Text = "Booking No.";
            // 
            // frmCancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 373);
            this.Controls.Add(this.grpCancelBooking);
            this.Controls.Add(this.cboCancelBooking);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCancelBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Booking";
            this.Load += new System.EventHandler(this.frmCancelBooking_Load);
            this.grpCancelBooking.ResumeLayout(false);
            this.grpCancelBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.GroupBox grpCancelBooking;
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
        private System.Windows.Forms.ComboBox cboCancelBooking;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}