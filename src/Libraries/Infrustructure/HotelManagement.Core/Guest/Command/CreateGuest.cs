using AutoMapper;
using HotelManagement.Repositories.Interface;
using HotelManagement.Services.Model;
using MediatR;

namespace HotelManagement.Core.Guest.Command
{
    public record CreateGuest(VmGuest VmGuest) : IRequest<VmGuest>;
    public class CreateGuestHandler : IRequestHandler<CreateGuest, VmGuest>
    {
        private readonly IGuestRepository _Guestrepository;
        private readonly IMapper _mapper;
        public CreateGuestHandler(IGuestRepository guestRepository, IMapper mapper)
        {
            _Guestrepository = guestRepository;
            _mapper = mapper;
        }
        public async Task<VmGuest> Handle(CreateGuest request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<Model.Guest>(request.VmGuest);
            return await _Guestrepository.Add(data);
            

        }
    }
}