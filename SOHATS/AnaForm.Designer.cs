namespace SOHATS
{
    partial class AnaForm
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
            this.referanslar = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanitma = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanıtma = new System.Windows.Forms.ToolStripMenuItem();
            this.cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKabul = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.rapor1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referanslar,
            this.hastaKabul,
            this.raporlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1343, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referanslar
            // 
            this.referanslar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logout,
            this.poliklinikTanitma,
            this.kullanıcıTanıtma,
            this.cikis});
            this.referanslar.Enabled = false;
            this.referanslar.Name = "referanslar";
            this.referanslar.Size = new System.Drawing.Size(77, 19);
            this.referanslar.Text = "Referanslar";
            this.referanslar.Visible = false;
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(167, 22);
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // poliklinikTanitma
            // 
            this.poliklinikTanitma.Name = "poliklinikTanitma";
            this.poliklinikTanitma.Size = new System.Drawing.Size(167, 22);
            this.poliklinikTanitma.Text = "Poliklinik Tanıtma";
            this.poliklinikTanitma.Click += new System.EventHandler(this.poliklinikTanitma_Click);
            // 
            // kullanıcıTanıtma
            // 
            this.kullanıcıTanıtma.Name = "kullanıcıTanıtma";
            this.kullanıcıTanıtma.Size = new System.Drawing.Size(167, 22);
            this.kullanıcıTanıtma.Text = "Kullanıcı Tanıtma";
            this.kullanıcıTanıtma.Click += new System.EventHandler(this.kullanıcıTanıtma_Click);
            // 
            // cikis
            // 
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(167, 22);
            this.cikis.Text = "Çıkış";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // hastaKabul
            // 
            this.hastaKabul.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.hastaKabul.Name = "hastaKabul";
            this.hastaKabul.Size = new System.Drawing.Size(82, 19);
            this.hastaKabul.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriToolStripMenuItem_Click);
            // 
            // raporlar
            // 
            this.raporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapor1ToolStripMenuItem});
            this.raporlar.Name = "raporlar";
            this.raporlar.Size = new System.Drawing.Size(63, 19);
            this.raporlar.Text = "Raporlar";
            // 
            // rapor1ToolStripMenuItem
            // 
            this.rapor1ToolStripMenuItem.Name = "rapor1ToolStripMenuItem";
            this.rapor1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rapor1ToolStripMenuItem.Text = "Rapor1(gecici)";
            this.rapor1ToolStripMenuItem.Click += new System.EventHandler(this.rapor1ToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 800);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem hastaKabul;
        public System.Windows.Forms.ToolStripMenuItem raporlar;
        public System.Windows.Forms.ToolStripMenuItem referanslar;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanitma;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanıtma;
        private System.Windows.Forms.ToolStripMenuItem cikis;
        public System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapor1ToolStripMenuItem;
    }
}

