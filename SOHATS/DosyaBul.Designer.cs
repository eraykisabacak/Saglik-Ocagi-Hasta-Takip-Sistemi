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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAd = new System.Windows.Forms.Panel();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAd.SuspendLayout();
            this.pnlOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri";
            // 
            // cbSecenek
            // 
            this.cbSecenek.FormattingEnabled = true;
            this.cbSecenek.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum SicilNo",
            "Dosya No"});
            this.cbSecenek.Location = new System.Drawing.Point(148, 12);
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
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(202, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 28);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "ve";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(249, 3);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(194, 29);
            this.txtSoyad.TabIndex = 4;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBul.Location = new System.Drawing.Point(817, 13);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(71, 29);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 476);
            this.dataGridView1.TabIndex = 6;
            // 
            // pnlAd
            // 
            this.pnlAd.Controls.Add(this.txtAd);
            this.pnlAd.Controls.Add(this.checkBox1);
            this.pnlAd.Controls.Add(this.txtSoyad);
            this.pnlAd.Location = new System.Drawing.Point(351, 12);
            this.pnlAd.Name = "pnlAd";
            this.pnlAd.Size = new System.Drawing.Size(446, 40);
            this.pnlAd.TabIndex = 7;
            // 
            // pnlOther
            // 
            this.pnlOther.Controls.Add(this.txtArama);
            this.pnlOther.Location = new System.Drawing.Point(349, 10);
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
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 545);
            this.Controls.Add(this.pnlOther);
            this.Controls.Add(this.pnlAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.cbSecenek);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DosyaBul";
            this.Text = "< Dosya Bul >";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlAd;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.TextBox txtArama;
    }
}