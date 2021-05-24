using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyonu.Entities.Dtos
{
    public class MusteriDetayDto
    {
        public int Id { get; set; }
        public string MusteriAdı { get; set; }
        public string MusteriSoyadı { get; set; }
        public string MusteriCinsiyet { get; set; }
        public string MusteriTelefon { get; set; }
        public string MusteriEPosta { get; set; }
        public string FullName => MusteriAdı + " " + MusteriSoyadı;
    }
}
