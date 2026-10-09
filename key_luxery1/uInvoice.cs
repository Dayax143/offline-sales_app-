using System;
using System.Data;
using System.Windows.Forms;

namespace key_luxery1
{
	public partial class uInvoice : UserControl
	{
		sharedClass db = new sharedClass();
		public uInvoice()
		{
			InitializeComponent();
		}

		private void uControl_Load(object sender, EventArgs e)
		{
			LoadInvoiceData();
		}

		public void LoadInvoiceData()
		{
			try
			{
				string query = @"SELECT i.invoice_id AS [ID], 
                                        i.invoice_number AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        i.invoice_date AS [Date], 
                                        i.total_amount AS [Total ($)], 
                                        i.paid_amount AS [Paid ($)], 
                                        i.status AS [Status] 
                                 FROM tblInvoice i
                                 LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id
                                 WHERE i.status != 'Draft'
                                 ORDER BY i.invoice_id DESC";

				DataTable dt = sharedClass.GetData(query);
				dgvInvoices.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearchInvoice_TextChanged(object sender, EventArgs e)
		{
			string keyword = txtSearchInvoice.Text.Trim();
			try
			{
				string query = $@"SELECT i.invoice_id AS [ID], 
                                        i.invoice_number AS [Invoice No], 
                                        c.customer_name AS [Customer Name], 
                                        i.invoice_date AS [Date], 
                                        i.total_amount AS [Total ($)], 
                                        i.paid_amount AS [Paid ($)], 
                                        i.status AS [Status] 
                                 FROM tblInvoice i
                                 LEFT JOIN tblCustomer c ON i.customer_id = c.customer_id
                                 WHERE i.status != 'Draft' AND (i.invoice_number LIKE '%{keyword}%' OR c.customer_name LIKE '%{keyword}%')
                                 ORDER BY i.invoice_id DESC";

				DataTable dt = sharedClass.GetData(query);
				dgvInvoices.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void uInvoice_Load(object sender, EventArgs e)
		{

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtSearchInvoice.Clear();
			LoadInvoiceData();
		}
	}
}