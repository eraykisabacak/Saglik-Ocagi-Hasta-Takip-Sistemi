namespace SOHATS
{
    partial class KullaniciPage
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
            this.txtKullaniciKodu = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUnvan = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpİseBaslama = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbMedeniHali = new System.Windows.Forms.ComboBox();
            this.cbKanGrubu = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbYetkili = new System.Windows.Forms.CheckBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // txtKullaniciKodu
            // 
            this.txtKullaniciKodu.Enabled = false;
            this.txtKullaniciKodu.Location = new System.Drawing.Point(183, 20);
            this.txtKullaniciKodu.MaxLength = 9;
            this.txtKullaniciKodu.Name = "txtKullaniciKodu";
            this.txtKullaniciKodu.Size = new System.Drawing.Size(334, 29);
            this.txtKullaniciKodu.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(183, 55);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(334, 29);
            this.txtTC.TabIndex = 2;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "T.C Kimlik Numarası";
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(183, 126);
            this.txtBabaAdi.MaxLength = 20;
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(334, 29);
            this.txtBabaAdi.TabIndex = 4;
            this.txtBabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Baba Adı";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(183, 91);
            this.txtDogumYeri.MaxLength = 50;
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(334, 29);
            this.txtDogumYeri.TabIndex = 3;
            this.txtDogumYeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doğum Yeri";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(183, 196);
            this.txtTelefonNo.MaxLength = 11;
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(334, 29);
            this.txtTelefonNo.TabIndex = 6;
            this.txtTelefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon No";
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Location = new System.Drawing.Point(183, 161);
            this.txtAnneAdi.MaxLength = 20;
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(334, 29);
            this.txtAnneAdi.TabIndex = 5;
            this.txtAnneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Anne Adı";
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(183, 231);
            this.txtGSM.MaxLength = 11;
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(334, 29);
            this.txtGSM.TabIndex = 7;
            this.txtGSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "GSM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Unvan";
            // 
            // cbUnvan
            // 
            this.cbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnvan.FormattingEnabled = true;
            this.cbUnvan.Location = new System.Drawing.Point(657, 17);
            this.cbUnvan.Name = "cbUnvan";
            this.cbUnvan.Size = new System.Drawing.Size(334, 32);
            this.cbUnvan.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(657, 55);
            this.txtAd.MaxLength = 20;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(334, 29);
            this.txtAd.TabIndex = 10;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(657, 88);
            this.txtSoyad.MaxLength = 20;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(334, 29);
            this.txtSoyad.TabIndex = 11;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYeri_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Soyad";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(657, 123);
            this.txtMaas.MaxLength = 20;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(334, 29);
            this.txtMaas.TabIndex = 12;
            this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Maaş";
            // 
            // dtpİseBaslama
            // 
            this.dtpİseBaslama.Location = new System.Drawing.Point(657, 158);
            this.dtpİseBaslama.MaxDate = new System.DateTime(2019, 12, 16, 0, 0, 0, 0);
            this.dtpİseBaslama.Name = "dtpİseBaslama";
            this.dtpİseBaslama.Size = new System.Drawing.Size(334, 29);
            this.dtpİseBaslama.TabIndex = 13;
            this.dtpİseBaslama.Value = new System.DateTime(1995, 7, 12, 22, 45, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(541, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "İşe Başlama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(527, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Doğum Tarihi";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(657, 194);
            this.dtpDogumTarihi.MaxDate = new System.DateTime(2019, 12, 16, 0, 0, 0, 0);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(334, 29);
            this.dtpDogumTarihi.TabIndex = 14;
            this.dtpDogumTarihi.Value = new System.DateTime(1980, 12, 12, 22, 45, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(576, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cinsiyet";
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "BAY",
            "BAYAN"});
            this.cbCinsiyet.Location = new System.Drawing.Point(657, 231);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(106, 32);
            this.cbCinsiyet.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(768, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Medeni Hali";
            // 
            // cbMedeniHali
            // 
            this.cbMedeniHali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedeniHali.FormattingEnabled = true;
            this.cbMedeniHali.Items.AddRange(new object[] {
            "EVLİ",
            "BEKAR"});
            this.cbMedeniHali.Location = new System.Drawing.Point(885, 231);
            this.cbMedeniHali.Name = "cbMedeniHali";
            this.cbMedeniHali.Size = new System.Drawing.Size(106, 32);
            this.cbMedeniHali.TabIndex = 17;
            // 
            // cbKanGrubu
            // 
            this.cbKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKanGrubu.FormattingEnabled = true;
            this.cbKanGrubu.Items.AddRange(new object[] {
            "0 Rh+",
            "0 Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-"});
            this.cbKanGrubu.Location = new System.Drawing.Point(657, 269);
            this.cbKanGrubu.Name = "cbKanGrubu";
            this.cbKanGrubu.Size = new System.Drawing.Size(106, 32);
            this.cbKanGrubu.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(550, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 24);
            this.label16.TabIndex = 30;
            this.label16.Text = "Kan Grubu";
            // 
            // cbYetkili
            // 
            this.cbYetkili.AutoSize = true;
            this.cbYetkili.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbYetkili.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbYetkili.Location = new System.Drawing.Point(283, 271);
            this.cbYetkili.Name = "cbYetkili";
            this.cbYetkili.Size = new System.Drawing.Size(163, 28);
            this.cbYetkili.TabIndex = 8;
            this.cbYetkili.Text = "yetkili kullanıcı";
            this.cbYetkili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbYetkili.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(183, 318);
            this.txtAdres.MaxLength = 255;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(808, 130);
            this.txtAdres.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(117, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 24);
            this.label17.TabIndex = 34;
            this.label17.Text = "Adres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(183, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 66);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(546, 18);
            this.txtSifre.MaxLength = 20;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(217, 29);
            this.txtSifre.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(493, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 24);
            this.label19.TabIndex = 38;
            this.label19.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(154, 20);
            this.txtKullaniciAdi.MaxLength = 20;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(217, 29);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 24);
            this.label18.TabIndex = 36;
            this.label18.Text = "Kullanıcı Adı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(12, 559);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 57);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(160, 559);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 57);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(309, 559);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 57);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(878, 559);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(117, 57);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KullaniciPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 628);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cbYetkili);
            this.Controls.Add(this.cbKanGrubu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbMedeniHali);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpİseBaslama);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbUnvan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAnneAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBabaAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciKodu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KullaniciPage";
            this.ShowIcon = false;
            this.Text = "Kullanici Tanıtma";
            this.Load += new System.EventHandler(this.KullaniciPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciKodu;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUnvan;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpİseBaslama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbMedeniHali;
        private System.Windows.Forms.ComboBox cbKanGrubu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbYetkili;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnGuncelle;
    }
}