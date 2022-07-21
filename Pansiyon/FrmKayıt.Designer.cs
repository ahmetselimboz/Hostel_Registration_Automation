namespace Pansiyon
{
    partial class FrmKayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayıt));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtKayıtSifre = new System.Windows.Forms.Label();
            this.txtKayıtKullaniciAdi = new System.Windows.Forms.Label();
            this.BtnKayıtGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(242, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 30);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(242, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 30);
            this.textBox1.TabIndex = 7;
            // 
            // txtKayıtSifre
            // 
            this.txtKayıtSifre.AutoSize = true;
            this.txtKayıtSifre.BackColor = System.Drawing.Color.Transparent;
            this.txtKayıtSifre.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtSifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKayıtSifre.Location = new System.Drawing.Point(161, 215);
            this.txtKayıtSifre.Name = "txtKayıtSifre";
            this.txtKayıtSifre.Size = new System.Drawing.Size(75, 27);
            this.txtKayıtSifre.TabIndex = 6;
            this.txtKayıtSifre.Text = "Sifre:";
            // 
            // txtKayıtKullaniciAdi
            // 
            this.txtKayıtKullaniciAdi.AutoSize = true;
            this.txtKayıtKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.txtKayıtKullaniciAdi.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKayıtKullaniciAdi.Location = new System.Drawing.Point(64, 168);
            this.txtKayıtKullaniciAdi.Name = "txtKayıtKullaniciAdi";
            this.txtKayıtKullaniciAdi.Size = new System.Drawing.Size(172, 27);
            this.txtKayıtKullaniciAdi.TabIndex = 5;
            this.txtKayıtKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // BtnKayıtGiris
            // 
            this.BtnKayıtGiris.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayıtGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKayıtGiris.ImageIndex = 3;
            this.BtnKayıtGiris.ImageList = this.ımageList2;
            this.BtnKayıtGiris.Location = new System.Drawing.Point(357, 297);
            this.BtnKayıtGiris.Name = "BtnKayıtGiris";
            this.BtnKayıtGiris.Size = new System.Drawing.Size(135, 44);
            this.BtnKayıtGiris.TabIndex = 9;
            this.BtnKayıtGiris.Text = "Kayıt Ol";
            this.BtnKayıtGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKayıtGiris.UseVisualStyleBackColor = true;
            this.BtnKayıtGiris.Click += new System.EventHandler(this.BtnKayıtGiris_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("BlackChancery", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 48);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gece Bahçesi Pansiyonu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(18, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 70);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "list.png");
            this.ımageList1.Images.SetKeyName(1, "left-arrow.png");
            this.ımageList1.Images.SetKeyName(2, "back.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "list.png");
            this.ımageList2.Images.SetKeyName(1, "left-arrow.png");
            this.ımageList2.Images.SetKeyName(2, "house.png");
            this.ımageList2.Images.SetKeyName(3, "diskette.png");
            // 
            // FrmKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKayıtGiris);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtKayıtSifre);
            this.Controls.Add(this.txtKayıtKullaniciAdi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Sayfası";
            this.Load += new System.EventHandler(this.FrmKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtKayıtSifre;
        private System.Windows.Forms.Label txtKayıtKullaniciAdi;
        private System.Windows.Forms.Button BtnKayıtGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}