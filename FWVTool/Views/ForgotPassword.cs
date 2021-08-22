using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using FWVTool.Data_Layer;

namespace FWVTool.Views
{
	public partial class ForgotPassword : MetroForm
	{
		public ForgotPassword()
		{
			InitializeComponent();
		}

		private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login ln = new Login();
			ln.Show();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string sql = @"select mobile from FWVUser where userName='"+this.txtUserName.Text+"';";
			var dt = DataAccess.GetDataTable(sql);
			int count = dt.Rows.Count;
			if(count<1)
			{
				MessageBox.Show("Invalid");
				return;
			}
			string mobile = dt.Rows[0][0].ToString();
			if(mobile.Equals(this.txtPhone.Text))
			{
				sql = @"update FWVUser set password='" + this.txtNewPass.Text + "' where userName='"+this.txtUserName.Text+"';";
				int c= DataAccess.ExecuteQuery(sql);
				if(c==1)
				{
					MessageBox.Show("Password Changed");
					this.Hide();
					Login ln = new Login();
					ln.Show();
				}
				else
				{
					MessageBox.Show("Invalid");
				}
			}
			else
			{
				MessageBox.Show("Invalid User Name or Mobile No.");
			}
		}
	}
}
