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
    public partial class FrmOdalar : Form
    {
        public static string odano101;
        public static string odano102;
        public static string odano103;
        public static string odano104;
        public static string odano105;
        public static string odano106;
        public static string odano107;
        public static string odano108;
        public static string odano109;
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=GeceBahcesi;Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataReader dr;
        private void button5_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmanasayfa = new FrmAnaSayfa();
            frmanasayfa.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
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

        private void btn101_Click(object sender, EventArgs e)
        {
            
        }

        private void Oda101()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda101", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda101.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Crimson;
            }
            odano101 = btnOda101.Text;
        }

        private void Oda102()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda102", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda102.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Crimson;
            }
            odano102 = btnOda102.Text;
        }

        private void Oda103()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda103", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda103.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Crimson;
            }
            odano103 = btnOda103.Text;
        }

        private void Oda104()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda104", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda104.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Crimson;
            }
            odano104 = btnOda104.Text;
        }

        private void Oda105()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda105", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda105.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Crimson;
            }
            odano105 = btnOda105.Text;
        }

        private void Oda106()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda106", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda106.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Crimson;

            }
            odano106 = btnOda106.Text;
        }

        private void Oda107()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda107", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda107.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Crimson;
            }
            odano107 = btnOda107.Text;
        }

        private void Oda108()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda108", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda108.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Crimson;
            }
            odano108 = btnOda108.Text;
        }

        private void Oda109()
        {
            baglan.Open();
            cmd = new SqlCommand("select * from Oda109", baglan);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                btnOda109.Text = dr["adi"].ToString() + " " + dr["soyadi"].ToString();
            }
            baglan.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Crimson;
            }
            odano109 = btnOda109.Text;
        }

        
    }
}
