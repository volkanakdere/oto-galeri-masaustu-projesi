using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Domains
{
    public class Satis
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public int MusteriId { get; set; }
        public decimal SatisFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
