namespace PlakaTanimaSistemi
{
    partial class plakaEkleForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.lblPlakaNo = new System.Windows.Forms.Label();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.lblSahibi = new System.Windows.Forms.Label();
            this.txtSahibi = new System.Windows.Forms.TextBox();
            this.lblAracTipi = new System.Windows.Forms.Label();
            this.txtAracTipi = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblKayitTuru = new System.Windows.Forms.Label();
            this.cmbKayitTuru = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblPlakaNo
            this.lblPlakaNo.AutoSize = true;
            this.lblPlakaNo.Location = new System.Drawing.Point(40, 40);
            this.lblPlakaNo.Name = "lblPlakaNo";
            this.lblPlakaNo.Size = new System.Drawing.Size(71, 20);
            this.lblPlakaNo.TabIndex = 11;
            this.lblPlakaNo.Text = "Plaka No:";

            // txtPlakaNo
            this.txtPlakaNo.Location = new System.Drawing.Point(160, 40);
            this.txtPlakaNo.Name = "txtPlakaNo";
            this.txtPlakaNo.Size = new System.Drawing.Size(220, 27);
            this.txtPlakaNo.TabIndex = 10;

            // lblSahibi
            this.lblSahibi.AutoSize = true;
            this.lblSahibi.Location = new System.Drawing.Point(40, 80);
            this.lblSahibi.Name = "lblSahibi";
            this.lblSahibi.Size = new System.Drawing.Size(53, 20);
            this.lblSahibi.TabIndex = 9;
            this.lblSahibi.Text = "Sahibi:";

            // txtSahibi
            this.txtSahibi.Location = new System.Drawing.Point(160, 80);
            this.txtSahibi.Name = "txtSahibi";
            this.txtSahibi.Size = new System.Drawing.Size(220, 27);
            this.txtSahibi.TabIndex = 8;

            // lblAracTipi
            this.lblAracTipi.AutoSize = true;
            this.lblAracTipi.Location = new System.Drawing.Point(40, 120);
            this.lblAracTipi.Name = "lblAracTipi";
            this.lblAracTipi.Size = new System.Drawing.Size(71, 20);
            this.lblAracTipi.TabIndex = 7;
            this.lblAracTipi.Text = "Araç Tipi:";

            // txtAracTipi
            this.txtAracTipi.Location = new System.Drawing.Point(160, 120);
            this.txtAracTipi.Name = "txtAracTipi";
            this.txtAracTipi.Size = new System.Drawing.Size(220, 27);
            this.txtAracTipi.TabIndex = 6;

            // lblTelefon
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(40, 160);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(61, 20);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon:";

            // txtTelefon
            this.txtTelefon.Location = new System.Drawing.Point(160, 160);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 27);
            this.txtTelefon.TabIndex = 4;

            // lblKayitTuru
            this.lblKayitTuru.AutoSize = true;
            this.lblKayitTuru.Location = new System.Drawing.Point(40, 200);
            this.lblKayitTuru.Name = "lblKayitTuru";
            this.lblKayitTuru.Size = new System.Drawing.Size(78, 20);
            this.lblKayitTuru.TabIndex = 3;
            this.lblKayitTuru.Text = "Kayıt Türü:";

            // cmbKayitTuru
            this.cmbKayitTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKayitTuru.Location = new System.Drawing.Point(160, 200);
            this.cmbKayitTuru.Name = "cmbKayitTuru";
            this.cmbKayitTuru.Size = new System.Drawing.Size(220, 28);
            this.cmbKayitTuru.TabIndex = 2;

            // btnKaydet
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(0, 150, 0);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(160, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 45);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnIptal
            this.btnIptal.Location = new System.Drawing.Point(280, 250);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 45);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // plakaEkleForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbKayitTuru);
            this.Controls.Add(this.lblKayitTuru);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAracTipi);
            this.Controls.Add(this.lblAracTipi);
            this.Controls.Add(this.txtSahibi);
            this.Controls.Add(this.lblSahibi);
            this.Controls.Add(this.txtPlakaNo);
            this.Controls.Add(this.lblPlakaNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PlakaEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Plaka Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblPlakaNo;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.Label lblSahibi;
        private System.Windows.Forms.TextBox txtSahibi;
        private System.Windows.Forms.Label lblAracTipi;
        private System.Windows.Forms.TextBox txtAracTipi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblKayitTuru;
        private System.Windows.Forms.ComboBox cmbKayitTuru;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}