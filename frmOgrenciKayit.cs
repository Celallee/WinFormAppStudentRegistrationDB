using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAppStudentRegistrationDB
{
    public partial class frmOgrenciKayıt : Form
    {
        public frmOgrenciKayıt()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                SqlConnection sqlcon = Connection.baglanti;
                SqlCommand sqlcmd = new SqlCommand("insert into Tbl_Ogrenci(Adi,Soyadi,Telefon,Yas) values (@Adi,@Soyadi,@Telefon,@Yas)", sqlcon);
                sqlcmd.Parameters.AddWithValue("@Adi", txt_Ad.Text);
                sqlcmd.Parameters.AddWithValue("@Soyadi", txt_soyad.Text);
                sqlcmd.Parameters.AddWithValue("@Telefon", txt_telefon.Text);
                sqlcmd.Parameters.AddWithValue("@Yas", txt_yas.Text);
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Kaydedildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }

            }
        }
    }

