using MediatR;

namespace IT.Learn.Portal.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQuery : IRequest<List<GetEventVm>>
    {
    }
}