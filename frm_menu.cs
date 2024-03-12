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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void ogrenciKayitFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciKayıt f = new frmOgrenciKayıt();
            f.ShowDialog();
        }

		private void KayitListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmKayitListele f = new frmKayitListele();
			f.ShowDialog();
		}
	}
}
