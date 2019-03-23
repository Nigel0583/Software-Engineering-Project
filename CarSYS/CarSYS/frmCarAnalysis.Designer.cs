namespace CarSYS
{
    partial class frmCarAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpCartype = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnCarType = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCarCategory = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.grpCartype.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chtData
            // 
            chartArea2.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtData.Legends.Add(legend2);
            this.chtData.Location = new System.Drawing.Point(12, 106);
            this.chtData.Name = "chtData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtData.Series.Add(series2);
            this.chtData.Size = new System.Drawing.Size(792, 332);
            this.chtData.TabIndex = 19;
            this.chtData.Text = "chart1";
            // 
            // grpCartype
            // 
            this.grpCartype.Controls.Add(this.dtpDate);
            this.grpCartype.Controls.Add(this.label6);
            this.grpCartype.Controls.Add(this.lblFrom);
            this.grpCartype.Controls.Add(this.cboCarCategory);
            this.grpCartype.Controls.Add(this.btnCarType);
            this.grpCartype.Location = new System.Drawing.Point(111, 12);
            this.grpCartype.Name = "grpCartype";
            this.grpCartype.Size = new System.Drawing.Size(524, 88);
            this.grpCartype.TabIndex = 18;
            this.grpCartype.TabStop = false;
            this.grpCartype.Text = "Car Analysis";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "Year";
            // 
            // btnCarType
            // 
            this.btnCarType.Location = new System.Drawing.Point(295, 46);
            this.btnCarType.Name = "btnCarType";
            this.btnCarType.Size = new System.Drawing.Size(211, 36);
            this.btnCarType.TabIndex = 7;
            this.btnCarType.Text = "Analyse Car Type";
            this.btnCarType.UseVisualStyleBackColor = true;
            this.btnCarType.Click += new System.EventHandler(this.btnCarType_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Car Type";
            // 
            // cboCarCategory
            // 
            this.cboCarCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCarCategory.FormattingEnabled = true;
            this.cboCarCategory.Location = new System.Drawing.Point(316, 19);
            this.cboCarCategory.MaxDropDownItems = 10;
            this.cboCarCategory.Name = "cboCarCategory";
            this.cboCarCategory.Size = new System.Drawing.Size(176, 21);
            this.cboCarCategory.TabIndex = 20;
            this.cboCarCategory.Tag = "";
            this.cboCarCategory.Text = "CarType";
            this.cboCarCategory.SelectedIndexChanged += new System.EventHandler(this.cboCarCategory_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(41, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(209, 20);
            this.dtpDate.TabIndex = 22;
            // 
            // frmCarAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.chtData);
            this.Controls.Add(this.grpCartype);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCarAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarAnalysis";
            this.Load += new System.EventHandler(this.frmCarAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.grpCartype.ResumeLayout(false);
            this.grpCartype.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.GroupBox grpCartype;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnCarType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCarCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}