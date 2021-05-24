using OtoGaleriOtomasyonu.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyonu.DataAccess.Concrete
{
    public class AracDal
    {
        OtoGaleriContext context = new OtoGaleriContext();

        public List<AracDetayDto> GetirAracDetayDtoList()
        {
            var query = from araclar in context.Araclar
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        join yakitturleri in context.YakitTurleri
                        on araclar.YakitTurId equals yakitturleri.Id
                        select new AracDetayDto
                        {
                            Fiyat = araclar.Fiyat,
                            Id = araclar.Id,
                            Kilometre = araclar.Kilometre,
                            Marka = markalar.MarkaAdi,
                            Model = modeller.ModelAdi,
                            ModelYili = araclar.ModelYili,
                            Plaka = araclar.Plaka,
                            Renk = araclar.Renk,
                            RuhsatNo = araclar.RuhsatNo,
                            SasiNo = araclar.SasiNo,
                            YakitTur = yakitturleri.YakitTuru,
                            SatilmaDurumu = araclar.SatildiMi == true ? "Satıldı" : "Satılık"
                        };

            return query.ToList();
        }

        public List<AracDetayDto> GetirAracDetayDtoList(int vasitaTurId, int modelId, int markaId)
        {
            var query = from araclar in context.Araclar
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        join yakitturleri in context.YakitTurleri
                        on araclar.YakitTurId equals yakitturleri.Id
                        where araclar.VasitaTurId == vasitaTurId
                        where araclar.ModelId == modelId
                        where araclar.MarkaId == markaId
                        select new AracDetayDto
                        {
                            Fiyat = araclar.Fiyat,
                            Id = araclar.Id,
                            Kilometre = araclar.Kilometre,
                            Marka = markalar.MarkaAdi,
                            Model = modeller.ModelAdi,
                            ModelYili = araclar.ModelYili,
                            Plaka = araclar.Plaka,
                            Renk = araclar.Renk,
                            RuhsatNo = araclar.RuhsatNo,
                            SasiNo = araclar.SasiNo,
                            YakitTur = yakitturleri.YakitTuru,
                            SatilmaDurumu = araclar.SatildiMi == true ? "Satıldı" : "Satılık"
                        };

            return query.ToList();
        }

        public List<AracDetayDto> GetirAracDetayDtoList(string ruhsatNo, string plaka)
        {
            var query = from araclar in context.Araclar
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        join yakitturleri in context.YakitTurleri
                        on araclar.YakitTurId equals yakitturleri.Id

                        where araclar.RuhsatNo.ToLower() == ruhsatNo.ToLower() || araclar.Plaka.ToLower() == plaka.ToLower()
                        select new AracDetayDto
                        {
                            Fiyat = araclar.Fiyat,
                            Id = araclar.Id,
                            Kilometre = araclar.Kilometre,
                            Marka = markalar.MarkaAdi,
                            Model = modeller.ModelAdi,
                            ModelYili = araclar.ModelYili,
                            Plaka = araclar.Plaka,
                            Renk = araclar.Renk,
                            RuhsatNo = araclar.RuhsatNo,
                            SasiNo = araclar.SasiNo,
                            YakitTur = yakitturleri.YakitTuru,
                            SatilmaDurumu = araclar.SatildiMi == true ? "Satıldı" : "Satılık"
                        };

            return query.ToList();
        }

        public List<AracDetayDto> GetirSatılıkAracDetayDtoList()
        {
            var query = from araclar in context.Araclar
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        join yakitturleri in context.YakitTurleri
                        on araclar.YakitTurId equals yakitturleri.Id
                        where araclar.SatildiMi == false
                        select new AracDetayDto
                        {
                            Fiyat = araclar.Fiyat,
                            Id = araclar.Id,
                            Kilometre = araclar.Kilometre,
                            Marka = markalar.MarkaAdi,
                            Model = modeller.ModelAdi,
                            ModelYili = araclar.ModelYili,
                            Plaka = araclar.Plaka,
                            Renk = araclar.Renk,
                            RuhsatNo = araclar.RuhsatNo,
                            SasiNo = araclar.SasiNo,
                            YakitTur = yakitturleri.YakitTuru,
                            SatilmaDurumu = araclar.SatildiMi == true ? "Satıldı" : "Satılık"
                        };

            return query.ToList();
        }

        public List<AracDetayDto> GetirSatılanAracDetayDtoList()
        {
            var query = from araclar in context.Araclar
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        join yakitturleri in context.YakitTurleri
                        on araclar.YakitTurId equals yakitturleri.Id
                        where araclar.SatildiMi == true
                        select new AracDetayDto
                        {
                            Fiyat = araclar.Fiyat,
                            Id = araclar.Id,
                            Kilometre = araclar.Kilometre,
                            Marka = markalar.MarkaAdi,
                            Model = modeller.ModelAdi,
                            ModelYili = araclar.ModelYili,
                            Plaka = araclar.Plaka,
                            Renk = araclar.Renk,
                            RuhsatNo = araclar.RuhsatNo,
                            SasiNo = araclar.SasiNo,
                            YakitTur = yakitturleri.YakitTuru,
                            SatilmaDurumu = araclar.SatildiMi == true ? "Satıldı" : "Satılık"
                        };

            return query.ToList();
        }

        public List<AracDetayDto> GetirAracDetayDtoByAracId(int aracId)
        {
            var query = from araclar in context.Araclar
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        join yakitturleri in context.YakitTurleri
                        on araclar.YakitTurId equals yakitturleri.Id
                        where araclar.Id == aracId
                        select new AracDetayDto
                        {
                            Fiyat = araclar.Fiyat,
                            Id = araclar.Id,
                            Kilometre = araclar.Kilometre,
                            Marka = markalar.MarkaAdi,
                            Model = modeller.ModelAdi,
                            ModelYili = araclar.ModelYili,
                            Plaka = araclar.Plaka,
                            Renk = araclar.Renk,
                            RuhsatNo = araclar.RuhsatNo,
                            SasiNo = araclar.SasiNo,
                            YakitTur = yakitturleri.YakitTuru,
                            SatilmaDurumu = araclar.SatildiMi == true ? "Satıldı" : "Satılık"
                        };

            return query.ToList();
        }
    }
}
