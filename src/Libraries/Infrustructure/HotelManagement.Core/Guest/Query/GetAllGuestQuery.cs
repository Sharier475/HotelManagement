using AutoMapper;
using HotelManagement.Repositories.Interface;
using HotelManagement.Services.Model;
using MediatR;

namespace HotelManagement.Core.Guest.Query;

public  record GetAllGuestQuery(): IRequest<IEnumerable<VmGuest>>;
public class GetAllGuestQueryHandler : IRequestHandler<GetAllGuestQuery, IEnumerable<VmGuest>>
{
    private readonly IGuestRepository _GuestRepository;
    public  GetAllGuestQueryHandler(IGuestRepository guestRepository)
    {
        _GuestRepository = guestRepository;
    }

    public async Task<IEnumerable<VmGuest>> Handle(GetAllGuestQuery request, CancellationToken cancellationToken)
    {
        var result = await _GuestRepository.GetList();
        return result;
    }
}

