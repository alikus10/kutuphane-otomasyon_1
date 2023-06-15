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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(145, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 126);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kitap Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.KitapEkle_Click);
            // 
            // uyeekleBtn
            // 
            this.uyeekleBtn.Location = new System.Drawing.Point(453, 54);
            this.uyeekleBtn.Name = "uyeekleBtn";
            this.uyeekleBtn.Size = new System.Drawing.Size(146, 126);
            this.uyeekleBtn.TabIndex = 1;
            this.uyeekleBtn.Text = "Üye Ekle";
            this.uyeekleBtn.UseVisualStyleBackColor = true;
            this.uyeekleBtn.Click += new System.EventHandler(this.uyeekleBtn_Click);
            // 
            // AnaPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 578);
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
    }
}