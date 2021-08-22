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
	public partial class SignUp : MetroForm
	{
		public SignUp()
		{
			InitializeComponent();
			this.txtUserId.Text = this.AutoGenerateId();
		}

		private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login ln = new Login();
			ln.Show();
		}

		private void btnSignUp_Click(object sender, EventArgs e)
		{
			try
			{
				bool dec = this.SignValidation();
				bool userNam = this.UserNameValidation();
				if (dec)
				{
					if (!userNam)
					{
						string sql = @"Insert into FWVUser values('" + this.txtUserId.Text + "', '" + this.txtUserName.Text + "'," +
						" '" + this.txtFullName.Text + "', '" + this.txtMoblie.Text + "', '" + this.txtEmail.Text + "', '" + this.txtPassword.Text + "');";

						int row = DataAccess.ExecuteQuery(sql);
						if (row == 1)
						{
							MessageBox.Show("Value Added");
							this.txtUserId.Text = this.AutoGenerateId();
							this.CleartxtBox();
						}
						else
						{
							MessageBox.Show("Failed");
						}
					}
					else
					{
						MessageBox.Show("Choose another user name");
					}
					
				}
				else
				{
					MessageBox.Show("Not Valid");
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private string AutoGenerateId()
		{
			string query = @"select userId from FWVUser";
			var dt = DataAccess.GetDataTable(query);
			int rowCount = dt.Rows.Count;

			string regNo = dt.Rows[rowCount - 1][0].ToString();
			string[] subReg = regNo.Split('f', 'w', 'v', '-');
			int autoId = Convert.ToInt32(subReg[4]);
			//autoId++;

			return "fwv-" + (++autoId).ToString("d3");
		}

		private void CleartxtBox()
		{
			this.txtUserName.Clear();
			this.txtFullName.Clear();
			this.txtMoblie.Clear();
			this.txtEmail.Clear();
			this.txtPassword.Clear();
			this.txtConfirmPass.Clear();
		}

		private bool SignValidation()
		{
			if(this.txtPassword.Text.Equals(this.txtConfirmPass.Text) && this.txtUserName.Text!="" && this.txtFullName.Text != "" && this.txtMoblie.Text != "" && this.txtEmail.Text != "" && this.txtPassword.Text != "" && this.txtConfirmPass.Text != "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool UserNameValidation()
		{
			string sql = @"Select userName from FWVUser where userName='"+this.txtUserName.Text+"';";
			var dt = DataAccess.GetDataTable(sql);
			int uname = dt.Rows.Count;
			if(uname>=1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
