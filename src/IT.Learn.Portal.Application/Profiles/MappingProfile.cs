using AutoMapper;
using IT.Learn.Portal.Application.Features.Events.Commands.CreateEvent;
using IT.Learn.Portal.Application.Features.Events.Queries.GetEventList;
using IT.Learn.Portal.Domain.Entities;

namespace IT.Learn.Portal.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateEventCommand, Event>().ReverseMap();
            CreateMap<Event, GetEventVm>();
        }
    }
}