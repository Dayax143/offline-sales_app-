using System;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class frmManageInvoice : Form
	{
		public frmManageInvoice()
		{
			InitializeComponent();
		}

		private void frmManageInvoice_Load(object sender, EventArgs e)
		{
			// Automatically trigger data load on user control when form opens
			invoiceUserControl.LoadInvoiceData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}