using System;

namespace PlakaTanimaSistemi.Models
{
    public class GecisKayit
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string PlakaNo { get; set; } = string.Empty;
        public string Kamera { get; set; } = "CAM 01";
        public string Durum { get; set; } = "Aktif";
        public string KayitTuru { get; set; } = "Manuel";
    }
}