using AutoMapper;
using Transportation.MVC.Models.DTOs;
using TransportationEntity;

namespace Transportation.MVC.AutoMapperProfile
{
    public class TransportationProfile : Profile
    {
        public TransportationProfile()
        {
            CreateMap<LoginDTO, MyUser>();
        }
        
    }
}
