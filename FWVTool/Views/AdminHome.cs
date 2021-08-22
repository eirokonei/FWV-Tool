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
	public partial class AdminHome : MetroForm
	{
		public AdminHome()
		{
			InitializeComponent();
		}

		private void mtOCPDatabase_Click(object sender, EventArgs e)
		{
			this.Hide();
			OCPDatabase od = new OCPDatabase();
			od.Show();
		}

		private void mtMedicine_Click(object sender, EventArgs e)
		{
			this.Hide();
			ShowMedicine sm = new ShowMedicine();
			sm.Show();
		}

		private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login ln = new Login();
			ln.Show();
		}

		private void mtConData_Click(object sender, EventArgs e)
		{
			this.Hide();
			ContraceptiveData cd = new ContraceptiveData();
			cd.Show();
		}

		private void mtICData_Click(object sender, EventArgs e)
		{
			this.Hide();
			InjectableData icd = new InjectableData();
			icd.Show();
		}

		private void mtIUDData_Click(object sender, EventArgs e)
		{
			this.Hide();
			IUDDatabase iud = new IUDDatabase();
			iud.Show();
		}

		private void mtNPData_Click(object sender, EventArgs e)
		{
			this.Hide();
			NormalPData npd = new NormalPData();
			npd.Show();
		}

		private void mtUser_Click(object sender, EventArgs e)
		{
			this.Hide();
			UserData ud = new UserData();
			ud.Show();
		}
	}
}
