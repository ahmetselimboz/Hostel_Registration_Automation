using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pansiyon
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {

            Giris();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmKayıt frmKayıt = new FrmKayıt();
            frmKayıt.Show();
            this.Hide();
        }
        private void Giris()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from GirisYap where KullaniciAdi=@kullaniciadi AND Sifre=@sifre",baglan);
            cmd.Parameters.AddWithValue("@kullaniciadi", txbKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txbSifre.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
                frmanasayfa.Show();
                this.Hide();
            }
            else if(txbKullaniciAdi.Text.ToString() == " " || txbSifre.Text.ToString() ==" ")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ya da Şifreyi boş bırakmayınız ");

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre yanlış!! ");
            }
            baglan.Close();
        }
    }
}
