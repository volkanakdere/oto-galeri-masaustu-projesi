using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriOtomasyonu.WindowsFormUI.Models
{
    public static class ModelHelper
    {
        public static List<SatildiMiComboboxModel> SatildiMiComboboxModels = new List<SatildiMiComboboxModel>()
        {
            new SatildiMiComboboxModel
            {
                DisplayValue ="Satılık",
                Value = 0
            },
            new SatildiMiComboboxModel
            {
                DisplayValue ="Satıldı",
                Value =1
            }
        };

        public static string[] MotorGucleri = new[] { "75 HP", "90 HP", "105 HP", "140 HP", "170 HP" };
        public static string[] MotorHacimleri = new[] { "1.0", "1.2", "1.3", "1.4", "1.5", "1.6", "2.0", "3.0" };
        public static string[] Renkler = new[] { "Beyaz", "Kırmızı", "Mavi", "Gri", "Siyah", "Gümüş Gri", "Füme", "Lacivert" };
        public static string[] HasarDurumlari = new[] { "Var", "Yok" };
        
    }
}
