using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationEntity;

namespace Transportation.Data.DummyData
{
    public class DataGeneratorNakliye
    { 
            public static List<Nakliye> NakliyeListesi(int adet)
            {
                List<Nakliye> nakliyeler = new List<Nakliye>();
                for (int i = 1; i < adet; i++)
                {
                
                var result = new Faker<Nakliye>()
                    
                    .RuleFor(a => a.NakliyeYapildimi, f => f.Random.Bool())
                    .RuleFor(a => a.TalepTarihi, f => f.Date.Past(3));

                Nakliye nakliye = result.Generate();
                nakliye.NakliyeId = i;
                nakliye.AracId = i;
                nakliye.RezervasyonId = i;
                nakliyeler.Add(nakliye);

                }

               return nakliyeler;
            }
           

        
    }
}
