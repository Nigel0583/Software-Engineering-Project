namespace CarSYS
{
    partial class frmCarAvailability
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpCarAvail = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.grpCarAvail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(550, 19);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(191, 33);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check Availability ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grpCarAvail
            // 
            this.grpCarAvail.Controls.Add(this.lblFrom);
            this.grpCarAvail.Controls.Add(this.lblTo);
            this.grpCarAvail.Controls.Add(this.dtpFrom);
            this.grpCarAvail.Controls.Add(this.dtpTo);
            this.grpCarAvail.Controls.Add(this.btnCheck);
            this.grpCarAvail.Location = new System.Drawing.Point(12, 12);
            this.grpCarAvail.Name = "grpCarAvail";
            this.grpCarAvail.Size = new System.Drawing.Size(781, 67);
            this.grpCarAvail.TabIndex = 8;
            this.grpCarAvail.TabStop = false;
            this.grpCarAvail.Text = "Car Availability";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(10, 38);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(272, 37);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(46, 31);
            this.dtpFrom.MinDate = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Value = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(312, 31);
            this.dtpTo.MinDate = new System.DateTime(2019, 2, 12, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.Value = new System.DateTime(2019, 2, 12, 0, 0, 0, 0);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(912, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(12, 85);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(975, 406);
            this.grdData.TabIndex = 4;
            // 
            // frmCarAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 503);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpCarAvail);
            this.Name = "frmCarAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarAvailability";
            this.grpCarAvail.ResumeLayout(false);
            this.grpCarAvail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpCarAvail;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdData;
    }
}