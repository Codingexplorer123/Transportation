using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationEntity
{
    public enum AracTipi
    {
        Kamyon=1,
        Tir,
        Kamyonet,
        Pickup
    }

    public class Arac
    {
        public int AracId { get; set; }
        public AracTipi AracTipi { get; set; } 
        
        
        public string AracSoforuIsim { get; set; }
       
        public string AracSoforuSoyisim { get; set; }
        public string AracPlakaNo { get; set; }
        
        public string AracSoforuTelNo { get; set; }
        
        public string FirmaTelNo { get; set; }

        public Rezervasyon? Rezervasyon { get; set; }
        public Nakliye? Nakliye { get; set; }
    }
}
