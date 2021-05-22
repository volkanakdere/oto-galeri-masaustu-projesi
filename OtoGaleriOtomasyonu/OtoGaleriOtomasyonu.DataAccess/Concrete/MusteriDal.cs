using OtoGaleriOtomasyonu.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtoGaleriOtomasyonu.DataAccess.Concrete
{
    public class MusteriDal
    {
        OtoGaleriContext context = new OtoGaleriContext();

        public List<MusteriDetayDto> GetirMusteriDetayDtolist()
        {
            var query = from musteri in context.Musteriler
                        
                         select new MusteriDetayDto
                        {
                             MusteriAdı= musteri.MAd,

                             MusteriSoyadı= musteri.MSoyad,
                             MusteriCinsiyet= musteri.MCinsiyet,
                             MusteriTelefon=musteri.MTelefon,
                             MusteriEPosta=musteri.MEposta,
                             Id=musteri.Id
                         
                        };
            return query.ToList();
        }
    }
}
