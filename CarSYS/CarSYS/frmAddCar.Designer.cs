namespace CarSYS
{
    partial class frmAddcar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddcar));
            this.grpType = new System.Windows.Forms.GroupBox();
            this.numericUpBags = new System.Windows.Forms.NumericUpDown();
            this.lblEngSize = new System.Windows.Forms.Label();
            this.numericUpEngine = new System.Windows.Forms.NumericUpDown();
            this.lblSeats = new System.Windows.Forms.Label();
            this.numericUpDownSeats = new System.Windows.Forms.NumericUpDown();
            this.rad4door = new System.Windows.Forms.RadioButton();
            this.rad2door = new System.Windows.Forms.RadioButton();
            this.lblTransmission = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cboCarCategory = new System.Windows.Forms.ComboBox();
            this.cboTransmission = new System.Windows.Forms.ComboBox();
            this.lblNoBags = new System.Windows.Forms.Label();
            this.cboFuelType = new System.Windows.Forms.ComboBox();
            this.lblCarCategory = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.chkAddCar = new System.Windows.Forms.CheckedListBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.numericUpBags);
            this.grpType.Controls.Add(this.lblEngSize);
            this.grpType.Controls.Add(this.numericUpEngine);
            this.grpType.Controls.Add(this.lblSeats);
            this.grpType.Controls.Add(this.numericUpDownSeats);
            this.grpType.Controls.Add(this.rad4door);
            this.grpType.Controls.Add(this.rad2door);
            this.grpType.Controls.Add(this.lblTransmission);
            this.grpType.Controls.Add(this.lblFuelType);
            this.grpType.Controls.Add(this.cboCarCategory);
            this.grpType.Controls.Add(this.cboTransmission);
            this.grpType.Controls.Add(this.lblNoBags);
            this.grpType.Controls.Add(this.cboFuelType);
            this.grpType.Controls.Add(this.lblCarCategory);
            this.grpType.Controls.Add(this.lblRegNo);
            this.grpType.Controls.Add(this.txtReg);
            this.grpType.Controls.Add(this.chkAddCar);
            this.grpType.Controls.Add(this.lblModel);
            this.grpType.Controls.Add(this.txtModel);
            this.grpType.Controls.Add(this.btnAddCar);
            this.grpType.Controls.Add(this.txtMake);
            this.grpType.Controls.Add(this.lblMake);
            this.grpType.Location = new System.Drawing.Point(12, 34);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(377, 317);
            this.grpType.TabIndex = 0;
            this.grpType.TabStop = false;
            this.grpType.Text = "Enter car  details";
            // 
            // numericUpBags
            // 
            this.numericUpBags.Location = new System.Drawing.Point(268, 39);
            this.numericUpBags.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpBags.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpBags.Name = "numericUpBags";
            this.numericUpBags.Size = new System.Drawing.Size(92, 20);
            this.numericUpBags.TabIndex = 6;
            this.numericUpBags.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblEngSize
            // 
            this.lblEngSize.AutoSize = true;
            this.lblEngSize.Location = new System.Drawing.Point(202, 160);
            this.lblEngSize.Name = "lblEngSize";
            this.lblEngSize.Size = new System.Drawing.Size(63, 13);
            this.lblEngSize.TabIndex = 37;
            this.lblEngSize.Text = "Engine Size";
            // 
            // numericUpEngine
            // 
            this.numericUpEngine.DecimalPlaces = 1;
            this.numericUpEngine.Location = new System.Drawing.Point(268, 153);
            this.numericUpEngine.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpEngine.MinimumSize = new System.Drawing.Size(1, 0);
            this.numericUpEngine.Name = "numericUpEngine";
            this.numericUpEngine.Size = new System.Drawing.Size(92, 20);
            this.numericUpEngine.TabIndex = 36;
            this.numericUpEngine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(202, 126);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(54, 13);
            this.lblSeats.TabIndex = 35;
            this.lblSeats.Text = "No. Seats";
            // 
            // numericUpDownSeats
            // 
            this.numericUpDownSeats.Location = new System.Drawing.Point(268, 119);
            this.numericUpDownSeats.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeats.Name = "numericUpDownSeats";
            this.numericUpDownSeats.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownSeats.TabIndex = 9;
            this.numericUpDownSeats.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rad4door
            // 
            this.rad4door.AutoSize = true;
            this.rad4door.Location = new System.Drawing.Point(305, 78);
            this.rad4door.Name = "rad4door";
            this.rad4door.Size = new System.Drawing.Size(55, 17);
            this.rad4door.TabIndex = 8;
            this.rad4door.TabStop = true;
            this.rad4door.Text = "4-door";
            this.rad4door.UseVisualStyleBackColor = true;
            // 
            // rad2door
            // 
            this.rad2door.AutoSize = true;
            this.rad2door.Location = new System.Drawing.Point(233, 78);
            this.rad2door.Name = "rad2door";
            this.rad2door.Size = new System.Drawing.Size(55, 17);
            this.rad2door.TabIndex = 7;
            this.rad2door.TabStop = true;
            this.rad2door.Text = "2-door";
            this.rad2door.UseVisualStyleBackColor = true;
            // 
            // lblTransmission
            // 
            this.lblTransmission.AutoSize = true;
            this.lblTransmission.Location = new System.Drawing.Point(202, 225);
            this.lblTransmission.Name = "lblTransmission";
            this.lblTransmission.Size = new System.Drawing.Size(65, 13);
            this.lblTransmission.TabIndex = 31;
            this.lblTransmission.Text = "Tansmission";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(202, 199);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(54, 13);
            this.lblFuelType.TabIndex = 30;
            this.lblFuelType.Text = "Fuel Type";
            // 
            // cboCarCategory
            // 
            this.cboCarCategory.FormattingEnabled = true;
            this.cboCarCategory.Location = new System.Drawing.Point(81, 114);
            this.cboCarCategory.Name = "cboCarCategory";
            this.cboCarCategory.Size = new System.Drawing.Size(98, 21);
            this.cboCarCategory.TabIndex = 3;
            this.cboCarCategory.Text = "Category ID";
            // 
            // cboTransmission
            // 
            this.cboTransmission.FormattingEnabled = true;
            this.cboTransmission.Items.AddRange(new object[] {
            "Manual",
            "Automatic",
            "Semi Automatic",
            "Dual Clutch"});
            this.cboTransmission.Location = new System.Drawing.Point(268, 225);
            this.cboTransmission.Name = "cboTransmission";
            this.cboTransmission.Size = new System.Drawing.Size(92, 21);
            this.cboTransmission.TabIndex = 11;
            this.cboTransmission.Text = "Transmission";
            // 
            // lblNoBags
            // 
            this.lblNoBags.AutoSize = true;
            this.lblNoBags.Location = new System.Drawing.Point(202, 46);
            this.lblNoBags.Name = "lblNoBags";
            this.lblNoBags.Size = new System.Drawing.Size(51, 13);
            this.lblNoBags.TabIndex = 25;
            this.lblNoBags.Text = "No. Bags";
            // 
            // cboFuelType
            // 
            this.cboFuelType.FormattingEnabled = true;
            this.cboFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel ",
            "Electric",
            "Hybrid"});
            this.cboFuelType.Location = new System.Drawing.Point(268, 191);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(92, 21);
            this.cboFuelType.TabIndex = 10;
            this.cboFuelType.Text = "Fuel Type";
            // 
            // lblCarCategory
            // 
            this.lblCarCategory.AutoSize = true;
            this.lblCarCategory.Location = new System.Drawing.Point(12, 119);
            this.lblCarCategory.Name = "lblCarCategory";
            this.lblCarCategory.Size = new System.Drawing.Size(63, 13);
            this.lblCarCategory.TabIndex = 18;
            this.lblCarCategory.Text = "Category ID";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(12, 160);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(63, 13);
            this.lblRegNo.TabIndex = 17;
            this.lblRegNo.Text = "Registration";
            // 
            // txtReg
            // 
            this.txtReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReg.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtReg.Location = new System.Drawing.Point(81, 153);
            this.txtReg.MaxLength = 15;
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(98, 20);
            this.txtReg.TabIndex = 4;
            this.txtReg.Tag = "";
            this.txtReg.Text = "NN(N)-X(X)-NNNN";
            this.txtReg.Enter += new System.EventHandler(this.RegTextEnter);
            this.txtReg.Leave += new System.EventHandler(this.RegTextLeave);
            // 
            // chkAddCar
            // 
            this.chkAddCar.FormattingEnabled = true;
            this.chkAddCar.Items.AddRange(new object[] {
            "A/C",
            "Bluetooth",
            "Parking Sensors",
            "Reversing Camera",
            "Cruise Control"});
            this.chkAddCar.Location = new System.Drawing.Point(15, 191);
            this.chkAddCar.Name = "chkAddCar";
            this.chkAddCar.Size = new System.Drawing.Size(164, 94);
            this.chkAddCar.TabIndex = 5;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(39, 78);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 13;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(81, 75);
            this.txtModel.MaxLength = 15;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(98, 20);
            this.txtModel.TabIndex = 2;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(205, 252);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(155, 52);
            this.btnAddCar.TabIndex = 12;
            this.btnAddCar.Text = "AddCar";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(81, 39);
            this.txtMake.MaxLength = 15;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(98, 20);
            this.txtMake.TabIndex = 1;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(39, 42);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "Make";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(321, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 373);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddcar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.frmAddcar_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpBags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.CheckedListBox chkAddCar;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblCarCategory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblNoBags;
        private System.Windows.Forms.ComboBox cboFuelType;
        private System.Windows.Forms.ComboBox cboCarCategory;
        private System.Windows.Forms.ComboBox cboTransmission;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label lblTransmission;
        private System.Windows.Forms.RadioButton rad4door;
        private System.Windows.Forms.RadioButton rad2door;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.NumericUpDown numericUpDownSeats;
        private System.Windows.Forms.Label lblEngSize;
        private System.Windows.Forms.NumericUpDown numericUpEngine;
        private System.Windows.Forms.NumericUpDown numericUpBags;
    }
}