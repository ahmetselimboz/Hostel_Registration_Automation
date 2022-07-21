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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        public static string stokToplam;
        private void button4_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
            frmanasayfa.Show();
            this.Hide();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            labelayazdır();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int SoİçT, SıİçT, KaÇeT, SuT, AbCuT;
        private void labelayazdır()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Stoklar2", baglan);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds, "Stoklar2");
            label3.Text = ds.Tables[0].Rows[0]["Ürünler"].ToString();
            label6.Text = ds.Tables[0].Rows[1]["Ürünler"].ToString();
            label9.Text = ds.Tables[0].Rows[2]["Ürünler"].ToString();
            label12.Text = ds.Tables[0].Rows[3]["Ürünler"].ToString();
            label15.Text = ds.Tables[0].Rows[4]["Ürünler"].ToString();

            label4.Text = ds.Tables[0].Rows[0]["Sayisi"].ToString();
            label7.Text = ds.Tables[0].Rows[1]["Sayisi"].ToString();
            label10.Text = ds.Tables[0].Rows[2]["Sayisi"].ToString();
            label13.Text = ds.Tables[0].Rows[3]["Sayisi"].ToString();
            label16.Text = ds.Tables[0].Rows[4]["Sayisi"].ToString();

            label5.Text = ds.Tables[0].Rows[0]["Fiyatlar"].ToString();
            label8.Text = ds.Tables[0].Rows[1]["Fiyatlar"].ToString();
            label11.Text = ds.Tables[0].Rows[2]["Fiyatlar"].ToString();
            label14.Text = ds.Tables[0].Rows[3]["Fiyatlar"].ToString();
            label17.Text = ds.Tables[0].Rows[4]["Fiyatlar"].ToString();

            SoİçT = (Convert.ToInt32(ds.Tables[0].Rows[0]["Sayisi"])) * (Convert.ToInt32(ds.Tables[0].Rows[0]["Fiyatlar"]));
            label33.Text = SoİçT.ToString();

            SıİçT = (Convert.ToInt32(ds.Tables[0].Rows[1]["Sayisi"])) * (Convert.ToInt32(ds.Tables[0].Rows[1]["Fiyatlar"]));
            label32.Text = SıİçT.ToString();

            KaÇeT = (Convert.ToInt32(ds.Tables[0].Rows[2]["Sayisi"])) * (Convert.ToInt32(ds.Tables[0].Rows[2]["Fiyatlar"]));
            label31.Text = KaÇeT.ToString();

            SuT = (Convert.ToInt32(ds.Tables[0].Rows[3]["Sayisi"])) * (Convert.ToInt32(ds.Tables[0].Rows[3]["Fiyatlar"]));
            label30.Text = SuT.ToString();

            AbCuT = (Convert.ToInt32(ds.Tables[0].Rows[4]["Sayisi"])) * (Convert.ToInt32(ds.Tables[0].Rows[4]["Fiyatlar"]));
            label29.Text = AbCuT.ToString();

            stokToplam = (SoİçT + SıİçT + KaÇeT + SuT + AbCuT).ToString();

        }
    }
}
