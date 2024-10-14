using System;

namespace KisiAracYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kisi kisi = new Kisi
            {
                Ad = "Murat",
                Soyad = "Taşyürek",
                DogumYili = 1985,
                TCKimlikNo = "12345678901"
            };

            
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Lütfen {i}. aracın bilgilerini girin:");

                Console.Write("Şasi Numarası: ");
                string sasiNumarasi = Console.ReadLine();

                Console.Write("Tür: ");
                string tur = Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Yıl: ");
                int yil = int.Parse(Console.ReadLine());

                Console.Write("Marka: ");
                string marka = Console.ReadLine();

                Console.Write("Edinme Tarihi (yyyy-mm-dd): ");
                DateTime edinmeTarihi = DateTime.Parse(Console.ReadLine());

                Console.Write("Edinme Fiyatı: ");
                decimal edinmeFiyati = decimal.Parse(Console.ReadLine());

                Arac arac = new Arac
                {
                    SasiNumarasi = sasiNumarasi,
                    Tur = tur,
                    Model = model,
                    Yil = yil,
                    Marka = marka,
                    EdinmeTarihi = edinmeTarihi,
                    EdinmeFiyati = edinmeFiyati
                };

               
                for (int j = 1; j <= (i == 1 ? 3 : i == 2 ? 4 : i == 3 ? 5 : 2); j++)
                {
                    Console.Write($"Lütfen {j}. sahibin adını girin: ");
                    string sahibi = Console.ReadLine();
                    arac.Sahipler.Add(sahibi);
                }

                
                arac.Sahipler.Add($"{kisi.Ad} {kisi.Soyad}");

                kisi.AracEkle(arac);
            }

            
            kisi.AraclariListele();

            
            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
