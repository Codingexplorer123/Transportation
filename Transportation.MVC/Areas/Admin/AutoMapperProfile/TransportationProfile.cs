using AutoMapper;
using Transportation.MVC.Areas.Admin.Models;
using TransportationEntity;

namespace Transportation.MVC.Areas.Admin.AutoMapperProfile
{
    public class TransportationProfile: Profile
    {
        public TransportationProfile()
        {
            CreateMap<NakliyeCreateDTO, Nakliye>();
            CreateMap<AracCreateDTO, Arac>();
            CreateMap<RezervasyonCreateDTO, Rezervasyon>();
            CreateMap<UserCreateDTO, MyUser>();

        }

    }
}
