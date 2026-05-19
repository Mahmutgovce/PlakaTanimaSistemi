using PlakaTanimaSistemi;
using System;
using System.Windows.Forms;

namespace PlakaTanimaSistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            // Basit demo giriş (İstersen veritabanından da kontrol edebiliriz)
            if (kullanici == "admin" && sifre == "12345")
            {
                this.Hide(); // Login formunu gizle

                Form1 anaForm = new Form1();
                anaForm.ShowDialog(); // Ana formu aç

                this.Close(); // Login formunu kapat
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!\n\nDemo için:\nKullanıcı: admin\nŞifre: 12345",
                    "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSifre.Clear();
                txtSifre.Focus();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}