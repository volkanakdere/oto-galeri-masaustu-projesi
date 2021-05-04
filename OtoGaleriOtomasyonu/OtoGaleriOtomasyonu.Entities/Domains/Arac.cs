using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleriOtomasyonu.Entities.Domains
{
    public class Arac
    {
        public int Id { get; set; }
        public string SasiNo { get; set; }
        public string RuhsatNo { get; set; }
        public string Plaka { get; set; }
        public int VasitaTurId { get; set; }
        public int MarkaId { get; set; }
        public int ModelId { get; set; }
        public int ModelYili { get; set; }
        public string Renk { get; set; }
        public int YakitTurId { get; set; }
        public string MotorGucu { get; set; }
        public int MotorHacmi { get; set; }
        public string HasarKaydiVarMi { get; set; }
        public decimal HasarKaydiTutari { get; set; }
        public DateTime SonBakimTarihi { get; set; }
        public DateTime SonMuayeneTarihi { get; set; }
        public int Kilometre { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
        public int VitesTipId { get; set; }
        public int KasaTipId { get; set; }
        public bool SatildiMi { get; set; }
    }
}
