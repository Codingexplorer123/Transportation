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
                for (int i = 0; i < adet; i++)
                {
                var NakliyeId = 1;
                var result = new Faker<Nakliye>()
                    .RuleFor(a => a.NakliyeId, _ => ++NakliyeId)
                    .RuleFor(a => a.NakliyeYapildimi, f => f.Random.Bool())
                    .RuleFor(a => a.TalepTarihi, f => f.Date.Past(3));

                Nakliye nakliye = result.Generate();
                
                nakliyeler.Add(nakliye);

                }

               return nakliyeler;
            }
           

        
    }
}
