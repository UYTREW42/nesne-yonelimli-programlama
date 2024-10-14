using System;
using System.Collections.Generic;

namespace KisiAracYonetimSistemi
{
    public class Arac
    {
        public string SasiNumarasi { get; set; }
        public string Tur { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Marka { get; set; }
        public DateTime EdinmeTarihi { get; set; }
        public decimal EdinmeFiyati { get; set; }
        public List<string> Sahipler { get; set; }

        public Arac()
        {
            Sahipler = new List<string>();
        }
    }
}
