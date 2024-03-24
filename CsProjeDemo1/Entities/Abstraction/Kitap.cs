using CsProjeDemo1.Enums;

namespace CsProjeDemo1.Entities.Abstraction
{
    // Kitap abstract class
    public  class Kitap
    {
        public string? ISBN { get; set; }
        public string? Baslik { get; set; }
        public string? Yazar { get; set; }
        public int YayinYili { get; set; }
        public Durum Durum { get; set; }

        public int? UyeId { get; set; }
        public Uye? Uye { get; set; }
    }
}
