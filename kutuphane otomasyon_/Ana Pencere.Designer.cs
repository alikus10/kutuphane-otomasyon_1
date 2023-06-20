namespace kutuphane_otomasyon_
{
    partial class AnaPencere
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
            this.button1 = new System.Windows.Forms.Button();
            this.uyeekleBtn = new System.Windows.Forms.Button();
            this.ktplarıgörBtn = new System.Windows.Forms.Button();
            this.KullaniciIslemleriBtn = new System.Windows.Forms.Button();
            this.oduncverBtn = new System.Windows.Forms.Button();
            this.odunctakipBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(407, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.KitapEkle_Click);
            // 
            // uyeekleBtn
            // 
            this.uyeekleBtn.Location = new System.Drawing.Point(131, 59);
            this.uyeekleBtn.Name = "uyeekleBtn";
            this.uyeekleBtn.Size = new System.Drawing.Size(150, 126);
            this.uyeekleBtn.TabIndex = 1;
            this.uyeekleBtn.Text = "Üye Ekle";
            this.uyeekleBtn.UseVisualStyleBackColor = true;
            this.uyeekleBtn.Click += new System.EventHandler(this.uyeekleBtn_Click);
            // 
            // ktplarıgörBtn
            // 
            this.ktplarıgörBtn.Location = new System.Drawing.Point(407, 297);
            this.ktplarıgörBtn.Name = "ktplarıgörBtn";
            this.ktplarıgörBtn.Size = new System.Drawing.Size(158, 134);
            this.ktplarıgörBtn.TabIndex = 2;
            this.ktplarıgörBtn.Text = "Kitapları Görüntüle";
            this.ktplarıgörBtn.UseVisualStyleBackColor = true;
            this.ktplarıgörBtn.Click += new System.EventHandler(this.ktplarıgörBtn_Click);
            // 
            // KullaniciIslemleriBtn
            // 
            this.KullaniciIslemleriBtn.Location = new System.Drawing.Point(131, 297);
            this.KullaniciIslemleriBtn.Name = "KullaniciIslemleriBtn";
            this.KullaniciIslemleriBtn.Size = new System.Drawing.Size(156, 126);
            this.KullaniciIslemleriBtn.TabIndex = 3;
            this.KullaniciIslemleriBtn.Text = "Üye İşlemleri";
            this.KullaniciIslemleriBtn.UseVisualStyleBackColor = true;
            this.KullaniciIslemleriBtn.Click += new System.EventHandler(this.KullaniciIslemleriBtn_Click);
            // 
            // oduncverBtn
            // 
            this.oduncverBtn.Location = new System.Drawing.Point(723, 59);
            this.oduncverBtn.Name = "oduncverBtn";
            this.oduncverBtn.Size = new System.Drawing.Size(147, 126);
            this.oduncverBtn.TabIndex = 4;
            this.oduncverBtn.Text = "Ödünç Ver";
            this.oduncverBtn.UseVisualStyleBackColor = true;
            this.oduncverBtn.Click += new System.EventHandler(this.oduncverBtn_Click);
            // 
            // odunctakipBtn
            // 
            this.odunctakipBtn.Location = new System.Drawing.Point(723, 297);
            this.odunctakipBtn.Name = "odunctakipBtn";
            this.odunctakipBtn.Size = new System.Drawing.Size(153, 132);
            this.odunctakipBtn.TabIndex = 5;
            this.odunctakipBtn.Text = "Ödünç Takip";
            this.odunctakipBtn.UseVisualStyleBackColor = true;
            this.odunctakipBtn.Click += new System.EventHandler(this.odunctakipBtn_Click);
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 565);
            this.Controls.Add(this.odunctakipBtn);
            this.Controls.Add(this.oduncverBtn);
            this.Controls.Add(this.KullaniciIslemleriBtn);
            this.Controls.Add(this.ktplarıgörBtn);
            this.Controls.Add(this.uyeekleBtn);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AnaPencere";
            this.Text = "Gümüşhane Kütüphanesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaPencere_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uyeekleBtn;
        private System.Windows.Forms.Button ktplarıgörBtn;
        private System.Windows.Forms.Button KullaniciIslemleriBtn;
        private System.Windows.Forms.Button oduncverBtn;
        private System.Windows.Forms.Button odunctakipBtn;
    }
}