using FWVTool.Repo;
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
	public partial class ShowMedicine : Form
	{
		MedicineRepo mrepo = new MedicineRepo();
		public ShowMedicine()
		{
			InitializeComponent();
			this.PopulateGridView();
			this.txtSerial.Text = mrepo.AutoGenerateSerial().ToString();
			this.txtTotal.Text = mrepo.TotalQua().ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			try
			{
				if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
					return;

				bool decision = mrepo.Save(Int32.Parse(this.txtSerial.Text), this.txtType.Text, this.txtMedName.Text, Int32.Parse(this.txtQuantity.Text));

				if (decision)
				{
					MessageBox.Show("Saved");
					this.PopulateGridView();
					this.txtSerial.Text = mrepo.AutoGenerateSerial().ToString();
					this.ClearMed();
					this.txtTotal.Text = mrepo.TotalQua().ToString();
				}
				else
					MessageBox.Show("Invalid.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void PopulateGridView()
		{
			this.dgvMedicine.AutoGenerateColumns = false;
			this.dgvMedicine.DataSource = mrepo.GetAll().ToList();
			this.dgvMedicine.Refresh();
			this.dgvMedicine.ClearSelection();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.dgvMedicine.SelectedRows.Count != 1)
			{
				MessageBox.Show("Please Select A Row First");
				return;
			}

			if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			int serial = Int32.Parse(this.dgvMedicine.CurrentRow.Cells["serial"].Value.ToString());
			bool decision = mrepo.Delete(serial);

			if (decision)
			{
				MessageBox.Show("Delete Confirmed.");
				this.PopulateGridView();
				this.ClearMed();
				this.txtSerial.Text= mrepo.AutoGenerateSerial().ToString();
				this.txtTotal.Text = mrepo.TotalQua().ToString();
			}
			else
				MessageBox.Show("Invalid.");
		}

		private void ShowMedicine_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void dgvMedicine_DoubleClick(object sender, EventArgs e)
		{
			this.txtSerial.Text = this.dgvMedicine.CurrentRow.Cells["serial"].Value.ToString();
			this.txtType.Text = this.dgvMedicine.CurrentRow.Cells["type"].Value.ToString();
			this.txtMedName.Text= this.dgvMedicine.CurrentRow.Cells["medName"].Value.ToString();
			this.txtQuantity.Text = this.dgvMedicine.CurrentRow.Cells["quantity"].Value.ToString();
		}
		private void ClearMed()
		{
			this.txtType.Clear();
			this.txtMedName.Clear();
			this.txtQuantity.Clear();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminHome hm = new AdminHome();
			hm.Show();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			this.dgvMedicine.AutoGenerateColumns = false;
			this.dgvMedicine.DataSource = mrepo.GetSearchValue(this.textBox4.Text).ToList();
			this.dgvMedicine.Refresh();
			this.dgvMedicine.ClearSelection();
		}
	}
}
