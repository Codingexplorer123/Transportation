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
        public int NakliyeId { get; set; }

        public DateTime? RezervasyonTarihi { get; set; }
        public string NakliyeFirmasiAdi { get; set; }

        [DataType(DataType.EmailAddress)]
        public string NakliyeFirmasiEmail { get; set; }

        public Nakliye Nakliye { get; set; }

    }
}
//The dependent side could not be determined for the one-to-one relationship between 'Nakliye.Rezervasyon' and 'Rezervasyon.Nakliye'.
//To identify the dependent side of the relationship, configure the foreign key property.
//If these navigations should not be part of the same relationship, configure them independently via separate method chains in 'OnModelCreating'. 
//See http://go.microsoft.com/fwlink/?LinkId=724062 for more details.