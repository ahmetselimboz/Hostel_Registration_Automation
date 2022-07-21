namespace Pansiyon
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ImageList ımageList1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.Label();
            this.txbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BlackChancery", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gece Bahçesi Pansiyonu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AutoSize = true;
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(64, 168);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(172, 27);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            this.txtSifre.AutoSize = true;
            this.txtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtSifre.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSifre.Location = new System.Drawing.Point(161, 215);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(75, 27);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Text = "Sifre:";
            // 
            // txbKullaniciAdi
            // 
            this.txbKullaniciAdi.Font = new System.Drawing.Font("Inter Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbKullaniciAdi.Location = new System.Drawing.Point(242, 168);
            this.txbKullaniciAdi.Name = "txbKullaniciAdi";
            this.txbKullaniciAdi.Size = new System.Drawing.Size(173, 28);
            this.txbKullaniciAdi.TabIndex = 3;
            // 
            // txbSifre
            // 
            this.txbSifre.Font = new System.Drawing.Font("Circe Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbSifre.Location = new System.Drawing.Point(242, 215);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.Size = new System.Drawing.Size(173, 29);
            this.txbSifre.TabIndex = 4;
            this.txbSifre.UseSystemPasswordChar = true;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGiris.ImageIndex = 2;
            this.BtnGiris.ImageList = ımageList1;
            this.BtnGiris.Location = new System.Drawing.Point(357, 297);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(141, 44);
            this.BtnGiris.TabIndex = 5;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGiris.UseMnemonic = false;
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = ımageList1;
            this.button1.Location = new System.Drawing.Point(195, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayıt Ol";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            ımageList1.Images.SetKeyName(0, "list.png");
            ımageList1.Images.SetKeyName(1, "left-arrow.png");
            ımageList1.Images.SetKeyName(2, "house.png");
            ımageList1.Images.SetKeyName(3, "diskette.png");
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.txbKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtKullaniciAdi;
        private System.Windows.Forms.Label txtSifre;
        private System.Windows.Forms.TextBox txbKullaniciAdi;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

