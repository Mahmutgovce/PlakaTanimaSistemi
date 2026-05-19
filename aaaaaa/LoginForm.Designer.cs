namespace PlakaTanimaSistemi
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(80, 30);
            this.lblBaslik.Text = "PLAKA TANIMA SİSTEMİ";
            this.lblBaslik.ForeColor = System.Drawing.Color.DarkBlue;

            // lblKullaniciAdi
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(60, 100);
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";

            // txtKullaniciAdi
            this.txtKullaniciAdi.Location = new System.Drawing.Point(170, 100);
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 25);

            // lblSifre
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(60, 140);
            this.lblSifre.Text = "Şifre:";

            // txtSifre
            this.txtSifre.Location = new System.Drawing.Point(170, 140);
            this.txtSifre.Size = new System.Drawing.Size(200, 25);
            this.txtSifre.PasswordChar = '*';

            // btnGiris
            this.btnGiris.Location = new System.Drawing.Point(170, 190);
            this.btnGiris.Size = new System.Drawing.Size(120, 45);
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            // btnCikis
            this.btnCikis.Location = new System.Drawing.Point(310, 190);
            this.btnCikis.Size = new System.Drawing.Size(100, 45);
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "LoginForm";
            this.Text = "Giriş - Plaka Tanıma Sistemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
    }
}