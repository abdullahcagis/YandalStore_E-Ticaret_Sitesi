namespace YandalStoreForm
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MarkaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1397, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_KategoriForm,
            this.TSMI_MarkaIslemleri,
            this.TSMI_UrunIslemleri});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // TSMI_KategoriForm
            // 
            this.TSMI_KategoriForm.Name = "TSMI_KategoriForm";
            this.TSMI_KategoriForm.Size = new System.Drawing.Size(224, 26);
            this.TSMI_KategoriForm.Text = "Kategori İşlemleri";
            this.TSMI_KategoriForm.Click += new System.EventHandler(this.TSMI_KategoriForm_Click);
            // 
            // TSMI_MarkaIslemleri
            // 
            this.TSMI_MarkaIslemleri.Name = "TSMI_MarkaIslemleri";
            this.TSMI_MarkaIslemleri.Size = new System.Drawing.Size(224, 26);
            this.TSMI_MarkaIslemleri.Text = "Marka İşlemleri";
            this.TSMI_MarkaIslemleri.Click += new System.EventHandler(this.TSMI_MarkaIslemleri_Click);
            // 
            // TSMI_UrunIslemleri
            // 
            this.TSMI_UrunIslemleri.Name = "TSMI_UrunIslemleri";
            this.TSMI_UrunIslemleri.Size = new System.Drawing.Size(224, 26);
            this.TSMI_UrunIslemleri.Text = "Ürün İşlemleri";
            this.TSMI_UrunIslemleri.Click += new System.EventHandler(this.TSMI_UrunIslemleri_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MarkaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunIslemleri;
    }
}