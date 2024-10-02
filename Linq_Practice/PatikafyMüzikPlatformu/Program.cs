using System;
using System.Collections.Generic;
using System.Linq;

public class Sanatci
{
    public string AdiSoyadi { get; set; }
    public string YaptigiMuzikTuru { get; set; }
    public int CikisYili { get; set; }
    public string AlbumSatislari { get; set; }
}

class Program
{
    static void Main()
    {
        // Sanatçı listesini oluşturuyoruz
        List<Sanatci> sanatcilar = new List<Sanatci>
        {
            new Sanatci { AdiSoyadi = "Ajda Pekkan", YaptigiMuzikTuru = "Pop", CikisYili = 1968, AlbumSatislari = "Yaklaşık 20 milyon" },
            new Sanatci { AdiSoyadi = "Sezen Aksu", YaptigiMuzikTuru = "Türk Halk Müziği / Pop", CikisYili = 1971, AlbumSatislari = "Yaklaşık 10 milyon" },
            new Sanatci { AdiSoyadi = "Funda Arar", YaptigiMuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = "Yaklaşık 3 milyon" },
            new Sanatci { AdiSoyadi = "Sertab Erener", YaptigiMuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = "Yaklaşık 5 milyon" },
            new Sanatci { AdiSoyadi = "Sıla", YaptigiMuzikTuru = "Pop", CikisYili = 2009, AlbumSatislari = "Yaklaşık 3 milyon" },
            new Sanatci { AdiSoyadi = "Serdar Ortaç", YaptigiMuzikTuru = "Pop", CikisYili = 1994, AlbumSatislari = "Yaklaşık 10 milyon" },
            new Sanatci { AdiSoyadi = "Tarkan", YaptigiMuzikTuru = "Pop", CikisYili = 1992, AlbumSatislari = "Yaklaşık 40 milyon" },
            new Sanatci { AdiSoyadi = "Hande Yener", YaptigiMuzikTuru = "Pop", CikisYili = 1999, AlbumSatislari = "Yaklaşık 7 milyon" },
            new Sanatci { AdiSoyadi = "Hadise", YaptigiMuzikTuru = "Pop", CikisYili = 2005, AlbumSatislari = "Yaklaşık 5 milyon" },
            new Sanatci { AdiSoyadi = "Gülben Ergen", YaptigiMuzikTuru = "Pop / Türk Halk Müziği", CikisYili = 1997, AlbumSatislari = "Yaklaşık 10 milyon" },
            new Sanatci { AdiSoyadi = "Neşet Ertaş", YaptigiMuzikTuru = "Türk Halk Müziği / Türk Sanat Müziği", CikisYili = 1960, AlbumSatislari = "Yaklaşık 2 milyon" }
        };

        // 'S' ile başlayan şarkıcılar
        var sIleBaslayanSanatcilar = sanatcilar.Where(s => s.AdiSoyadi.StartsWith("S")).ToList();
        Console.WriteLine("'S' ile Başlayan Sanatçılar:");
        sIleBaslayanSanatcilar.ForEach(s => Console.WriteLine(s.AdiSoyadi));

        // Albüm satışları 10 milyonun üzerinde olan şarkıcılar
        var satisiOnMilyonUstundeOlanlar = sanatcilar.Where(s => int.Parse(s.AlbumSatislari.Split(' ')[1]) > 10).ToList();
        Console.WriteLine("\nAlbüm Satışları 10 Milyonun Üzerinde Olan Sanatçılar:");
        satisiOnMilyonUstundeOlanlar.ForEach(s => Console.WriteLine(s.AdiSoyadi));

        // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
        var ikiBinOncesiPopSanatcilar = sanatcilar.Where(s => s.CikisYili < 2000 && s.YaptigiMuzikTuru.Contains("Pop"))
                                                  .OrderBy(s => s.CikisYili)
                                                  .ThenBy(s => s.AdiSoyadi)
                                                  .ToList();
        Console.WriteLine("\n2000 Yılı Öncesi Pop Müzik Yapan Sanatçılar:");
        ikiBinOncesiPopSanatcilar.ForEach(s => Console.WriteLine($"{s.CikisYili} - {s.AdiSoyadi}"));

        // En çok albüm satan şarkıcı
        var enCokSatanSanatci = sanatcilar.OrderByDescending(s => int.Parse(s.AlbumSatislari.Split(' ')[1])).FirstOrDefault();
        Console.WriteLine($"\nEn Çok Albüm Satan Sanatçı: {enCokSatanSanatci.AdiSoyadi}");

        // En yeni ve en eski çıkış yapan şarkıcı
        var enYeniSanatci = sanatcilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
        var enEskiSanatci = sanatcilar.OrderBy(s => s.CikisYili).FirstOrDefault();
        Console.WriteLine($"\nEn Yeni Çıkış Yapan Sanatçı: {enYeniSanatci.AdiSoyadi} ({enYeniSanatci.CikisYili})");
        Console.WriteLine($"En Eski Çıkış Yapan Sanatçı: {enEskiSanatci.AdiSoyadi} ({enEskiSanatci.CikisYili})");
    }
}
