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
            this.uyelisteleDgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uyelisteleDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // uyelisteleDgw
            // 
            this.uyelisteleDgw.AllowUserToAddRows = false;
            this.uyelisteleDgw.AllowUserToDeleteRows = false;
            this.uyelisteleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyelisteleDgw.Location = new System.Drawing.Point(6, 13);
            this.uyelisteleDgw.Name = "uyelisteleDgw";
            this.uyelisteleDgw.RowHeadersWidth = 51;
            this.uyelisteleDgw.RowTemplate.Height = 24;
            this.uyelisteleDgw.Size = new System.Drawing.Size(672, 438);
            this.uyelisteleDgw.TabIndex = 0;
            this.uyelisteleDgw.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uyelisteleDgw_CellMouseClick);
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
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView uyelisteleDgw;
    }
}