namespace SOHATS
{
    partial class DosyaBul
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSecenek = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cbVe = new System.Windows.Forms.CheckBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.dgwHasta = new System.Windows.Forms.DataGridView();
            this.tckimlikno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babaadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAd = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHasta)).BeginInit();
            this.pnlAd.SuspendLayout();
            this.pnlOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri";
            // 
            // cbSecenek
            // 
            this.cbSecenek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecenek.FormattingEnabled = true;
            this.cbSecenek.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum SicilNo",
            "Dosya No"});
            this.cbSecenek.Location = new System.Drawing.Point(274, 6);
            this.cbSecenek.Name = "cbSecenek";
            this.cbSecenek.Size = new System.Drawing.Size(176, 32);
            this.cbSecenek.TabIndex = 1;
            this.cbSecenek.SelectedValueChanged += new System.EventHandler(this.cbSecenek_SelectedValueChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(2, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(194, 29);
            this.txtAd.TabIndex = 2;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // cbVe
            // 
            this.cbVe.AutoSize = true;
            this.cbVe.Checked = true;
            this.cbVe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVe.Location = new System.Drawing.Point(202, 4);
            this.cbVe.Name = "cbVe";
            this.cbVe.Size = new System.Drawing.Size(49, 28);
            this.cbVe.TabIndex = 3;
            this.cbVe.Text = "ve";
            this.cbVe.UseVisualStyleBackColor = true;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(249, 3);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(194, 29);
            this.txtSoyad.TabIndex = 4;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBul.Location = new System.Drawing.Point(943, 7);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(71, 29);
            this.btnBul.TabIndex = 20;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // dgwHasta
            // 
            this.dgwHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tckimlikno,
            this.dosyano,
            this.ad,
            this.soyad,
            this.dogumyeri,
            this.dogumtarihi,
            this.babaadi,
            this.anneadi,
            this.cinsiyet});
            this.dgwHasta.Location = new System.Drawing.Point(12, 55);
            this.dgwHasta.Name = "dgwHasta";
            this.dgwHasta.Size = new System.Drawing.Size(1144, 476);
            this.dgwHasta.TabIndex = 30;
            // 
            // tckimlikno
            // 
            this.tckimlikno.HeaderText = "TC Kimlik No";
            this.tckimlikno.Name = "tckimlikno";
            // 
            // dosyano
            // 
            this.dosyano.HeaderText = "Dosya No";
            this.dosyano.Name = "dosyano";
            // 
            // ad
            // 
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            // 
            // soyad
            // 
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            // 
            // dogumyeri
            // 
            this.dogumyeri.HeaderText = "Doğum Yeri";
            this.dogumyeri.Name = "dogumyeri";
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.HeaderText = "Doğum Tarihi";
            this.dogumtarihi.Name = "dogumtarihi";
            // 
            // babaadi
            // 
            this.babaadi.HeaderText = "Baba Adı";
            this.babaadi.Name = "babaadi";
            // 
            // anneadi
            // 
            this.anneadi.HeaderText = "Anne Adı";
            this.anneadi.Name = "anneadi";
            // 
            // cinsiyet
            // 
            this.cinsiyet.HeaderText = "Cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            // 
            // pnlAd
            // 
            this.pnlAd.Controls.Add(this.txtAd);
            this.pnlAd.Controls.Add(this.cbVe);
            this.pnlAd.Controls.Add(this.txtSoyad);
            this.pnlAd.Location = new System.Drawing.Point(491, 6);
            this.pnlAd.Name = "pnlAd";
            this.pnlAd.Size = new System.Drawing.Size(446, 40);
            this.pnlAd.TabIndex = 7;
            // 
            // pnlOther
            // 
            this.pnlOther.Controls.Add(this.txtArama);
            this.pnlOther.Location = new System.Drawing.Point(486, 5);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(448, 40);
            this.pnlOther.TabIndex = 8;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(7, 8);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(438, 29);
            this.txtArama.TabIndex = 5;
            this.txtArama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArama_KeyPress);
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 545);
            this.Controls.Add(this.pnlOther);
            this.Controls.Add(this.pnlAd);
            this.Controls.Add(this.dgwHasta);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.cbSecenek);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DosyaBul";
            this.Text = "< Dosya Bul >";
            ((System.ComponentModel.ISupportInitialize)(this.dgwHasta)).EndInit();
            this.pnlAd.ResumeLayout(false);
            this.pnlAd.PerformLayout();
            this.pnlOther.ResumeLayout(false);
            this.pnlOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSecenek;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.CheckBox cbVe;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView dgwHasta;
        private System.Windows.Forms.Panel pnlAd;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyano;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn babaadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
    }
}