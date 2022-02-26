using MediatR;

namespace IT.Learn.Portal.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Source { get; set; }
    }
}