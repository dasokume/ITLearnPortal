using IT.Learn.Portal.Application.Features.Events.Commands.CreateEvent;
using IT.Learn.Portal.Application.Features.Events.Queries.GetEventList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IT.Learn.Portal.API.Controllers
{
    public class EventController : BaseController
    {
        private readonly IMediator _mediator;

        public EventController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "Create Event")]
        public async Task<IActionResult> Create([FromBody] CreateEventCommand request)
        {
            var id = await _mediator.Send(request);

            return Ok(id);
        }

        [HttpGet(Name = "Get Event list")]
        public async Task<IActionResult> GetList()
        {
            var events = await _mediator.Send(new GetEventListQuery());

            return Ok(events);
        }
    }
}