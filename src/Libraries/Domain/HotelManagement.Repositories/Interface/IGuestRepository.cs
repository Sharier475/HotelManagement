using HotelManagement.Model;
using HotelManagement.Services.Model;
using HotelManagement.Shared.CommonRepository;

namespace HotelManagement.Repositories.Interface;

public  interface IGuestRepository : IRepository<Guest,VmGuest,int>
{



}
