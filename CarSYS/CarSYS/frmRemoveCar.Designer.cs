namespace CarSYS
{
    partial class frmRemove
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
            this.lblRegNo = new System.Windows.Forms.Label();
            this.grpRemoveCar = new System.Windows.Forms.GroupBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateAvailability = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.txtCurrentAvailability = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboRemoveCar = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpRemoveCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(9, 59);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(63, 13);
            this.lblRegNo.TabIndex = 19;
            this.lblRegNo.Text = "Registration";
            // 
            // grpRemoveCar
            // 
            this.grpRemoveCar.Controls.Add(this.txtUpdate);
            this.grpRemoveCar.Controls.Add(this.lblUpdateAvailability);
            this.grpRemoveCar.Controls.Add(this.lblAvailability);
            this.grpRemoveCar.Controls.Add(this.txtCurrentAvailability);
            this.grpRemoveCar.Controls.Add(this.label1);
            this.grpRemoveCar.Controls.Add(this.txtReg);
            this.grpRemoveCar.Controls.Add(this.lblModel);
            this.grpRemoveCar.Controls.Add(this.txtModel);
            this.grpRemoveCar.Controls.Add(this.txtMake);
            this.grpRemoveCar.Controls.Add(this.lblMake);
            this.grpRemoveCar.Controls.Add(this.btnRemove);
            this.grpRemoveCar.Location = new System.Drawing.Point(12, 96);
            this.grpRemoveCar.Name = "grpRemoveCar";
            this.grpRemoveCar.Size = new System.Drawing.Size(248, 263);
            this.grpRemoveCar.TabIndex = 20;
            this.grpRemoveCar.TabStop = false;
            this.grpRemoveCar.Text = "RemoveCar";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(115, 129);
            this.txtUpdate.MaxLength = 12;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(103, 20);
            this.txtUpdate.TabIndex = 2;
            this.txtUpdate.Text = "R";
            // 
            // lblUpdateAvailability
            // 
            this.lblUpdateAvailability.AutoSize = true;
            this.lblUpdateAvailability.Location = new System.Drawing.Point(16, 129);
            this.lblUpdateAvailability.Name = "lblUpdateAvailability";
            this.lblUpdateAvailability.Size = new System.Drawing.Size(100, 13);
            this.lblUpdateAvailability.TabIndex = 30;
            this.lblUpdateAvailability.Text = "Updated Availability";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(16, 103);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(93, 13);
            this.lblAvailability.TabIndex = 29;
            this.lblAvailability.Text = "Current Availability";
            // 
            // txtCurrentAvailability
            // 
            this.txtCurrentAvailability.Location = new System.Drawing.Point(115, 103);
            this.txtCurrentAvailability.MaxLength = 12;
            this.txtCurrentAvailability.Name = "txtCurrentAvailability";
            this.txtCurrentAvailability.ReadOnly = true;
            this.txtCurrentAvailability.Size = new System.Drawing.Size(103, 20);
            this.txtCurrentAvailability.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Registration";
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(115, 77);
            this.txtReg.MaxLength = 12;
            this.txtReg.Name = "txtReg";
            this.txtReg.ReadOnly = true;
            this.txtReg.Size = new System.Drawing.Size(103, 20);
            this.txtReg.TabIndex = 26;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(18, 51);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 25;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(115, 51);
            this.txtModel.MaxLength = 12;
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(103, 20);
            this.txtModel.TabIndex = 24;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(115, 25);
            this.txtMake.MaxLength = 12;
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(103, 20);
            this.txtMake.TabIndex = 23;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(18, 25);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 22;
            this.lblMake.Text = "Make";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(21, 170);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(197, 52);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Car";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboRemoveCar
            // 
            this.cboRemoveCar.FormattingEnabled = true;
            this.cboRemoveCar.Location = new System.Drawing.Point(78, 59);
            this.cboRemoveCar.Name = "cboRemoveCar";
            this.cboRemoveCar.Size = new System.Drawing.Size(182, 21);
            this.cboRemoveCar.TabIndex = 1;
            this.cboRemoveCar.SelectedIndexChanged += new System.EventHandler(this.cboRemoveCar_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // frmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 380);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpRemoveCar);
            this.Controls.Add(this.cboRemoveCar);
            this.Controls.Add(this.lblRegNo);
            this.Name = "frmRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Car";
            this.Load += new System.EventHandler(this.frmRemove_Load);
            this.grpRemoveCar.ResumeLayout(false);
            this.grpRemoveCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.GroupBox grpRemoveCar;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboRemoveCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.TextBox txtCurrentAvailability;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Label lblUpdateAvailability;
    }
}