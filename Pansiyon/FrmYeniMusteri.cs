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
    public partial class FrmYeniMusteri : Form
    {
        
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
        }

        private void dtpTxtÇıkışTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime tarihGiris = Convert.ToDateTime(dtpTxtGirisTarihi.Text);
            DateTime tarihCikis = Convert.ToDateTime(dtpTxtÇıkışTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = tarihCikis - tarihGiris;

            

            ucret = Convert.ToInt32(Sonuc.TotalDays.ToString()) * 200;
            txtUcret.Text = ucret.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MusteriKaydet();

        }

        private void MusteriKaydet()
        {
            baglan.Open();
            cmd = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CıkısTarihi) values(@Adi, @Soyadi, @Cinsiyet, @Telefon, @Mail, @TC, @OdaNo, @Ucret, @GirisTarihi, @CıkısTarihi)", baglan);
            cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", cmbTxtCinsiyet.Text);
            cmd.Parameters.AddWithValue("@Telefon", mskTxtTelefonNo.Text);
            cmd.Parameters.AddWithValue("@Mail", txtMail.Text);
            cmd.Parameters.AddWithValue("@TC", txtKimlikNo.Text);
            cmd.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text);
            cmd.Parameters.AddWithValue("@ucret", txtUcret.Text); 
            cmd.Parameters.AddWithValue("@GirisTarihi", dtpTxtGirisTarihi.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@CıkısTarihi", dtpTxtÇıkışTarihi.Value.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
            baglan.Close();

            if (txtOdaNo.Text == "101")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda101(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "102")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda102(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "103")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda103(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "104")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda104(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "105")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda105(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "106")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda106(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "107")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda107(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "108")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda108(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
            if (txtOdaNo.Text == "109")
            {
                baglan.Open();
                cmd = new SqlCommand("insert into Oda109(adi, soyadi) values(@adi, @soyadi)", baglan);
                cmd.Parameters.AddWithValue("@Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Soyadi", txtSoyadi.Text);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni kayıt eklendi!!");
            }
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
            frmanasayfa.Show();
            this.Hide();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Oda101();
            Oda102();
            Oda103();
            Oda104();
            Oda105();
            Oda106();
            Oda107();
            Oda108();
            Oda109();
        }
        private void Oda101()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda101", baglan);
            dr = cmd.ExecuteReader();
            
            while(dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn101.BackColor = Color.Crimson;
                    btn101.Enabled = false;
                }
            }
            baglan.Close();
            
            
        }

        private void Oda102()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda102", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn102.BackColor = Color.Crimson;
                    btn102.Enabled = false;
                }
            }
            baglan.Close();
        }
        

        private void Oda103()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda103", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn103.BackColor = Color.Crimson;
                    btn103.Enabled = false;
                }
            }
            baglan.Close();
        }

        private void Oda104()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda104", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn104.BackColor = Color.Crimson;
                    btn104.Enabled = false;
                }
            }
            baglan.Close();
        }

        private void Oda105()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda105", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn105.BackColor = Color.Crimson;
                    btn105.Enabled = false;
                }
            }
            baglan.Close();
        }

        private void Oda106()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda106", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn106.BackColor = Color.Crimson;
                    btn106.Enabled = false;
                }
            }
            baglan.Close();
        }

        private void Oda107()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda107", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn107.BackColor = Color.Crimson;
                    btn107.Enabled = false;
                }
            }
            baglan.Close();
        }

        private void Oda108()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda108", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn108.BackColor = Color.Crimson;
                    btn108.Enabled = false;
                }
            }
            baglan.Close();
        }

        private void Oda109()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda109", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["adi"].ToString() != " " && dr["soyadi"].ToString() != " ")
                {
                    btn109.BackColor = Color.Crimson;
                    btn109.Enabled = false;
                }
            }
            baglan.Close();
        }
    }
}
