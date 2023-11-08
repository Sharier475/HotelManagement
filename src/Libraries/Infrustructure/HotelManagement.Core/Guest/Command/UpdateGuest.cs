using AutoMapper;
using HotelManagement.Repositories.Interface;
using HotelManagement.Services.Model;
using MediatR;

namespace HotelManagement.Core.Guest.Command;

public record  UpdateGuest(int Id, VmGuest VmGuest):IRequest<VmGuest>;
public class UpdateGuestHandler : IRequestHandler<UpdateGuest,VmGuest>
{
    private readonly IGuestRepository _GuestRepository;
    private readonly IMapper _mapper;
    public UpdateGuestHandler(IGuestRepository guestRepository, IMapper mapper)
    {
        _GuestRepository = guestRepository;
        _mapper = mapper;
    }

    public async Task<VmGuest> Handle(UpdateGuest request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Guest>(request.VmGuest);
        return await _GuestRepository.Update(request.Id, data);
    }
}


