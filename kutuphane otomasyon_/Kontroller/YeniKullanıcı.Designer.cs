namespace kutuphane_otomasyon_.Kontroller
{
    partial class YeniKullanıcı
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
            this.yeniGosterCb = new System.Windows.Forms.CheckBox();
            this.yeniSifreTxt = new System.Windows.Forms.TextBox();
            this.yeniEmailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tyeniSifreTxt = new System.Windows.Forms.TextBox();
            this.tYeniGoster = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yeniGosterCb
            // 
            this.yeniGosterCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yeniGosterCb.AutoSize = true;
            this.yeniGosterCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniGosterCb.Location = new System.Drawing.Point(419, 110);
            this.yeniGosterCb.Name = "yeniGosterCb";
            this.yeniGosterCb.Size = new System.Drawing.Size(69, 20);
            this.yeniGosterCb.TabIndex = 3;
            this.yeniGosterCb.Text = "Göster";
            this.yeniGosterCb.UseVisualStyleBackColor = true;
            this.yeniGosterCb.CheckedChanged += new System.EventHandler(this.yeniGosterCb_CheckedChanged);
            // 
            // yeniSifreTxt
            // 
            this.yeniSifreTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yeniSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSifreTxt.Location = new System.Drawing.Point(145, 74);
            this.yeniSifreTxt.Name = "yeniSifreTxt";
            this.yeniSifreTxt.PasswordChar = '*';
            this.yeniSifreTxt.Size = new System.Drawing.Size(338, 27);
            this.yeniSifreTxt.TabIndex = 1;
            // 
            // yeniEmailTxt
            // 
            this.yeniEmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yeniEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniEmailTxt.Location = new System.Drawing.Point(145, 16);
            this.yeniEmailTxt.Name = "yeniEmailTxt";
            this.yeniEmailTxt.Size = new System.Drawing.Size(338, 27);
            this.yeniEmailTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre Tekrar :";
            // 
            // tyeniSifreTxt
            // 
            this.tyeniSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tyeniSifreTxt.Location = new System.Drawing.Point(144, 136);
            this.tyeniSifreTxt.Name = "tyeniSifreTxt";
            this.tyeniSifreTxt.Size = new System.Drawing.Size(339, 27);
            this.tyeniSifreTxt.TabIndex = 4;
            // 
            // tYeniGoster
            // 
            this.tYeniGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tYeniGoster.AutoSize = true;
            this.tYeniGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tYeniGoster.Location = new System.Drawing.Point(419, 172);
            this.tYeniGoster.Name = "tYeniGoster";
            this.tYeniGoster.Size = new System.Drawing.Size(69, 20);
            this.tYeniGoster.TabIndex = 5;
            this.tYeniGoster.Text = "Göster";
            this.tYeniGoster.UseVisualStyleBackColor = true;
            this.tYeniGoster.CheckedChanged += new System.EventHandler(this.tYeniGoster_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kullanıcı Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // YeniKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tyeniSifreTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tYeniGoster);
            this.Controls.Add(this.yeniGosterCb);
            this.Controls.Add(this.yeniSifreTxt);
            this.Controls.Add(this.yeniEmailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniKullanıcı";
            this.Size = new System.Drawing.Size(530, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox yeniGosterCb;
        private System.Windows.Forms.TextBox yeniSifreTxt;
        private System.Windows.Forms.TextBox yeniEmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tyeniSifreTxt;
        private System.Windows.Forms.CheckBox tYeniGoster;
        private System.Windows.Forms.Button button1;
    }
}
