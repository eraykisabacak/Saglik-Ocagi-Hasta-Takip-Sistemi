namespace SOHATS
{
    partial class PoliTanit
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
            this.cbPoliklinikAdi = new System.Windows.Forms.ComboBox();
            this.cbGecerli = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // cbPoliklinikAdi
            // 
            this.cbPoliklinikAdi.FormattingEnabled = true;
            this.cbPoliklinikAdi.Location = new System.Drawing.Point(132, 48);
            this.cbPoliklinikAdi.Margin = new System.Windows.Forms.Padding(6);
            this.cbPoliklinikAdi.Name = "cbPoliklinikAdi";
            this.cbPoliklinikAdi.Size = new System.Drawing.Size(219, 32);
            this.cbPoliklinikAdi.TabIndex = 1;
            this.cbPoliklinikAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPoliklinikAdi_KeyDown);
            // 
            // cbGecerli
            // 
            this.cbGecerli.AutoSize = true;
            this.cbGecerli.Location = new System.Drawing.Point(152, 82);
            this.cbGecerli.Margin = new System.Windows.Forms.Padding(6);
            this.cbGecerli.Name = "cbGecerli";
            this.cbGecerli.Size = new System.Drawing.Size(178, 28);
            this.cbGecerli.TabIndex = 2;
            this.cbGecerli.Text = "Geçerli / Geçersiz";
            this.cbGecerli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "SOHATS - Poliklinik Tanıtma";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoliTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 129);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGecerli);
            this.Controls.Add(this.cbPoliklinikAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PoliTanit";
            this.Text = "SOHATS - Poliklinik Tanıtma";
            this.Load += new System.EventHandler(this.PoliTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPoliklinikAdi;
        private System.Windows.Forms.CheckBox cbGecerli;
        private System.Windows.Forms.Label label2;
    }
}