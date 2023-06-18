namespace kutuphane_otomasyon_
{
    partial class KitaplariGor
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
            this.kitaplisteleDgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplisteleDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // kitaplisteleDgw
            // 
            this.kitaplisteleDgw.AllowUserToAddRows = false;
            this.kitaplisteleDgw.AllowUserToDeleteRows = false;
            this.kitaplisteleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplisteleDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kitaplisteleDgw.Location = new System.Drawing.Point(45, 36);
            this.kitaplisteleDgw.Name = "kitaplisteleDgw";
            this.kitaplisteleDgw.RowHeadersWidth = 51;
            this.kitaplisteleDgw.RowTemplate.Height = 24;
            this.kitaplisteleDgw.Size = new System.Drawing.Size(308, 399);
            this.kitaplisteleDgw.TabIndex = 0;
            this.kitaplisteleDgw.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kitaplisteleDgw_CellMouseClick);
            // 
            // KitaplariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 486);
            this.Controls.Add(this.kitaplisteleDgw);
            this.Name = "KitaplariGor";
            this.Text = "KitaplariGor";
            ((System.ComponentModel.ISupportInitialize)(this.kitaplisteleDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView kitaplisteleDgw;
    }
}