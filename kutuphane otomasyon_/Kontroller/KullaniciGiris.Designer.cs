namespace kutuphane_otomasyon_.Kontroller
{
    partial class KullaniciGiris
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisGosterCb = new System.Windows.Forms.CheckBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.girisPb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTxt.Location = new System.Drawing.Point(137, 32);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(327, 27);
            this.emailTxt.TabIndex = 1;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(137, 94);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(327, 27);
            this.sifreTxt.TabIndex = 2;
            // 
            // girisGosterCb
            // 
            this.girisGosterCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisGosterCb.AutoSize = true;
            this.girisGosterCb.Location = new System.Drawing.Point(395, 136);
            this.girisGosterCb.Name = "girisGosterCb";
            this.girisGosterCb.Size = new System.Drawing.Size(69, 20);
            this.girisGosterCb.TabIndex = 3;
            this.girisGosterCb.Text = "Göster";
            this.girisGosterCb.UseVisualStyleBackColor = true;
            this.girisGosterCb.CheckedChanged += new System.EventHandler(this.gosterCb_CheckedChanged);
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(349, 228);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(115, 37);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            // 
            // girisPb
            // 
            this.girisPb.ForeColor = System.Drawing.Color.White;
            this.girisPb.Location = new System.Drawing.Point(263, 228);
            this.girisPb.Name = "girisPb";
            this.girisPb.Size = new System.Drawing.Size(80, 37);
            this.girisPb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.girisPb.TabIndex = 5;
            this.girisPb.Visible = false;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.girisPb);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.girisGosterCb);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGiris";
            this.Size = new System.Drawing.Size(530, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox girisGosterCb;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.TextBox sifreTxt;
        public System.Windows.Forms.Button girisBtn;
        public System.Windows.Forms.ProgressBar girisPb;
    }
}
