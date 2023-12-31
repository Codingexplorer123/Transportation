﻿using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationEntity;

namespace Transportation.Data.DummyData
{
    public class DataGeneratorRezervasyon
    {
        public static List<Rezervasyon> RezervasyonListesi(int adet)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            for (int i = 1; i < adet; i++)
            {

                var result = new Faker<Rezervasyon>()

                    .RuleFor(a => a.NakliyeFirmasiAdi, f => f.Company.CompanyName() + " " + f.PickRandom
                    (new string[] { "Logistik", "Nakliyat", "Tasimacilik", "Ulastirma" }))
                    .RuleFor(a => a.NakliyeFirmasiEmail, (f, a) => f.Internet.Email(a.NakliyeFirmasiAdi));
                    
                    
                Rezervasyon rezervasyon = result.Generate();
                rezervasyon.RezervasyonId = i;
                
                rezervasyonlar.Add(rezervasyon);

            }

            return rezervasyonlar;
        }
    }
}
