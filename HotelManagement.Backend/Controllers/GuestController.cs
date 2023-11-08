using HotelManagement.Core.Guest.Command;
using HotelManagement.Core.Guest.Query;
using HotelManagement.Services.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GuestController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<VmGuest>> Get()
        {
            var data = await _mediator.Send(new GetAllGuestQuery());
            return Ok(data);
        }

        [HttpGet("Id")]

        public async Task<ActionResult<VmGuest>> GetById(int id)
        {
            var data = await _mediator.Send(new GetGuestById(id));
            return Ok(data);
        }
        [HttpPost]
        public async Task<ActionResult<VmGuest>> Add([FromBody] VmGuest vmGuest)
        {
            var data = await _mediator.Send(new CreateGuest(vmGuest));
            return Ok(data);
        }
        [HttpPut("Id")]

        public async Task<ActionResult<VmGuest>> Update(int id, [FromBody]VmGuest vmGuest)
        {
            var data = await _mediator.Send(new UpdateGuest(id, vmGuest));
            return Ok(data);
        }
        [HttpDelete("Id")]
        public async Task <ActionResult<VmGuest>> Delete(int id)
        {
            var data = await _mediator.Send(new DeleteGuest(id));
            return Ok(data);
        }

        
    }
}
