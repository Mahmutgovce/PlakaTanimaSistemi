using System;

namespace PlakaTanimlamaSistemi.Models
{
    public class Plaka
    {
        public int Id { get; set; }
        public string PlakaNo { get; set; } = string.Empty;
        public string Sahibi { get; set; } = string.Empty;
        public string AracTipi { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}