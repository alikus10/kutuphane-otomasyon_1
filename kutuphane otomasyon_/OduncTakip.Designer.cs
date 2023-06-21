namespace kutuphane_otomasyon_
{
    partial class OduncTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncTakip));
            this.odunctakipDgw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.odunctakipDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // odunctakipDgw
            // 
            this.odunctakipDgw.AllowUserToAddRows = false;
            this.odunctakipDgw.AllowUserToDeleteRows = false;
            this.odunctakipDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odunctakipDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.odunctakipDgw.Location = new System.Drawing.Point(22, 27);
            this.odunctakipDgw.Name = "odunctakipDgw";
            this.odunctakipDgw.RowHeadersWidth = 51;
            this.odunctakipDgw.RowTemplate.Height = 24;
            this.odunctakipDgw.Size = new System.Drawing.Size(739, 499);
            this.odunctakipDgw.TabIndex = 0;
            // 
            // OduncTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 567);
            this.Controls.Add(this.odunctakipDgw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OduncTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OduncTakip";
            ((System.ComponentModel.ISupportInitialize)(this.odunctakipDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView odunctakipDgw;
    }
}