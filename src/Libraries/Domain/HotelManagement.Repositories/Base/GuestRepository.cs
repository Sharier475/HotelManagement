using AutoMapper;
using HotelManagement.Infrustructure;
using HotelManagement.Model;
using HotelManagement.Repositories.Interface;
using HotelManagement.Services.Model;
using HotelManagement.Shared.CommonRepository;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Repositories.Base;

public class GuestRepository : RepositoryBase<Guest, VmGuest, int>, IGuestRepository
{
    public GuestRepository(IMapper mapper, HotelManagementDbContext dbContext) : base(mapper, dbContext)
    {

    }
}
