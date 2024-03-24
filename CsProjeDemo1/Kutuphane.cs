using CsProjeDemo1.Entities.Abstraction;
using CsProjeDemo1.Enums;

namespace CSProjeDemo1
{
    // Kütüphane sınıfı
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<IUye> Uyeler { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<IUye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }

        public void UyeEkle(IUye uye)
        {
            Uyeler.Add(uye);
        }

        public void KitapDurumunuGuncelle(Kitap kitap, Durum durum)
        {
            kitap.Durum = durum;
        }

        public void KataloguGoruntule()
        {
            Console.WriteLine("Kütüphane Kataloğu:");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik} ({kitap.Durum})");
            }
        }

        public void UyeleriGoruntule()
        {
            Console.WriteLine("Üyeler:");
            foreach (var uye in Uyeler)
            {
                Console.WriteLine($"- {uye.Ad} {uye.Soyad} (Üye No: {uye.UyeNo})");
            }
        }
    }
}
