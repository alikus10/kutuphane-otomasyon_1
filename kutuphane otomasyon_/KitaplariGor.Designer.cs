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
            this.components = new System.ComponentModel.Container();
            this.kitaplisteleDgw = new System.Windows.Forms.DataGridView();
            this.kitapgörMs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplisteleDgw)).BeginInit();
            this.kitapgörMs.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitaplisteleDgw
            // 
            this.kitaplisteleDgw.AllowUserToAddRows = false;
            this.kitaplisteleDgw.AllowUserToDeleteRows = false;
            this.kitaplisteleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplisteleDgw.ContextMenuStrip = this.kitapgörMs;
            this.kitaplisteleDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kitaplisteleDgw.Location = new System.Drawing.Point(45, 36);
            this.kitaplisteleDgw.Name = "kitaplisteleDgw";
            this.kitaplisteleDgw.RowHeadersWidth = 51;
            this.kitaplisteleDgw.RowTemplate.Height = 24;
            this.kitaplisteleDgw.Size = new System.Drawing.Size(308, 399);
            this.kitaplisteleDgw.TabIndex = 0;
            // 
            // kitapgörMs
            // 
            this.kitapgörMs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kitapgörMs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.kitapgörMs.Name = "kitapgörMs";
            this.kitapgörMs.Size = new System.Drawing.Size(211, 80);
            this.kitapgörMs.Opening += new System.ComponentModel.CancelEventHandler(this.kitapgörMs_Opening);
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
            // KitaplariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 486);
            this.Controls.Add(this.kitaplisteleDgw);
            this.Name = "KitaplariGor";
            this.Text = "KitaplariGor";
            ((System.ComponentModel.ISupportInitialize)(this.kitaplisteleDgw)).EndInit();
            this.kitapgörMs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView kitaplisteleDgw;
        private System.Windows.Forms.ContextMenuStrip kitapgörMs;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}