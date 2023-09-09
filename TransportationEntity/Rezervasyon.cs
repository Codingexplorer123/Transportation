using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int NakliyatId { get; set; }

        public DateTime RezervasyonTarihi { get; set; }

        public string NakliyeTipi { get; set; }// Evden eve tasima,Ofis Tasima,buyuk hacim ve agirlikta esya tasima

        public Nakliye Nakliye { get; set; }

    }
}
