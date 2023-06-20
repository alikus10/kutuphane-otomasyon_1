namespace kutuphane_otomasyon_
{
    partial class Uyeİslemleri
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
            this.uyelisteleDgw = new System.Windows.Forms.DataGridView();
            this.uyeislemMs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.uyelisteleDgw)).BeginInit();
            this.uyeislemMs.SuspendLayout();
            this.SuspendLayout();
            // 
            // uyelisteleDgw
            // 
            this.uyelisteleDgw.AllowUserToAddRows = false;
            this.uyelisteleDgw.AllowUserToDeleteRows = false;
            this.uyelisteleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyelisteleDgw.ContextMenuStrip = this.uyeislemMs;
            this.uyelisteleDgw.Location = new System.Drawing.Point(6, 13);
            this.uyelisteleDgw.Name = "uyelisteleDgw";
            this.uyelisteleDgw.RowHeadersWidth = 51;
            this.uyelisteleDgw.RowTemplate.Height = 24;
            this.uyelisteleDgw.Size = new System.Drawing.Size(672, 438);
            this.uyelisteleDgw.TabIndex = 0;
            // 
            // uyeislemMs
            // 
            this.uyeislemMs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uyeislemMs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.uyeislemMs.Name = "uyeislemMs";
            this.uyeislemMs.Size = new System.Drawing.Size(211, 80);
            this.uyeislemMs.Opening += new System.ComponentModel.CancelEventHandler(this.uyeislemMs_Opening);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Uyeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 482);
            this.Controls.Add(this.uyelisteleDgw);
            this.Name = "Uyeİslemleri";
            this.Text = "Üye İslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.uyelisteleDgw)).EndInit();
            this.uyeislemMs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView uyelisteleDgw;
        private System.Windows.Forms.ContextMenuStrip uyeislemMs;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}