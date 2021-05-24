using OtoGaleriOtomasyonu.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyonu.DataAccess.Concrete
{
    public class SatisDal
    {
        OtoGaleriContext context = new OtoGaleriContext();

        public List<SatisDetayDto> GetirSatisDetayDtoList()
        {
            var query = from satislar in context.Satislar
                        join araclar in context.Araclar
                        on satislar.AracId equals araclar.Id
                        join musteriler in context.Musteriler
                        on satislar.MusteriId equals musteriler.Id
                        join markalar in context.Markalar
                        on araclar.MarkaId equals markalar.Id
                        join modeller in context.Modeller
                        on araclar.ModelId equals modeller.Id
                        select new SatisDetayDto
                        {
                            AracMarka = markalar.MarkaAdi,
                            AracModel = modeller.ModelAdi,
                            AracPlaka = araclar.Plaka,
                            Id = araclar.Id,
                            MusteriAdSoyad = musteriler.MAd+ " "+ musteriler.MSoyad,
                            SatisFiyati = satislar.SatisFiyati,
                            SatisTarihi = satislar.SatisTarihi
                        };

            return query.ToList();
        }
    }
}
