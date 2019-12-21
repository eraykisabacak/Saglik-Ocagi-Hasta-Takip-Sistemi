namespace SOHATS
{
    partial class KulTanit
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
            this.cbKullaniciKodu = new System.Windows.Forms.ComboBox();
            this.btnYeniKullanici = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // cbKullaniciKodu
            // 
            this.cbKullaniciKodu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullaniciKodu.FormattingEnabled = true;
            this.cbKullaniciKodu.Location = new System.Drawing.Point(154, 45);
            this.cbKullaniciKodu.Name = "cbKullaniciKodu";
            this.cbKullaniciKodu.Size = new System.Drawing.Size(154, 32);
            this.cbKullaniciKodu.TabIndex = 1;
            this.cbKullaniciKodu.SelectedValueChanged += new System.EventHandler(this.cbKullaniciKodu_SelectedValueChanged);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYeniKullanici.ForeColor = System.Drawing.Color.Green;
            this.btnYeniKullanici.Location = new System.Drawing.Point(35, 83);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(251, 33);
            this.btnYeniKullanici.TabIndex = 9;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullanici.UseVisualStyleBackColor = false;
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "SOHATS - Kullanıcı Tanıtma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KulTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 122);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.cbKullaniciKodu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KulTanit";
            this.Text = "SOHATS - Kullanıcı Tanıtma ";
            this.Load += new System.EventHandler(this.KulTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKullaniciKodu;
        private System.Windows.Forms.Button btnYeniKullanici;
        private System.Windows.Forms.Label label2;
    }
}