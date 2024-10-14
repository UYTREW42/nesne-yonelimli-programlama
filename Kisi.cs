using System;
using System.Collections.Generic;

namespace KisiAracYonetimSistemi
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public string TCKimlikNo { get; set; }
        public List<Arac> Araclar { get; set; }

        public Kisi()
        {
            Araclar = new List<Arac>();
        }

        public void AracEkle(Arac arac)
        {
            Araclar.Add(arac);
        }

        public void AraclariListele()
        {
            foreach (var arac in Araclar)
            {
                Console.WriteLine($"Şasi Numarası: {arac.SasiNumarasi}");
                Console.WriteLine($"Sahibi: {arac.Sahipler[arac.Sahipler.Count - 1]}");
                Console.WriteLine($"Edinme Tarihi: {arac.EdinmeTarihi.ToShortDateString()}");
                Console.WriteLine($"Model Yılı: {arac.Yil}");
                Console.WriteLine($"Marka: {arac.Marka}");
                Console.WriteLine($"Model: {arac.Model}");
                Console.WriteLine($"Edinme Fiyatı: {arac.EdinmeFiyati}");
                Console.WriteLine($"Bir önceki sahibi: {arac.Sahipler[arac.Sahipler.Count - 2]}");
                Console.WriteLine();
            }
        }
    }
}
