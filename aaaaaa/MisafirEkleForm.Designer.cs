namespace PlakaTanimaSistemi
{
    partial class MisafirEkleForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblPlakaNo = new System.Windows.Forms.Label();
            this.txtPlakaNo = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblZiyaretNedeni = new System.Windows.Forms.Label();
            this.txtZiyaretNedeni = new System.Windows.Forms.TextBox();
            this.lblIzinBitis = new System.Windows.Forms.Label();
            this.dtpIzinBitis = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblAdSoyad
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 30);
            this.lblAdSoyad.Text = "Ad Soyad:";

            // txtAdSoyad
            this.txtAdSoyad.Location = new System.Drawing.Point(150, 30);
            this.txtAdSoyad.Size = new System.Drawing.Size(250, 25);

            // lblPlakaNo
            this.lblPlakaNo.AutoSize = true;
            this.lblPlakaNo.Location = new System.Drawing.Point(30, 70);
            this.lblPlakaNo.Text = "Plaka No:";

            // txtPlakaNo
            this.txtPlakaNo.Location = new System.Drawing.Point(150, 70);
            this.txtPlakaNo.Size = new System.Drawing.Size(250, 25);

            // lblTelefon
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 110);
            this.lblTelefon.Text = "Telefon:";

            // txtTelefon
            this.txtTelefon.Location = new System.Drawing.Point(150, 110);
            this.txtTelefon.Size = new System.Drawing.Size(250, 25);

            // lblZiyaretNedeni
            this.lblZiyaretNedeni.AutoSize = true;
            this.lblZiyaretNedeni.Location = new System.Drawing.Point(30, 150);
            this.lblZiyaretNedeni.Text = "Ziyaret Nedeni:";

            // txtZiyaretNedeni
            this.txtZiyaretNedeni.Location = new System.Drawing.Point(150, 150);
            this.txtZiyaretNedeni.Size = new System.Drawing.Size(250, 25);
            this.txtZiyaretNedeni.Multiline = true;
            this.txtZiyaretNedeni.Height = 60;

            // lblIzinBitis
            this.lblIzinBitis.AutoSize = true;
            this.lblIzinBitis.Location = new System.Drawing.Point(30, 225);
            this.lblIzinBitis.Text = "İzin Bitiş Tarihi:";

            // dtpIzinBitis
            this.dtpIzinBitis.Location = new System.Drawing.Point(150, 225);
            this.dtpIzinBitis.Size = new System.Drawing.Size(250, 25);
            this.dtpIzinBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(150, 270);
            this.btnKaydet.Size = new System.Drawing.Size(110, 45);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnIptal
            this.btnIptal.Location = new System.Drawing.Point(280, 270);
            this.btnIptal.Size = new System.Drawing.Size(110, 45);
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(450, 340);
            this.Controls.Add(this.dtpIzinBitis);
            this.Controls.Add(this.lblIzinBitis);
            this.Controls.Add(this.txtZiyaretNedeni);
            this.Controls.Add(this.lblZiyaretNedeni);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtPlakaNo);
            this.Controls.Add(this.lblPlakaNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Name = "MisafirEkleForm";
            this.Text = "Misafir Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblPlakaNo;
        private System.Windows.Forms.TextBox txtPlakaNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblZiyaretNedeni;
        private System.Windows.Forms.TextBox txtZiyaretNedeni;
        private System.Windows.Forms.Label lblIzinBitis;
        private System.Windows.Forms.DateTimePicker dtpIzinBitis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}