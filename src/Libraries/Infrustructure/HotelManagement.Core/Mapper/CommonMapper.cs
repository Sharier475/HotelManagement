using AutoMapper;
using HotelManagement.Services.Model;

namespace HotelManagement.Core.Mapper
{
    public  class CommonMapper : Profile
    {
        public CommonMapper() 
        {
            CreateMap<VmGuest,Model.Guest>().ReverseMap();
        }
    }
}
