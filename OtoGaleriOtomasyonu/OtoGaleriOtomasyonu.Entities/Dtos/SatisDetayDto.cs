using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyonu.Entities.Dtos
{
    public class SatisDetayDto
    {
        public int Id { get; set; }
        public string AracPlaka { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public string MusteriAdSoyad { get; set; }
        public decimal SatisFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
