using AutoMapper;
using IT.Learn.Portal.Application.Interfaces.Persistence;
using MediatR;

namespace IT.Learn.Portal.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQueryHandler : IRequestHandler<GetEventListQuery, List<GetEventVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetEventListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetEventVm>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            var events = await _unitOfWork.EventRepository.GetListAsync();

            return _mapper.Map<List<GetEventVm>>(events);
        }
    }
}