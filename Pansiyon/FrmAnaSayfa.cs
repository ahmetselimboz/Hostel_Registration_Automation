using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmMusterilercs_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            

            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmYeniMusteri = new FrmYeniMusteri();
            frmYeniMusteri.Show();
            this.Hide();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gece Bahçesi Pansiyon Kayıt Uygulaması / 2022-Temmuz");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGelirGider frmGelirGider = new FrmGelirGider();
            frmGelirGider.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();
            frmOdalar.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmStoklar frmStoklar = new FrmStoklar();
            frmStoklar.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Visible = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void FrmAnaSayfa_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button1.Visible = true;
        }
    }
}
