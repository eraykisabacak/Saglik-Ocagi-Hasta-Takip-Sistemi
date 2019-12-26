namespace SOHATS
{
    partial class HastaProcess
    {/// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaProcess));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOncekiIslemler = new System.Windows.Forms.ComboBox();
            this.btnGit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.cbYapilanİslem = new System.Windows.Forms.ComboBox();
            this.cbDrKodu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgwTahlilveİslemler = new System.Windows.Forms.DataGridView();
            this.POLİKLİNİK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIRANO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAPILANİSLEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRKODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MİKTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BİRİMFİYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnBaskiOnizleme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTahlilveİslemler)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No";
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBul.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(317, 8);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(69, 30);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sevk Tarihi";
            // 
            // dtpSevkTarihi
            // 
            this.dtpSevkTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSevkTarihi.Location = new System.Drawing.Point(166, 48);
            this.dtpSevkTarihi.MaxDate = new System.DateTime(2039, 12, 31, 0, 0, 0, 0);
            this.dtpSevkTarihi.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpSevkTarihi.Name = "dtpSevkTarihi";
            this.dtpSevkTarihi.Size = new System.Drawing.Size(220, 29);
            this.dtpSevkTarihi.TabIndex = 3;
            this.dtpSevkTarihi.Value = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.dtpSevkTarihi.ValueChanged += new System.EventHandler(this.cbPoliklinik_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Önceki İşlemler";
            // 
            // cbOncekiIslemler
            // 
            this.cbOncekiIslemler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOncekiIslemler.FormattingEnabled = true;
            this.cbOncekiIslemler.Location = new System.Drawing.Point(166, 85);
            this.cbOncekiIslemler.Name = "cbOncekiIslemler";
            this.cbOncekiIslemler.Size = new System.Drawing.Size(144, 32);
            this.cbOncekiIslemler.TabIndex = 4;
            // 
            // btnGit
            // 
            this.btnGit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGit.Location = new System.Drawing.Point(317, 85);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(69, 32);
            this.btnGit.TabIndex = 5;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hasta Adı:";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(514, 12);
            this.txtHastaAdi.MaxLength = 15;
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.ReadOnly = true;
            this.txtHastaAdi.Size = new System.Drawing.Size(272, 29);
            this.txtHastaAdi.TabIndex = 6;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(514, 48);
            this.txtSoyadi.MaxLength = 15;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(272, 29);
            this.txtSoyadi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Soyadı";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(514, 86);
            this.txtKurumAdi.MaxLength = 50;
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.ReadOnly = true;
            this.txtKurumAdi.Size = new System.Drawing.Size(272, 29);
            this.txtKurumAdi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kurum Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(804, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHastaBilgileri.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaBilgileri.Location = new System.Drawing.Point(811, 57);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(388, 60);
            this.btnHastaBilgileri.TabIndex = 9;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = false;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Poliklinik";
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Location = new System.Drawing.Point(4, 169);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(232, 32);
            this.cbPoliklinik.TabIndex = 10;
            this.cbPoliklinik.SelectedValueChanged += new System.EventHandler(this.cbPoliklinik_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "SIRA NO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Yapılan İşlem";
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(242, 168);
            this.txtSiraNo.MaxLength = 3;
            this.txtSiraNo.Multiline = true;
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.ReadOnly = true;
            this.txtSiraNo.Size = new System.Drawing.Size(220, 33);
            this.txtSiraNo.TabIndex = 11;
            // 
            // cbYapilanİslem
            // 
            this.cbYapilanİslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYapilanİslem.FormattingEnabled = true;
            this.cbYapilanİslem.Location = new System.Drawing.Point(468, 169);
            this.cbYapilanİslem.Name = "cbYapilanİslem";
            this.cbYapilanİslem.Size = new System.Drawing.Size(266, 32);
            this.cbYapilanİslem.TabIndex = 12;
            this.cbYapilanİslem.SelectedValueChanged += new System.EventHandler(this.cbYapilanİslem_SelectedValueChanged);
            // 
            // cbDrKodu
            // 
            this.cbDrKodu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrKodu.FormattingEnabled = true;
            this.cbDrKodu.Location = new System.Drawing.Point(740, 169);
            this.cbDrKodu.Name = "cbDrKodu";
            this.cbDrKodu.Size = new System.Drawing.Size(93, 32);
            this.cbDrKodu.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(746, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Dr. Kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(867, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 24;
            this.label12.Text = "Miktar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(958, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Birim Fiyat";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(948, 169);
            this.txtBirimFiyat.MaxLength = 20;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.ReadOnly = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(124, 29);
            this.txtBirimFiyat.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(1078, 143);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 58);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgwTahlilveİslemler
            // 
            this.dgwTahlilveİslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTahlilveİslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTahlilveİslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.POLİKLİNİK,
            this.SIRANO,
            this.SAAT,
            this.YAPILANİSLEM,
            this.DRKODU,
            this.MİKTAR,
            this.BİRİMFİYAT,
            this.id});
            this.dgwTahlilveİslemler.Location = new System.Drawing.Point(10, 30);
            this.dgwTahlilveİslemler.Name = "dgwTahlilveİslemler";
            this.dgwTahlilveİslemler.ReadOnly = true;
            this.dgwTahlilveİslemler.Size = new System.Drawing.Size(1179, 316);
            this.dgwTahlilveİslemler.TabIndex = 17;
            // 
            // POLİKLİNİK
            // 
            this.POLİKLİNİK.HeaderText = "POLİKLİNİK";
            this.POLİKLİNİK.Name = "POLİKLİNİK";
            this.POLİKLİNİK.ReadOnly = true;
            // 
            // SIRANO
            // 
            this.SIRANO.HeaderText = "SIRA NO";
            this.SIRANO.Name = "SIRANO";
            this.SIRANO.ReadOnly = true;
            // 
            // SAAT
            // 
            this.SAAT.HeaderText = "SAAT";
            this.SAAT.Name = "SAAT";
            this.SAAT.ReadOnly = true;
            // 
            // YAPILANİSLEM
            // 
            this.YAPILANİSLEM.HeaderText = "YAPILAN İŞLEM";
            this.YAPILANİSLEM.Name = "YAPILANİSLEM";
            this.YAPILANİSLEM.ReadOnly = true;
            // 
            // DRKODU
            // 
            this.DRKODU.HeaderText = "DR.KODU";
            this.DRKODU.Name = "DRKODU";
            this.DRKODU.ReadOnly = true;
            // 
            // MİKTAR
            // 
            this.MİKTAR.HeaderText = "MİKTAR";
            this.MİKTAR.Name = "MİKTAR";
            this.MİKTAR.ReadOnly = true;
            // 
            // BİRİMFİYAT
            // 
            this.BİRİMFİYAT.HeaderText = "BİRİM FİYATI";
            this.BİRİMFİYAT.Name = "BİRİMFİYAT";
            this.BİRİMFİYAT.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTutar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dgwTahlilveİslemler);
            this.groupBox1.Location = new System.Drawing.Point(3, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 395);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.DarkBlue;
            this.lblTutar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.Red;
            this.lblTutar.Location = new System.Drawing.Point(1109, 358);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(49, 25);
            this.lblTutar.TabIndex = 31;
            this.lblTutar.Text = "0 TL";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.BackColor = System.Drawing.Color.DarkBlue;
            this.label14.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(855, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(331, 43);
            this.label14.TabIndex = 30;
            this.label14.Text = "Toplam Tutar:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYeni.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.ForeColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(19, 623);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(121, 58);
            this.btnYeni.TabIndex = 18;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSecSil.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecSil.ForeColor = System.Drawing.Color.Red;
            this.btnSecSil.Location = new System.Drawing.Point(146, 623);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(121, 58);
            this.btnSecSil.TabIndex = 19;
            this.btnSecSil.Text = "Seç - Sil";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTaburcu.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaburcu.ForeColor = System.Drawing.Color.Yellow;
            this.btnTaburcu.Location = new System.Drawing.Point(316, 622);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(121, 58);
            this.btnTaburcu.TabIndex = 20;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = false;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnYazdir.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.Black;
            this.btnYazdir.Location = new System.Drawing.Point(453, 622);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(121, 58);
            this.btnYazdir.TabIndex = 21;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnBaskiOnizleme
            // 
            this.btnBaskiOnizleme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBaskiOnizleme.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaskiOnizleme.ForeColor = System.Drawing.Color.Black;
            this.btnBaskiOnizleme.Location = new System.Drawing.Point(581, 622);
            this.btnBaskiOnizleme.Name = "btnBaskiOnizleme";
            this.btnBaskiOnizleme.Size = new System.Drawing.Size(121, 58);
            this.btnBaskiOnizleme.TabIndex = 22;
            this.btnBaskiOnizleme.Text = "Baskı Önizleme";
            this.btnBaskiOnizleme.UseVisualStyleBackColor = false;
            this.btnBaskiOnizleme.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCikis.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(1068, 622);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(121, 58);
            this.btnCikis.TabIndex = 23;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(165, 9);
            this.txtDosyaNo.MaxLength = 10;
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(146, 29);
            this.txtDosyaNo.TabIndex = 1;
            this.txtDosyaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDosyaNo_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(851, 170);
            this.nudMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(91, 29);
            this.nudMiktar.TabIndex = 11;
            this.nudMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HastaProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 683);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnBaskiOnizleme);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTaburcu);
            this.Controls.Add(this.btnSecSil);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbDrKodu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbYapilanİslem);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPoliklinik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnHastaBilgileri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.cbOncekiIslemler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSevkTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HastaProcess";
            this.Text = "Hasta işlemleri";
            this.Load += new System.EventHandler(this.HastaProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTahlilveİslemler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSevkTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOncekiIslemler;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.ComboBox cbYapilanİslem;
        private System.Windows.Forms.ComboBox cbDrKodu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgwTahlilveİslemler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnBaskiOnizleme;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn POLİKLİNİK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIRANO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAPILANİSLEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRKODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MİKTAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BİRİMFİYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.NumericUpDown nudMiktar;
    }
}