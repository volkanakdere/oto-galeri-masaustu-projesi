using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyonu.Entities.Dtos
{
    public class AracDetayDto
    {
        public int Id { get; set; }
        public string SasiNo { get; set; }
        public string RuhsatNo { get; set; }
        public string Plaka { get; set; }

        public string Marka { get; set; }
        public string Model { get; set; }

        public string YakitTur { get; set; }

        public int ModelYili { get; set; }
        public string Renk { get; set; }
        public int Kilometre { get; set; }
        public decimal Fiyat { get; set; }
        public string SatilmaDurumu { get; set; }
    }
}
