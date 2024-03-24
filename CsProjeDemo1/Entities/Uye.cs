using CsProjeDemo1.Entities.Abstraction;
using CsProjeDemo1.Enums;

namespace CsProjeDemo1.Entities
{
    // Uye sınıfı IUye interface'inden implement edilir
    public class Uye : IUye
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNo { get; set; }
        public List<Kitap> OduncKitaplar { get; set; } = new List<Kitap>();

        private Uye() { }

        public Uye(string ad, string soyad, int uyeNo)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNo = uyeNo;
            OduncKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncKitaplar.Add(kitap);
                Console.WriteLine($"'{kitap.Baslik}' adlı kitap ödünç alındı.");
            }
            else
            {
                Console.WriteLine("Bu kitap şu anda ödünç alınamaz.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                OduncKitaplar.Remove(kitap);
                kitap.Durum = Durum.OduncAlabilir;
                Console.WriteLine($"'{kitap.Baslik}' adlı kitap iade edildi.");
            }
            else
            {
                Console.WriteLine("Bu kitap size ait değil.");
            }
        }

        public void OduncAlinanKitaplariGoruntule()
        {
            Console.WriteLine($"{Ad} {Soyad}'in Ödünç Aldığı Kitaplar:");
            foreach (var kitap in OduncKitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik}");
            }
        }
    }
}
