using System.ComponentModel.DataAnnotations;

namespace BootcampEf.Data
{
    public class Ogrenci{
        // id => primary key
        public int OgrenciId { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

    }
}