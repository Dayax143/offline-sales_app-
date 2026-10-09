using System.Windows.Forms;

namespace key_luxery1
{
	partial class frmManageInvoice
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lblHeaderTitle = new System.Windows.Forms.Label();
			this.invoiceUserControl = new key_luxery1.uInvoice();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblHeaderTitle
			// 
			this.lblHeaderTitle.AutoSize = true;
			this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.lblHeaderTitle.Location = new System.Drawing.Point(25, 20);
			this.lblHeaderTitle.Name = "lblHeaderTitle";
			this.lblHeaderTitle.Size = new System.Drawing.Size(314, 41);
			this.lblHeaderTitle.TabIndex = 0;
			this.lblHeaderTitle.Text = "Invoice Management";
			// 
			// invoiceUserControl
			// 
			this.invoiceUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.invoiceUserControl.Location = new System.Drawing.Point(25, 75);
			this.invoiceUserControl.Name = "invoiceUserControl";
			this.invoiceUserControl.Size = new System.Drawing.Size(880, 520);
			this.invoiceUserControl.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(780, 23);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(125, 38);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close Window";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmManageInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(932, 615);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.invoiceUserControl);
			this.Controls.Add(this.lblHeaderTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageInvoice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Key Luxury - Invoice Management";
			this.Load += new System.EventHandler(this.frmManageInvoice_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeaderTitle;
		private uInvoice invoiceUserControl;
		private System.Windows.Forms.Button btnClose;
	}
}