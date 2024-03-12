using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppStudentRegistrationDB
{
	public partial class frmKayitListele : Form
	{
		public frmKayitListele()
		{
			InitializeComponent();
		}

		private void frmKayitListele_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'okulDBDataSet.Tbl_Ogrenci' table. You can move, or remove it, as needed.
            this.tbl_OgrenciTableAdapter.Fill(this.okulDBDataSet.Tbl_Ogrenci);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırın indeksini al
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Seçilen satırdaki veriyi al
                DataRowView selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                if (selectedRow != null)
                {
                    // Veriyi sil
                    selectedRow.Row.Delete();

                    // Değişiklikleri kaydet
                    this.tbl_OgrenciTableAdapter.Update(this.okulDBDataSet.Tbl_Ogrenci);
                }

            }

        }
    }
}
