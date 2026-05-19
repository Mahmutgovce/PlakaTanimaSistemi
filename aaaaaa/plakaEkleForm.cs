using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlakaTanimaSistemi
{
    public partial class plakaEkleForm : Form
    {
        // Bağlantı stringi
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GVCE\Desktop\PlakaSistemi\PlakaTanımaSistemi\aaaaaa\PlakaDB.mdf;Integrated Security=True";

        public plakaEkleForm()
        {
            InitializeComponent();
            cmbKayitTuru.Items.Add("Personel");
            cmbKayitTuru.Items.Add("Öğrenci");
            cmbKayitTuru.Items.Add("Öğretim Görevlisi");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlakaNo.Text) ||
                string.IsNullOrWhiteSpace(txtSahibi.Text) ||
                cmbKayitTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Plaka No, Sahibi ve Kayıt Türü alanları zorunludur!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Form1.connString))
                {
                    conn.Open();

                    string query = @"INSERT INTO Plakalar (PlakaNo, Sahibi, AracTipi, Telefon, KayıtTarihi, KayıtTuru) 
                             VALUES (@PlakaNo, @Sahibi, @AracTipi, @Telefon, GETDATE(), @KayitTuru)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PlakaNo", txtPlakaNo.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Sahibi", txtSahibi.Text.Trim());
                        cmd.Parameters.AddWithValue("@AracTipi", txtAracTipi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@KayitTuru", cmbKayitTuru.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Plaka başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPlakaNo.Clear();
                txtSahibi.Clear();
                txtAracTipi.Clear();
                txtTelefon.Clear();
                cmbKayitTuru.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {

        }
    }
}