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

namespace FWVTool.Views
{
	public partial class Home : MetroForm
	{
		private string user { get; set; }
		public Home(string name="")
		{
			InitializeComponent();
			user = name;
			this.lblUser.Text = this.user;
		}

	

		private void Home_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void mtIUD_Click(object sender, EventArgs e)
		{
			this.Hide();
			IUDRegister iu = new IUDRegister(this.user);
			iu.Show();
		}

		private void mtNPR_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide();
				NormalPR npr = new NormalPR(this.user);
				npr.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void mtOCP_Click(object sender, EventArgs e)
		{
			this.Hide();
			OCP oc = new OCP(this.user);
			oc.Show();
		}

		private void mtICP_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide();
				InjectableContraceptive ic = new InjectableContraceptive(this.user);
				ic.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login ln = new Login();
			ln.Show();
		}

		private void mtProfile_Click(object sender, EventArgs e)
		{
			this.Hide();
			MyProfile mp = new MyProfile(user);
			mp.Show();
		}
	}
}
