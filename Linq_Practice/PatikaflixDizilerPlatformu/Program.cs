using System;
using System.Collections.Generic;
using System.Linq;

public class Dizi
{
    public string DiziAdi { get; set; }
    public int YapimYili { get; set; }
    public string Turu { get; set; }
    public int YayinlanmayaBaslamaYili { get; set; }
    public string Yonetmen { get; set; }
    public string YayindigiIlkPlatform { get; set; }
}

class Program
{
    static void Main()
    {
        // Dizi listesi oluşturuluyor
        List<Dizi> diziler = new List<Dizi>
        {
            new Dizi { DiziAdi = "Avrupa Yakası", YapimYili = 2004, Turu = "Komedi", YayinlanmayaBaslamaYili = 2004, Yonetmen = "Yüksel Aksu", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { DiziAdi = "Yalan Dünya", YapimYili = 2012, Turu = "Komedi", YayinlanmayaBaslamaYili = 2012, Yonetmen = "Gülse Birsel", YayindigiIlkPlatform = "Fox TV" },
            new Dizi { DiziAdi = "Jet Sosyete", YapimYili = 2018, Turu = "Komedi", YayinlanmayaBaslamaYili = 2018, Yonetmen = "Gülse Birsel", YayindigiIlkPlatform = "TV8" },
            new Dizi { DiziAdi = "Dadı", YapimYili = 2006, Turu = "Komedi", YayinlanmayaBaslamaYili = 2006, Yonetmen = "Yusuf Pirhasan", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { DiziAdi = "Belalı Baldız", YapimYili = 2007, Turu = "Komedi", YayinlanmayaBaslamaYili = 2007, Yonetmen = "Yüksel Aksu", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { DiziAdi = "Arka Sokaklar", YapimYili = 2007, Turu = "Polisiye, Dram", YayinlanmayaBaslamaYili = 2007, Yonetmen = "Orhan Oğuz", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { DiziAdi = "Aşk-ı Memnu", YapimYili = 2008, Turu = "Dram, Romantik", YayinlanmayaBaslamaYili = 2008, Yonetmen = "Hilal Saral", YayindigiIlkPlatform = "Kanal D" },
            new Dizi { DiziAdi = "Muhteşem Yüzyıl", YapimYili = 2011, Turu = "Tarihi, Dram", YayinlanmayaBaslamaYili = 2011, Yonetmen = "Mercan Çilingiroğlu", YayindigiIlkPlatform = "Star TV" },
            new Dizi { DiziAdi = "Yaprak Dökümü", YapimYili = 2006, Turu = "Dram", YayinlanmayaBaslamaYili = 2006, Yonetmen = "Serdar Akar", YayindigiIlkPlatform = "Kanal D" }
        };

        // Komedi türündeki dizilerden yeni bir liste oluştur
        var komediDizileri = diziler.Where(d => d.Turu.Contains("Komedi"))
                                    .Select(d => new { d.DiziAdi, d.Turu, d.Yonetmen })
                                    .ToList();

        // Komedi dizilerini yazdır
        Console.WriteLine("Komedi Dizileri:");
        komediDizileri.ForEach(d => Console.WriteLine($"Dizi Adı: {d.DiziAdi}, Türü: {d.Turu}, Yönetmen: {d.Yonetmen}"));

        // Tüm dizileri yönetmen ismine göre sıralı olarak yazdır
        var tumDiziler = diziler.OrderBy(d => d.Yonetmen).ToList();
        Console.WriteLine("\nTüm Diziler (Yönetmen Sırasına Göre):");
        tumDiziler.ForEach(d => Console.WriteLine($"Dizi Adı: {d.DiziAdi}, Türü: {d.Turu}, Yönetmen: {d.Yonetmen}"));
    }
}
