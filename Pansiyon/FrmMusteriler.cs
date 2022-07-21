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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Güncelle();
        }
        private void verilerimigöster()
        {
            listView1.Items.Clear();
             baglan.Open();
            cmd = new SqlCommand("Select * from MusteriEkle", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = dr["MusteriID"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNo"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            
            baglan.Close();
        }
        private void TextBoxGörüntüle()
        {
            baglan.Open();
            cmd = new SqlCommand("Select * from MusteriEkle where MusteriID=@id", baglan);
            cmd.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                
                txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cmbTxtCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
                mskTxtTelefonNo.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
                txtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
                txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
                txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
                dtpTxtGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
                dtpTxtÇıkışTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            }
            baglan.Close();
        }
        private void Güncelle()
        {
            baglan.Open();
            cmd = new SqlCommand("update MusteriEkle set Adi=@adi, Soyadi=@soyadi, Cinsiyet=@cinsiyet, " +
                "Telefon=@telefon, Mail=@mail, TC=@tc, OdaNo=@odano, Ucret=@ucret, GirisTarihi=@giris, CıkısTarihi=@cikis where MusteriID=@id", baglan);
            cmd.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
            cmd.Parameters.Add("@adi", txtAdi.Text);
            cmd.Parameters.Add("@soyadi", txtSoyadi.Text);
            cmd.Parameters.Add("@cinsiyet", cmbTxtCinsiyet.Text);
            cmd.Parameters.Add("@telefon", mskTxtTelefonNo.Text);
            cmd.Parameters.Add("@mail", txtMail.Text);
            cmd.Parameters.Add("@tc", txtKimlikNo.Text);
            cmd.Parameters.Add("@odano", txtOdaNo.Text);
            cmd.Parameters.Add("@ucret", txtUcret.Text);
            cmd.Parameters.Add("@giris", dtpTxtGirisTarihi.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.Add("@cikis", dtpTxtÇıkışTarihi.Value.ToString("yyyy-MM-dd"));

            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Seçili satır güncellendi!!");


        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verilerimigöster();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            TextBoxGörüntüle();
            
        }
        private void Sil()
        {
            if (txtOdaNo.Text == "101")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda101", baglan);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "102")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda102", baglan);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "103")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda103", baglan);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "104")
            {

                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda104", baglan);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "105")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda105", baglan);
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "106")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda106", baglan);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "107")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda107", baglan);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "108")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda108", baglan);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }
            if (txtOdaNo.Text == "109")
            {
                baglan.Open();
                cmd2 = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
                cmd2.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
                cmd = new SqlCommand("delete from Oda109", baglan);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Seçili satır silindi!!");
            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbTxtCinsiyet.Text = " ";
            mskTxtTelefonNo.Text = " ";
            txtMail.Clear();
            txtKimlikNo.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            dtpTxtGirisTarihi.Text = string.Empty;
            dtpTxtÇıkışTarihi.Text = string.Empty;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            cmd = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBox1.Text+"%'",baglan);
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = dr["MusteriID"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNo"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            
            baglan.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
            frmanasayfa.Show();
            this.Hide();
        }
    
    }
    //cmd = new SqlCommand("delete from MusteriEkle where MusteriID=@id", baglan);
    //cmd.Parameters.Add("@id", listView1.SelectedItems[0].SubItems[0].Text);
}
