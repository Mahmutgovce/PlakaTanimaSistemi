namespace PlakaTanimaSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblBaslik = new Label();
            lblTarihSaat = new Label();
            pictureBoxKamera = new PictureBox();
            groupBoxTanimlama = new GroupBox();
            lblPlaka = new Label();
            lblConfidence = new Label();
            btnKameraBaslat = new Button();
            btnTani = new Button();
            btnPlakaEkle = new Button();
            btnMisafirEkle = new Button();
            dgvKayitlar = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            groupIstatistik = new GroupBox();
            lblToplamArac = new Label();
            lblBugunGiren = new Label();
            lblAktifMisafir = new Label();
            lblSonGiris = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKamera).BeginInit();
            groupBoxTanimlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).BeginInit();
            groupIstatistik.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 0, 100);
            panelHeader.Controls.Add(lblBaslik);
            panelHeader.Controls.Add(lblTarihSaat);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 60);
            panelHeader.TabIndex = 8;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.White;
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(367, 41);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "PLAKA TANIMA SİSTEMİ";
            // 
            // lblTarihSaat
            // 
            lblTarihSaat.AutoSize = true;
            lblTarihSaat.Font = new Font("Segoe UI", 12F);
            lblTarihSaat.ForeColor = Color.White;
            lblTarihSaat.Location = new Point(850, 20);
            lblTarihSaat.Name = "lblTarihSaat";
            lblTarihSaat.Size = new Size(0, 28);
            lblTarihSaat.TabIndex = 1;
            // 
            // pictureBoxKamera
            // 
            pictureBoxKamera.BackColor = Color.Black;
            pictureBoxKamera.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxKamera.Location = new Point(30, 80);
            pictureBoxKamera.Name = "pictureBoxKamera";
            pictureBoxKamera.Size = new Size(650, 400);
            pictureBoxKamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKamera.TabIndex = 7;
            pictureBoxKamera.TabStop = false;
            // 
            // groupBoxTanimlama
            // 
            groupBoxTanimlama.BackColor = Color.FromArgb(45, 45, 45);
            groupBoxTanimlama.Controls.Add(lblPlaka);
            groupBoxTanimlama.Controls.Add(lblConfidence);
            groupBoxTanimlama.ForeColor = Color.White;
            groupBoxTanimlama.Location = new Point(720, 80);
            groupBoxTanimlama.Name = "groupBoxTanimlama";
            groupBoxTanimlama.Size = new Size(420, 150);
            groupBoxTanimlama.TabIndex = 6;
            groupBoxTanimlama.TabStop = false;
            groupBoxTanimlama.Text = "ANLIK TESPİT";
            // 
            // lblPlaka
            // 
            lblPlaka.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPlaka.ForeColor = Color.Lime;
            lblPlaka.Location = new Point(30, 40);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(350, 50);
            lblPlaka.TabIndex = 0;
            // 
            // lblConfidence
            // 
            lblConfidence.Font = new Font("Segoe UI", 12F);
            lblConfidence.ForeColor = Color.Yellow;
            lblConfidence.Location = new Point(30, 100);
            lblConfidence.Name = "lblConfidence";
            lblConfidence.Size = new Size(100, 23);
            lblConfidence.TabIndex = 1;
            lblConfidence.Text = "Güven: %--";
            // 
            // btnKameraBaslat
            // 
            btnKameraBaslat.BackColor = Color.FromArgb(0, 122, 204);
            btnKameraBaslat.ForeColor = Color.White;
            btnKameraBaslat.Location = new Point(30, 500);
            btnKameraBaslat.Name = "btnKameraBaslat";
            btnKameraBaslat.Size = new Size(180, 50);
            btnKameraBaslat.TabIndex = 5;
            btnKameraBaslat.Text = "Kamerayı Başlat";
            btnKameraBaslat.UseVisualStyleBackColor = false;
            btnKameraBaslat.Click += btnKameraBaslat_Click_1;
            // 
            // btnTani
            // 
            btnTani.BackColor = Color.FromArgb(0, 122, 204);
            btnTani.ForeColor = Color.White;
            btnTani.Location = new Point(230, 500);
            btnTani.Name = "btnTani";
            btnTani.Size = new Size(180, 50);
            btnTani.TabIndex = 4;
            btnTani.Text = "Plaka Sorgu";
            btnTani.UseVisualStyleBackColor = false;
            btnTani.Click += btnTani_Click_1;
            // 
            // btnPlakaEkle
            // 
            btnPlakaEkle.BackColor = Color.FromArgb(0, 150, 0);
            btnPlakaEkle.ForeColor = Color.White;
            btnPlakaEkle.Location = new Point(430, 500);
            btnPlakaEkle.Name = "btnPlakaEkle";
            btnPlakaEkle.Size = new Size(180, 50);
            btnPlakaEkle.TabIndex = 3;
            btnPlakaEkle.Text = "Plaka Ekle";
            btnPlakaEkle.UseVisualStyleBackColor = false;
            btnPlakaEkle.Click += btnPlakaEkle_Click;
            // 
            // btnMisafirEkle
            // 
            btnMisafirEkle.BackColor = Color.FromArgb(200, 100, 0);
            btnMisafirEkle.ForeColor = Color.White;
            btnMisafirEkle.Location = new Point(630, 500);
            btnMisafirEkle.Name = "btnMisafirEkle";
            btnMisafirEkle.Size = new Size(180, 50);
            btnMisafirEkle.TabIndex = 2;
            btnMisafirEkle.Text = "Misafir Ekle";
            btnMisafirEkle.UseVisualStyleBackColor = false;
            btnMisafirEkle.Click += btnMisafirEkle_Click;
            // 
            // dgvKayitlar
            // 
            dgvKayitlar.ColumnHeadersHeight = 29;
            dgvKayitlar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvKayitlar.Location = new Point(30, 570);
            dgvKayitlar.Name = "dgvKayitlar";
            dgvKayitlar.RowHeadersWidth = 51;
            dgvKayitlar.Size = new Size(1110, 220);
            dgvKayitlar.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // groupIstatistik
            // 
            groupIstatistik.BackColor = Color.FromArgb(45, 45, 45);
            groupIstatistik.Controls.Add(lblToplamArac);
            groupIstatistik.Controls.Add(lblBugunGiren);
            groupIstatistik.Controls.Add(lblAktifMisafir);
            groupIstatistik.Controls.Add(lblSonGiris);
            groupIstatistik.ForeColor = Color.White;
            groupIstatistik.Location = new Point(720, 250);
            groupIstatistik.Name = "groupIstatistik";
            groupIstatistik.Size = new Size(420, 180);
            groupIstatistik.TabIndex = 0;
            groupIstatistik.TabStop = false;
            groupIstatistik.Text = "İSTATİSTİKLER";
            // 
            // lblToplamArac
            // 
            lblToplamArac.Font = new Font("Segoe UI", 11F);
            lblToplamArac.ForeColor = Color.White;
            lblToplamArac.Location = new Point(20, 30);
            lblToplamArac.Name = "lblToplamArac";
            lblToplamArac.Size = new Size(100, 23);
            lblToplamArac.TabIndex = 0;
            lblToplamArac.Text = "Toplam Araç: 0";
            // 
            // lblBugunGiren
            // 
            lblBugunGiren.Font = new Font("Segoe UI", 11F);
            lblBugunGiren.ForeColor = Color.White;
            lblBugunGiren.Location = new Point(20, 60);
            lblBugunGiren.Name = "lblBugunGiren";
            lblBugunGiren.Size = new Size(100, 23);
            lblBugunGiren.TabIndex = 1;
            lblBugunGiren.Text = "Bugün Giren: 0";
            // 
            // lblAktifMisafir
            // 
            lblAktifMisafir.Font = new Font("Segoe UI", 11F);
            lblAktifMisafir.ForeColor = Color.White;
            lblAktifMisafir.Location = new Point(20, 90);
            lblAktifMisafir.Name = "lblAktifMisafir";
            lblAktifMisafir.Size = new Size(100, 23);
            lblAktifMisafir.TabIndex = 2;
            lblAktifMisafir.Text = "Aktif Misafir: 0";
            // 
            // lblSonGiris
            // 
            lblSonGiris.Font = new Font("Segoe UI", 11F);
            lblSonGiris.ForeColor = Color.White;
            lblSonGiris.Location = new Point(20, 120);
            lblSonGiris.Name = "lblSonGiris";
            lblSonGiris.Size = new Size(100, 23);
            lblSonGiris.TabIndex = 3;
            lblSonGiris.Text = "Son Giriş: -";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1200, 820);
            Controls.Add(groupIstatistik);
            Controls.Add(dgvKayitlar);
            Controls.Add(btnMisafirEkle);
            Controls.Add(btnPlakaEkle);
            Controls.Add(btnTani);
            Controls.Add(btnKameraBaslat);
            Controls.Add(groupBoxTanimlama);
            Controls.Add(pictureBoxKamera);
            Controls.Add(panelHeader);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plaka Tanıma Sistemi";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKamera).EndInit();
            groupBoxTanimlama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).EndInit();
            groupIstatistik.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Kontroller
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.PictureBox pictureBoxKamera;
        private System.Windows.Forms.GroupBox groupBoxTanimlama;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblConfidence;
        private System.Windows.Forms.Button btnKameraBaslat;
        private System.Windows.Forms.Button btnTani;
        private System.Windows.Forms.Button btnPlakaEkle;
        private System.Windows.Forms.Button btnMisafirEkle;
        private System.Windows.Forms.DataGridView dgvKayitlar;
        private System.Windows.Forms.GroupBox groupIstatistik;
        private System.Windows.Forms.Label lblToplamArac;
        private System.Windows.Forms.Label lblBugunGiren;
        private System.Windows.Forms.Label lblAktifMisafir;
        private System.Windows.Forms.Label lblSonGiris;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}