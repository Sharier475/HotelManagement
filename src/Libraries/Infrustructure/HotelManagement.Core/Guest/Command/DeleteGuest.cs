using HotelManagement.Repositories.Interface;
using HotelManagement.Services.Model;
using MediatR;

namespace HotelManagement.Core.Guest.Command
{
    public record DeleteGuest(int Id):IRequest<VmGuest>;
    
    public class DeleteGuestHandler : IRequestHandler<DeleteGuest, VmGuest>
    {
        private readonly IGuestRepository _GuestRepository;
        public  DeleteGuestHandler(IGuestRepository guestRepository) 
        {
            _GuestRepository = guestRepository;
        }

        public async Task<VmGuest> Handle(DeleteGuest request, CancellationToken cancellationToken)
        {
            return await _GuestRepository.Delete(request.Id);
        }
    }

}
