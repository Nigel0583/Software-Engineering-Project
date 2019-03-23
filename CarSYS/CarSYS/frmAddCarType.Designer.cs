namespace CarSYS
{
    partial class frmAddCarType
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
            this.grpType = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.numericUpRate = new System.Windows.Forms.NumericUpDown();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpRate)).BeginInit();
            this.SuspendLayout();
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.numericUpRate);
            this.grpType.Controls.Add(this.btnAdd);
            this.grpType.Controls.Add(this.label4);
            this.grpType.Controls.Add(this.txtDesc);
            this.grpType.Controls.Add(this.label5);
            this.grpType.Controls.Add(this.txtCarType);
            this.grpType.Controls.Add(this.label6);
            this.grpType.Location = new System.Drawing.Point(12, 66);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(267, 293);
            this.grpType.TabIndex = 8;
            this.grpType.TabStop = false;
            this.grpType.Text = "Enter car type details";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 52);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "AddCarType";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_CLick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rate";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(95, 68);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(140, 59);
            this.txtDesc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripion";
            // 
            // txtCarType
            // 
            this.txtCarType.Location = new System.Drawing.Point(95, 25);
            this.txtCarType.MaxLength = 3;
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(50, 20);
            this.txtCarType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Category ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numericUpRate
            // 
            this.numericUpRate.DecimalPlaces = 1;
            this.numericUpRate.Location = new System.Drawing.Point(85, 154);
            this.numericUpRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpRate.MinimumSize = new System.Drawing.Size(1, 0);
            this.numericUpRate.Name = "numericUpRate";
            this.numericUpRate.Size = new System.Drawing.Size(92, 20);
            this.numericUpRate.TabIndex = 37;
            this.numericUpRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // frmAddCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 392);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpType);
            this.Name = "frmAddCarType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarType";
            this.Load += new System.EventHandler(this.frmAddCarType_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numericUpRate;
    }
}