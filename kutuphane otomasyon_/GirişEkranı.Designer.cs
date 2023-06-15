namespace kutuphane_otomasyon_
{
    partial class GirisEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkranı));
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.YeniKullanıcıBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.GirisYapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisYapBtn.ForeColor = System.Drawing.Color.White;
            this.GirisYapBtn.Location = new System.Drawing.Point(181, 328);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(213, 72);
            this.GirisYapBtn.TabIndex = 1;
            this.GirisYapBtn.Text = "Giriş Yap";
            this.GirisYapBtn.UseVisualStyleBackColor = false;
            this.GirisYapBtn.Click += new System.EventHandler(this.GirisYapBtn_Click);
            // 
            // YeniKullanıcıBtn
            // 
            this.YeniKullanıcıBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.YeniKullanıcıBtn.ForeColor = System.Drawing.Color.White;
            this.YeniKullanıcıBtn.Location = new System.Drawing.Point(181, 406);
            this.YeniKullanıcıBtn.Name = "YeniKullanıcıBtn";
            this.YeniKullanıcıBtn.Size = new System.Drawing.Size(213, 69);
            this.YeniKullanıcıBtn.TabIndex = 2;
            this.YeniKullanıcıBtn.Text = "Hesap Oluştur";
            this.YeniKullanıcıBtn.UseVisualStyleBackColor = false;
            this.YeniKullanıcıBtn.Click += new System.EventHandler(this.YeniKullanıcıBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 296);
            this.panel1.TabIndex = 3;
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 518);
            this.Controls.Add(this.YeniKullanıcıBtn);
            this.Controls.Add(this.GirisYapBtn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kütüphane Giriş Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GirisYapBtn;
        private System.Windows.Forms.Button YeniKullanıcıBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

