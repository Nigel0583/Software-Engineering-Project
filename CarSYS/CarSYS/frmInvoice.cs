using System;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmInvoice : Form
    {
        frmMakeBooking parent;

        public frmInvoice(frmMakeBooking Parent)
        {
            InitializeComponent();
            parent = Parent;
            btnPrint.Text = "Preview";

            this.ppdInvoice.MinimumSize =
                new Size(900, 1200);
            ppdInvoice.StartPosition = FormStartPosition.CenterParent;
            pdInvoice.PrintPage += new PrintPageEventHandler(pdtInvoice_PrintPage);
        }

        //From https://stackoverflow.com/questions/10605840/print-panel-in-windows-form-c-sharp
        Bitmap memoryImage;

        public void getPrintArea(Panel pnl)
        {
            memoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (memoryImage != null)
            {
                e.Graphics.DrawImage(memoryImage, 0, 0);
                base.OnPaint(e);
            }
        }

        void btnPrint_Click(object sender, EventArgs e)
        {
            print(this.panelInvoice);
            this.Close();
            parent.Visible = true;
        }

        void pdtInvoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, (pagearea.Width / 2) - (this.panelInvoice.Width / 2),
                this.panelInvoice.Location.Y);
        }

        public void print(Panel pnl)
        {
            // panelInvoice = pnl;
            getPrintArea(pnl);
            ppdInvoice.Document = pdInvoice;
            //From https://www.c-sharpcorner.com/UploadFile/mahesh/printdialog-in-C-Sharp/
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pdInvoice;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;
            if (printDialog.ShowDialog() == DialogResult.OK) pdInvoice.Print();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            Booking invoice = new Booking();
            invoice.getInvoiceBooking();

            txtEnd.Text = invoice.getEndDate();
            txtReg.Text = invoice.getRegNo();
            txtStart.Text = invoice.getStartDate();
            txtToday.Text = DateTime.Today.ToString("yyyy-MM-dd");
            lblTot.Text = invoice.getTotal().ToString().Trim();
            lblBookNum.Text = invoice.getBookNo().ToString("00000").Trim();

            Customer customer = new Customer();
            customer.getCustomerInvoice();
            lblEm.Text = customer.getEmail().Trim();
            lblLi.Text = customer.getLicence().Trim();
            lblFirst.Text = customer.getFname().Trim();
            lblSur.Text = customer.getSname().Trim();
            lblAdd.Text = customer.getAddress().Trim();
            lblCountry.Text = customer.getCountry().Trim();
            lblPost.Text = customer.getPostcode().Trim();

            Rates rates = new Rates();
            rates.getInvoicePerDay();
            lblDayCost.Text = rates.getCost().ToString().Trim();
        }

        //From https://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
                    parent.Visible = true;
            
        }
    }
}