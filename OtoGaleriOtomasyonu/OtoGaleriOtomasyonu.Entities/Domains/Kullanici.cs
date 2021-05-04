using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleriOtomasyonu.Entities.Domains
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KAd { get; set; }
        public string KSoyad { get; set; }
        public DateTime KDogumTarihi { get; set; }
        public string KCinsiyet { get; set; }
        public string KUnvan { get; set; }
        public string KEposta { get; set; }
        public string Parola { get; set; }


    }
}
