using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;

namespace PlakaTanimaSistemi
{
    public partial class Form1 : Form
    {
        private VideoCapture capture = null;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            SaatGuncelle();

            VeritabaniOlustur();
            KayitlariYukle();
            DgvSutunlariniDuzenle();
            IstatistikleriGuncelle();
        }



        private void SaatGuncelle()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                if (lblTarihSaat != null)
                    lblTarihSaat.Text = DateTime.Now.ToString("dd MMMM yyyy  HH:mm:ss");
            };
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (lblTarihSaat != null)
            {
                lblTarihSaat.Text = DateTime.Now.ToString("dd MMMM yyyy  HH:mm:ss");
            }
        }



        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                using (var frame = capture.QueryFrame())
                {
                    if (frame != null)
                    {
                        pictureBoxKamera.Invoke(new Action(() =>
                        {
                            pictureBoxKamera.Image = frame.ToBitmap();
                        }));
                    }
                }
            }
            catch { }
        }


        private void VeritabaniOlustur()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string query = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'GecisKayitlari')
            BEGIN
                CREATE TABLE GecisKayitlari (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Tarih DATETIME DEFAULT GETDATE(),
                    PlakaNo NVARCHAR(20) NOT NULL,
                    Kamera NVARCHAR(20) DEFAULT 'CAM 01',
                    Durum NVARCHAR(20) DEFAULT 'Aktif',
                    KayitTuru NVARCHAR(30) DEFAULT 'Manuel'
                )
            END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (capture != null)
            {
                capture.Stop();
                capture.Dispose();
            }
            base.OnFormClosing(e);
        }
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GVCE\Desktop\PlakaSistemi\PlakaTanımaSistemi\aaaaaa\PlakaDB.mdf;Integrated Security=True";


        private void KayitlariYukle()
        {
            dgvKayitlar.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT TOP 30 Tarih, PlakaNo, Kamera, Durum FROM GecisKayitlari ORDER BY Tarih DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvKayitlar.Rows.Add(
                                Convert.ToDateTime(dr["Tarih"]).ToString("HH:mm:ss"),
                                dr["PlakaNo"].ToString(),
                                dr["Kamera"].ToString(),
                                dr["Durum"].ToString()
                            );
                        }
                    }
                }
            }
        }
        private void btnKameraBaslat_Click_1(object sender, EventArgs e)
        {
            if (capture == null)
            {

                DialogResult sonuc = MessageBox.Show(
                    "Kamera erişimine izin vermek istiyor musunuz?\n\n",
                    "Kamera İzni",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.No)
                {
                    MessageBox.Show("Kamera erişimi reddedildi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                try
                {
                    capture = new VideoCapture(0);
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    capture.Start();

                    btnKameraBaslat.Text = "Kamerayı Durdur";
                    btnKameraBaslat.BackColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kamera açılamadı!\n\n" + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Kamera açıksa kapat
            {
                capture.Stop();
                capture.Dispose();
                capture = null;

                btnKameraBaslat.Text = "Kamerayı Başlat";
                btnKameraBaslat.BackColor = Color.FromArgb(0, 122, 204);
                pictureBoxKamera.Image = null;
            }
        }

        private void btnTani_Click_1(object sender, EventArgs e)
        {
            // Plaka girişi al
            string plaka = Microsoft.VisualBasic.Interaction.InputBox(
                "Sorgulanacak Plaka No'yu giriniz:",
                "Plaka Sorgu",
                "").Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(plaka))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = @"SELECT p.Sahibi, p.Telefon, p.AracTipi 
                           FROM Plakalar p 
                           WHERE p.PlakaNo = @plaka";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@plaka", plaka);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string sahibi = reader["Sahibi"].ToString();
                                string telefon = reader["Telefon"].ToString();
                                string aracTipi = reader["AracTipi"].ToString();

                                lblPlaka.Text = plaka;
                                lblConfidence.Text = "Sorgu Başarılı ✓";

                                string mesaj = $"Plaka: {plaka}\n\n" +
                                              $"Sahibi     : {sahibi}\n" +
                                              $"Telefon    : {telefon}\n" +
                                              $"Araç Tipi  : {aracTipi}";

                                MessageBox.Show(mesaj, "Plaka Sorgu Sonucu",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                lblPlaka.Text = plaka;
                                lblConfidence.Text = "Bulunamadı ✗";
                                MessageBox.Show($"Veritabanında '{plaka}' plakası bulunamadı!",
                                    "Plaka Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorgu sırasında hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlakaEkle_Click(object sender, EventArgs e)
        {
            plakaEkleForm form = new plakaEkleForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                KayitlariYukle();
            }
        }
        private void DgvSutunlariniDuzenle()
        {
            dgvKayitlar.Columns.Clear();

            dgvKayitlar.Columns.Add("Saat", "Saat");
            dgvKayitlar.Columns.Add("Plaka", "Plaka");
            dgvKayitlar.Columns.Add("Kamera", "Kamera");
            dgvKayitlar.Columns.Add("Durum", "Durum");
            dgvKayitlar.Columns.Add("KayitTuru", "Kayıt Türü");


            dgvKayitlar.Columns[0].Width = 80;
            dgvKayitlar.Columns[1].Width = 130;
            dgvKayitlar.Columns[2].Width = 90;
            dgvKayitlar.Columns[3].Width = 100;
            dgvKayitlar.Columns[4].Width = 120;
        }

        private void IstatistikleriGuncelle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Toplam Araç
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Plakalar", conn))
                    {
                        object sonuc = cmd.ExecuteScalar();
                        lblToplamArac.Text = $"Toplam Araç: {sonuc ?? 0}";
                    }

                    // Bugün Giren
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM GecisKayitlari WHERE CAST(Tarih AS DATE) = CAST(GETDATE() AS DATE)", conn))
                    {
                        object sonuc = cmd.ExecuteScalar();
                        lblBugunGiren.Text = $"Bugün Giren: {sonuc ?? 0}";
                    }

                    // Aktif Misafir
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM Misafirler WHERE IzinBitisTarihi >= GETDATE()", conn))
                    {
                        object sonuc = cmd.ExecuteScalar();
                        lblAktifMisafir.Text = $"Aktif Misafir: {sonuc ?? 0}";
                    }

                    // Son Giriş
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT TOP 1 PlakaNo FROM GecisKayitlari ORDER BY Tarih DESC", conn))
                    {
                        object sonuc = cmd.ExecuteScalar();
                        lblSonGiris.Text = $"Son Giriş: {(sonuc != null ? sonuc.ToString() : "-")}";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("İstatistik Hatası: " + ex.Message);
            }
        }

        private void btnMisafirEkle_Click(object sender, EventArgs e)
        {
            MisafirEkleForm misafirForm = new MisafirEkleForm();
            if (misafirForm.ShowDialog() == DialogResult.OK)
            {
                KayitlariYukle(); // Ana listedeki kayıtları yenile
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}