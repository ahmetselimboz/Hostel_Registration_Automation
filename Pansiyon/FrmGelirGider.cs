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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ucretTutar();
            textBox1.Text = "3";
            label6.Text = FrmStoklar.stokToplam;
            label8.Text = "786";

        }
        private void ucretTutar()
        {
            baglan.Open();
            cmd = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                label1.Text = dr["toplam"].ToString();
            }
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
            frmanasayfa.Show();
            this.Hide();
        }
        int prsayi;
        private void button3_Click(object sender, EventArgs e)
        {
            prsayi = Convert.ToInt32(textBox1.Text);

            label4.Text = (prsayi * 750).ToString();
        }
        int sonuc;
        private void button1_Click(object sender, EventArgs e)
        {
            sonuc = (Convert.ToInt32(label1.Text)) - ((Convert.ToInt32(label4.Text)) + (Convert.ToInt32(label6.Text)) + (Convert.ToInt32(label8.Text)));
            label11.Text = sonuc.ToString();
        }
    }
}
