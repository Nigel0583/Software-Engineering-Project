namespace CarSYS
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.lblLate = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lstCompany = new System.Windows.Forms.ListBox();
            this.tlpEmail = new System.Windows.Forms.TableLayoutPanel();
            this.lblLi = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEm = new System.Windows.Forms.Label();
            this.lblBookNum = new System.Windows.Forms.Label();
            this.lblBookNo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRental = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDayCost = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.tlpProduct = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tlpDates = new System.Windows.Forms.TableLayoutPanel();
            this.txtStart = new System.Windows.Forms.MaskedTextBox();
            this.txtReg = new System.Windows.Forms.MaskedTextBox();
            this.txtToday = new System.Windows.Forms.MaskedTextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.MaskedTextBox();
            this.tlpAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblBillTo = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.tlpInvoice1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pdInvoice = new System.Drawing.Printing.PrintDocument();
            this.ppdInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.pdiaInvoice = new System.Windows.Forms.PrintDialog();
            this.panelInvoice.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tlpEmail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpProduct.SuspendLayout();
            this.tlpDates.SuspendLayout();
            this.tlpAddress.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.tlpInvoice1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInvoice
            // 
            this.panelInvoice.Controls.Add(this.lblLate);
            this.panelInvoice.Controls.Add(this.tableLayoutPanel4);
            this.panelInvoice.Controls.Add(this.tableLayoutPanel3);
            this.panelInvoice.Controls.Add(this.tlpEmail);
            this.panelInvoice.Controls.Add(this.tableLayoutPanel2);
            this.panelInvoice.Controls.Add(this.tlpProduct);
            this.panelInvoice.Controls.Add(this.tlpDates);
            this.panelInvoice.Controls.Add(this.tlpAddress);
            this.panelInvoice.Controls.Add(this.tlpInfo);
            this.panelInvoice.Controls.Add(this.tlpInvoice1);
            this.panelInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInvoice.Location = new System.Drawing.Point(0, 0);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.Size = new System.Drawing.Size(800, 552);
            this.panelInvoice.TabIndex = 0;
            // 
            // lblLate
            // 
            this.lblLate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLate.AutoSize = true;
            this.lblLate.BackColor = System.Drawing.Color.White;
            this.lblLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblLate.Location = new System.Drawing.Point(16, 516);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(173, 13);
            this.lblLate.TabIndex = 10;
            this.lblLate.Text = "*Late returns are charged a late fee";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5F));
            this.tableLayoutPanel4.Controls.Add(this.lblSur, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFirst, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(397, 143);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(400, 26);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblSur
            // 
            this.lblSur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSur.AutoSize = true;
            this.lblSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSur.Location = new System.Drawing.Point(129, 3);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(268, 20);
            this.lblSur.TabIndex = 4;
            this.lblSur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirst
            // 
            this.lblFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirst.Location = new System.Drawing.Point(3, 3);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(120, 20);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lstCompany, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 143);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(399, 149);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lstCompany
            // 
            this.lstCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstCompany.FormattingEnabled = true;
            this.lstCompany.ItemHeight = 20;
            this.lstCompany.Items.AddRange(new object[] {
            "Express Car Rental",
            "Carroll\'s Quay ",
            "Shandon",
            "Cork",
            "Ireland"});
            this.lstCompany.Location = new System.Drawing.Point(20, 4);
            this.lstCompany.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lstCompany.Name = "lstCompany";
            this.lstCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstCompany.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCompany.Size = new System.Drawing.Size(376, 140);
            this.lstCompany.TabIndex = 0;
            // 
            // tlpEmail
            // 
            this.tlpEmail.ColumnCount = 2;
            this.tlpEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEmail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpEmail.Controls.Add(this.lblLi, 1, 0);
            this.tlpEmail.Controls.Add(this.lblLicence, 0, 0);
            this.tlpEmail.Controls.Add(this.lblEmail, 0, 1);
            this.tlpEmail.Controls.Add(this.lblEm, 1, 1);
            this.tlpEmail.Controls.Add(this.lblBookNum, 1, 2);
            this.tlpEmail.Controls.Add(this.lblBookNo, 0, 2);
            this.tlpEmail.Location = new System.Drawing.Point(515, 0);
            this.tlpEmail.Name = "tlpEmail";
            this.tlpEmail.RowCount = 3;
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpEmail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEmail.Size = new System.Drawing.Size(285, 110);
            this.tlpEmail.TabIndex = 8;
            // 
            // lblLi
            // 
            this.lblLi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLi.AutoSize = true;
            this.lblLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLi.Location = new System.Drawing.Point(74, 10);
            this.lblLi.Name = "lblLi";
            this.lblLi.Size = new System.Drawing.Size(208, 15);
            this.lblLi.TabIndex = 2;
            this.lblLi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLicence
            // 
            this.lblLicence.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLicence.AutoSize = true;
            this.lblLicence.BackColor = System.Drawing.Color.White;
            this.lblLicence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLicence.Location = new System.Drawing.Point(4, 8);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(64, 20);
            this.lblLicence.TabIndex = 0;
            this.lblLicence.Text = "Licence";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(20, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblEm
            // 
            this.lblEm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEm.AutoSize = true;
            this.lblEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEm.Location = new System.Drawing.Point(74, 46);
            this.lblEm.Name = "lblEm";
            this.lblEm.Size = new System.Drawing.Size(208, 15);
            this.lblEm.TabIndex = 7;
            this.lblEm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookNum
            // 
            this.lblBookNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookNum.AutoSize = true;
            this.lblBookNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBookNum.Location = new System.Drawing.Point(74, 83);
            this.lblBookNum.Name = "lblBookNum";
            this.lblBookNum.Size = new System.Drawing.Size(208, 15);
            this.lblBookNum.TabIndex = 9;
            this.lblBookNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookNo
            // 
            this.lblBookNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookNo.AutoSize = true;
            this.lblBookNo.BackColor = System.Drawing.Color.White;
            this.lblBookNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBookNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookNo.Location = new System.Drawing.Point(22, 81);
            this.lblBookNo.Name = "lblBookNo";
            this.lblBookNo.Size = new System.Drawing.Size(46, 20);
            this.lblBookNo.TabIndex = 8;
            this.lblBookNo.Text = "Book";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.99496F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.00504F));
            this.tableLayoutPanel2.Controls.Add(this.lblRental, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDayCost, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTot, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 98);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblRental
            // 
            this.lblRental.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRental.AutoSize = true;
            this.lblRental.BackColor = System.Drawing.Color.White;
            this.lblRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRental.Location = new System.Drawing.Point(404, 14);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(116, 20);
            this.lblRental.TabIndex = 4;
            this.lblRental.Text = "Rental per day:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(472, 63);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblDayCost
            // 
            this.lblDayCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDayCost.AutoSize = true;
            this.lblDayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDayCost.Location = new System.Drawing.Point(526, 14);
            this.lblDayCost.Name = "lblDayCost";
            this.lblDayCost.Size = new System.Drawing.Size(265, 20);
            this.lblDayCost.TabIndex = 7;
            this.lblDayCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTot
            // 
            this.lblTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTot.Location = new System.Drawing.Point(526, 63);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(265, 20);
            this.lblTot.TabIndex = 8;
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpProduct
            // 
            this.tlpProduct.ColumnCount = 1;
            this.tlpProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpProduct.Controls.Add(this.lblPrice, 0, 0);
            this.tlpProduct.Location = new System.Drawing.Point(0, 365);
            this.tlpProduct.Name = "tlpProduct";
            this.tlpProduct.RowCount = 1;
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpProduct.Size = new System.Drawing.Size(800, 44);
            this.tlpProduct.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.Location = new System.Drawing.Point(3, 12);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(794, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // tlpDates
            // 
            this.tlpDates.ColumnCount = 4;
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDates.Controls.Add(this.txtStart, 0, 1);
            this.tlpDates.Controls.Add(this.txtReg, 0, 1);
            this.tlpDates.Controls.Add(this.txtToday, 0, 1);
            this.tlpDates.Controls.Add(this.lblEndDate, 3, 0);
            this.tlpDates.Controls.Add(this.lblStart, 2, 0);
            this.tlpDates.Controls.Add(this.lblDate, 1, 0);
            this.tlpDates.Controls.Add(this.lblCarReg, 0, 0);
            this.tlpDates.Controls.Add(this.txtEnd, 2, 1);
            this.tlpDates.Location = new System.Drawing.Point(0, 293);
            this.tlpDates.Name = "tlpDates";
            this.tlpDates.RowCount = 2;
            this.tlpDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpDates.Size = new System.Drawing.Size(800, 66);
            this.tlpDates.TabIndex = 4;
            // 
            // txtStart
            // 
            this.txtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart.BackColor = System.Drawing.Color.White;
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStart.Location = new System.Drawing.Point(403, 35);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(194, 19);
            this.txtStart.TabIndex = 8;
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReg
            // 
            this.txtReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReg.BackColor = System.Drawing.Color.White;
            this.txtReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtReg.Location = new System.Drawing.Point(3, 35);
            this.txtReg.Name = "txtReg";
            this.txtReg.ReadOnly = true;
            this.txtReg.Size = new System.Drawing.Size(194, 19);
            this.txtReg.TabIndex = 7;
            this.txtReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToday
            // 
            this.txtToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToday.BackColor = System.Drawing.Color.White;
            this.txtToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtToday.Location = new System.Drawing.Point(203, 35);
            this.txtToday.Name = "txtToday";
            this.txtToday.ReadOnly = true;
            this.txtToday.Size = new System.Drawing.Size(194, 19);
            this.txtToday.TabIndex = 5;
            this.txtToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(603, 2);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(194, 20);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStart.Location = new System.Drawing.Point(403, 2);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(194, 20);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start Date";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.Location = new System.Drawing.Point(203, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(194, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Invoice Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarReg
            // 
            this.lblCarReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCarReg.Location = new System.Drawing.Point(3, 2);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(194, 20);
            this.lblCarReg.TabIndex = 1;
            this.lblCarReg.Text = "Registration";
            this.lblCarReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.BackColor = System.Drawing.Color.White;
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEnd.Location = new System.Drawing.Point(603, 35);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.ReadOnly = true;
            this.txtEnd.Size = new System.Drawing.Size(194, 19);
            this.txtEnd.TabIndex = 6;
            this.txtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpAddress
            // 
            this.tlpAddress.ColumnCount = 1;
            this.tlpAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Controls.Add(this.lblPhone, 0, 5);
            this.tlpAddress.Controls.Add(this.lblPost, 0, 4);
            this.tlpAddress.Controls.Add(this.lblCountry, 0, 4);
            this.tlpAddress.Controls.Add(this.lblAdd, 0, 0);
            this.tlpAddress.Location = new System.Drawing.Point(403, 175);
            this.tlpAddress.Name = "tlpAddress";
            this.tlpAddress.RowCount = 6;
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAddress.Size = new System.Drawing.Size(397, 117);
            this.tlpAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhone.Location = new System.Drawing.Point(3, 78);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(391, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPost
            // 
            this.lblPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPost.AutoSize = true;
            this.lblPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPost.Location = new System.Drawing.Point(3, 40);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(391, 20);
            this.lblPost.TabIndex = 5;
            this.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCountry.Location = new System.Drawing.Point(3, 20);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(391, 20);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdd
            // 
            this.lblAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdd.Location = new System.Drawing.Point(3, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(391, 20);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Controls.Add(this.lblBillTo, 1, 0);
            this.tlpInfo.Controls.Add(this.lblCompany, 0, 0);
            this.tlpInfo.Location = new System.Drawing.Point(0, 109);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 1;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Size = new System.Drawing.Size(800, 28);
            this.tlpInfo.TabIndex = 1;
            // 
            // lblBillTo
            // 
            this.lblBillTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillTo.AutoSize = true;
            this.lblBillTo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblBillTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBillTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBillTo.Location = new System.Drawing.Point(403, 4);
            this.lblBillTo.Name = "lblBillTo";
            this.lblBillTo.Size = new System.Drawing.Size(394, 20);
            this.lblBillTo.TabIndex = 1;
            this.lblBillTo.Text = "Bill To:";
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompany.Location = new System.Drawing.Point(3, 4);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(394, 20);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company:";
            // 
            // tlpInvoice1
            // 
            this.tlpInvoice1.AccessibleName = "";
            this.tlpInvoice1.ColumnCount = 2;
            this.tlpInvoice1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInvoice1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInvoice1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInvoice1.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpInvoice1.Controls.Add(this.lblInvoice, 1, 0);
            this.tlpInvoice1.Location = new System.Drawing.Point(0, 3);
            this.tlpInvoice1.Name = "tlpInvoice1";
            this.tlpInvoice1.RowCount = 1;
            this.tlpInvoice1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInvoice1.Size = new System.Drawing.Size(522, 100);
            this.tlpInvoice1.TabIndex = 0;
            this.tlpInvoice1.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 48);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblInvoice
            // 
            this.lblInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.BackColor = System.Drawing.Color.White;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblInvoice.Location = new System.Drawing.Point(264, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(255, 100);
            this.lblInvoice.TabIndex = 1;
            this.lblInvoice.Text = "INVOICE";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(705, 571);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pdInvoice
            // 
            this.pdInvoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdtInvoice_PrintPage);
            // 
            // ppdInvoice
            // 
            this.ppdInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdInvoice.Enabled = true;
            this.ppdInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdInvoice.Icon")));
            this.ppdInvoice.Name = "ppdInvoic";
            this.ppdInvoice.ShowIcon = false;
            this.ppdInvoice.UseAntiAlias = true;
            this.ppdInvoice.Visible = false;
            // 
            // pdiaInvoice
            // 
            this.pdiaInvoice.UseEXDialog = true;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelInvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.panelInvoice.ResumeLayout(false);
            this.panelInvoice.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tlpEmail.ResumeLayout(false);
            this.tlpEmail.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpProduct.ResumeLayout(false);
            this.tlpProduct.PerformLayout();
            this.tlpDates.ResumeLayout(false);
            this.tlpDates.PerformLayout();
            this.tlpAddress.ResumeLayout(false);
            this.tlpAddress.PerformLayout();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tlpInvoice1.ResumeLayout(false);
            this.tlpInvoice1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInvoice;
        private System.Windows.Forms.TableLayoutPanel tlpProduct;
        private System.Windows.Forms.TableLayoutPanel tlpDates;
        private System.Windows.Forms.TableLayoutPanel tlpAddress;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInvoice1;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument pdInvoice;
        private System.Windows.Forms.PrintPreviewDialog ppdInvoice;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblBillTo;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstCompany;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox txtStart;
        private System.Windows.Forms.MaskedTextBox txtReg;
        private System.Windows.Forms.MaskedTextBox txtToday;
        private System.Windows.Forms.MaskedTextBox txtEnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TableLayoutPanel tlpEmail;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.Label lblLi;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDayCost;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblBookNum;
        private System.Windows.Forms.Label lblBookNo;
        private System.Windows.Forms.PrintDialog pdiaInvoice;
    }
}