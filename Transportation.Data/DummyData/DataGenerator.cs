using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Microsoft.Identity.Client;
using TransportationEntity;

namespace Transportation.Data.DummyData
{
    public class DataGenerator
    {

        //https://code-maze.com/data-generation-bogus-dotnet/  bogus data icin burdaki dokumantasyonu kullandim.
        private static Faker<Arac> GetAracGenerator()
        {


            var AracId = 1;
            return new Faker<Arac>()
                .RuleFor(a => a.AracId, _ => ++AracId)
                .RuleFor(a => a.AracTipi, f => f.PickRandom<AracTipi>())
                .RuleFor(a => a.AracSoforuIsim, f => f.Name.FirstName())
                .RuleFor(a => a.AracSoforuSoyisim, f => f.Name.LastName())
                .RuleFor(a => a.AracSoforuTelNo, f => f.Phone.PhoneNumber("(###) ###-####"))
                .RuleFor(a => a.FirmaTelNo, f => f.Phone.PhoneNumber("tr"));

            



        }

        public static List<Arac> AracListesi(int adet)
        {
            List<Arac> araclar = new List<Arac>();
            for (int i = 0; i < adet; i++)
            {
                var AracId = 1;
                var result= new Faker<Arac>()
                    .RuleFor(a => a.AracId, _ => ++AracId)
                    .RuleFor(a => a.AracTipi, f => f.PickRandom<AracTipi>())
                    .RuleFor(a => a.AracSoforuIsim, f => f.Name.FirstName())
                    .RuleFor(a => a.AracSoforuSoyisim, f => f.Name.LastName())
                    .RuleFor(a => a.AracSoforuTelNo, f => f.Phone.PhoneNumber("(###) ###-####"))
                    .RuleFor(a => a.FirmaTelNo, f => f.Phone.PhoneNumber("tr"));
                Arac arac = result.Generate();
                arac.AracPlakaNo = PlakaOlustur();
                araclar.Add(arac);
            }
            return araclar;
        }
       public static string PlakaOlustur()
        {
            Random rnd = new Random();    // Random sayi uretir

            string ulkekodu = "TR";          // TR plaka ulke kodu

            int sehirkodu = rnd.Next(1, 82); //Plakalardaki sehir kodu 1 ile 81 arasinda oldugundan bunu yazdim

            // plakada ilk iki karakter sayi sonraki iki karakter harf ve sonraki uc karakter rakamdan olusturdum

            char harf1 = (char)rnd.Next('A', 'Z' + 1);
            char harf2 = (char)rnd.Next('A', 'Z' + 1);

            int rakam1 = rnd.Next(0, 10);
            int rakam2 = rnd.Next(0, 10);
            int rakam3 = rnd.Next(0, 10);

            string plaka = ulkekodu + " " + sehirkodu + " " + harf1 + harf2 + " " + rakam1 + rakam2 + rakam3;
            return plaka;
        }
    }
}
