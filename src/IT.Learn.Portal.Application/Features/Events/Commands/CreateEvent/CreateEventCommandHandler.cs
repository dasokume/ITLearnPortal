using IT.Learn.Portal.Application.Interfaces.Persistence;
using MediatR;
using AutoMapper;
using IT.Learn.Portal.Domain.Entities;

namespace IT.Learn.Portal.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateEventCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            // var errors = _validor.Validate(request);
            /*
             * if (errors.Any())
             * {
             *   throw new ValidationException(errors);
             * }
             */

            var @event = _mapper.Map<Event>(request);

            @event = await _unitOfWork.EventRepository.CreateAsync(@event);

            return @event.Id;
        }
    }
}