using HotelManagement.Repositories.Interface;
using HotelManagement.Services.Model;
using MediatR;

namespace HotelManagement.Core.Guest.Query
{
    public record GetGuestById(int Id) : IRequest<VmGuest>;
    public class GetGuestByIdHandler :
        IRequestHandler<GetGuestById, VmGuest>
    {
        private readonly IGuestRepository _guestRepository;
        public GetGuestByIdHandler(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public async Task<VmGuest> Handle(GetGuestById request, CancellationToken cancellationToken)
        {
            return await _guestRepository.GetById(request.Id);
        }

    }

}
