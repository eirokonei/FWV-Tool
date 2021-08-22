using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWVTool.Views
{
	public partial class InjectableContraceptive : Form
	{
		string user { get; set; }
		public InjectableContraceptive(string name="")
		{
			InitializeComponent();
			this.user = name;
		}

		private void InjectableContraceptive_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			this.injectableExisting1.Hide();
			this.injectableNew1.Show();
			this.injectableNew1.BringToFront();
			
		}

		private void InjectableContraceptive_Load(object sender, EventArgs e)
		{
			this.injectableExisting1.Hide();
			this.injectableNew1.Show();
			this.injectableNew1.BringToFront();
		}

		private void btnExisting_Click(object sender, EventArgs e)
		{
			this.injectableNew1.Hide();
			this.injectableExisting1.Show();
			this.injectableExisting1.BringToFront();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home hm = new Home(this.user);
			hm.Show();
		}

		private void injectableExisting1_Load(object sender, EventArgs e)
		{

		}
	}
}
