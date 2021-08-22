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
	public partial class Login : MetroForm
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string sql = @"Select password from FWVUser where userName='"+this.txtUserName.Text+"';";
			var dt = DataAccess.GetDataTable(sql);
			int row = dt.Rows.Count;
			if(row==1)
			{
				string pass = dt.Rows[0][0].ToString();
				if(pass.Equals(this.txtPassword.Text))
				{
					if(this.txtUserName.Text=="admin")
					{

						MessageBox.Show("Login Successful");
						this.Hide();
						AdminHome ahm = new AdminHome();
						ahm.Show();
					}
					else
					{
						MessageBox.Show("Login Successful");
						this.Hide();
						Home hm = new Home(this.txtUserName.Text);
						
						hm.Show();
					}
					
				}
				else
				{
					MessageBox.Show("Invalid");
				}
			}
			else
			{
				MessageBox.Show("Invalid User Name");

			}
		}

		private void lblSignUp_Click(object sender, EventArgs e)
		{
			this.Hide();
			SignUp up = new SignUp();
			up.Show();
		}

		private void lblForgot_Click(object sender, EventArgs e)
		{
			this.Hide();
			ForgotPassword fp = new ForgotPassword();
			fp.Show();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
