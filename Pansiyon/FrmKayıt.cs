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
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlDataReader dr;

        private void BtnKayıtGiris_Click(object sender, EventArgs e)
        {
            Kayitci();
        }
        private void Kayitci()
        {
            baglan.Open();
            cmd = new SqlCommand("insert into GirisYap(KullaniciAdi,Sifre) values(@KullaniciAdi, @Sifre)", baglan);
            cmd.Parameters.AddWithValue("@KullaniciAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", textBox2.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();

            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void FrmKayıt_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
