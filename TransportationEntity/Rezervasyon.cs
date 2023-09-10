using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int? NakliyeId { get; set; }

        public DateTime? RezervasyonTarihi { get; set; }
        public string NakliyeFirmasiAdi { get; set; }

        [DataType(DataType.EmailAddress)]
        public string NakliyeFirmasiEmail { get; set; }

        public Nakliye? Nakliye { get; set; }

    }
}
