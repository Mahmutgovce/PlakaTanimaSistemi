using System;

namespace PlakaTanimlamaSistemi.Models
{
    public class Misafir
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; } = string.Empty;
        public string PlakaNo { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string ZiyaretNedeni { get; set; } = string.Empty;
        public DateTime GirisTarihi { get; set; } = DateTime.Now;
    }
}