using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlakaTanimaSistemi
{
    public partial class MisafirEkleForm : Form
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\GVCE\Desktop\PlakaSistemi\PlakaTanımaSistemi\aaaaaa\PlakaDB.mdf';Integrated Security=True";

        public MisafirEkleForm()
        {
            InitializeComponent();
            dtpIzinBitis.Value = DateTime.Now.AddDays(1); // Varsayılan 1 gün sonrası
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtPlakaNo.Text))
            {
                MessageBox.Show("Ad Soyad ve Plaka No alanları zorunludur!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Misafirler Tablosuna Ekle
                    string query1 = @"INSERT INTO Misafirler 
                                    (AdSoyad, PlakaNo, Telefon, ZiyaretNedeni, IzinBitisTarihi) 
                                    VALUES (@adsoyad, @plaka, @telefon, @neden, @izinBitis)";

                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text.Trim());
                        cmd1.Parameters.AddWithValue("@plaka", txtPlakaNo.Text.Trim().ToUpper());
                        cmd1.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                        cmd1.Parameters.AddWithValue("@neden", txtZiyaretNedeni.Text.Trim());
                        cmd1.Parameters.AddWithValue("@izinBitis", dtpIzinBitis.Value);
                        cmd1.ExecuteNonQuery();
                    }

                    // Geçiş Kayıtlarına da Ekle
                    string query2 = @"INSERT INTO GecisKayitlari 
                                    (PlakaNo, Kamera, Durum, KayitTuru) 
                                    VALUES (@plaka, 'CAM 01', 'Aktif', 'Misafir')";

                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@plaka", txtPlakaNo.Text.Trim().ToUpper());
                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Misafir başarıyla eklendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}