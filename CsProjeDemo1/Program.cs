using System;
using System.Collections.Generic;
using CsProjeDemo1.Entities;
using CsProjeDemo1.Entities.Abstraction;
using CsProjeDemo1.Enums;

namespace CSProjeDemo1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Örnek kullanım
            Kutuphane kutuphane = new Kutuphane();

            //// Örnek kitaplar oluşturulur
            //Kitap bilimKitabi = new KitapBilim { ISBN = "123456789", Baslik = "Bilim Kitabı", Yazar = "Bilim Adamı", YayinYili = 2020, Durum = Durum.OduncAlabilir };
            //Kitap romanKitabi = new KitapRoman { ISBN = "987654321", Baslik = "Roman Kitabı", Yazar = "Roman Yazarı", YayinYili = 2019, Durum = Durum.OduncAlabilir };

            // Kitaplar kütüphaneye eklenir
            //kutuphane.KitapEkle(bilimKitabi);
            //kutuphane.KitapEkle(romanKitabi);

           
           

            // Üye kütüphaneye eklenir
            //kutuphane.UyeEkle(uye);

            // Kitap ödünç alınır ve iade edilir
            //uye.KitapOduncAl(bilimKitabi);
            //uye.KitapOduncAl(romanKitabi);
            //uye.OduncAlinanKitaplariGoruntule();
            //uye.KitapIadeEt(bilimKitabi);
            //uye.OduncAlinanKitaplariGoruntule();

            // Kütüphane kataloğu ve üyeler görüntülenir
            
            //kutuphane.KataloguGoruntule();
            //kutuphane.UyeleriGoruntule();
        }
    }
}
