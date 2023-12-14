using System.ComponentModel.DataAnnotations;
using BootcampEf.Data;

namespace BootcampEf.Models
{
    public class KursViewModel
    {
        public int KursId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Kurs Başlığı")]
        public string? Baslik { get; set; }
        public int OgretmenId{get; set;}
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();

    }
}