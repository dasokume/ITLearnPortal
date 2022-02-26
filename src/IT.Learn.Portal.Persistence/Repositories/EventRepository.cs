using IT.Learn.Portal.Application.Interfaces.Persistence;
using IT.Learn.Portal.Domain.Entities;

namespace IT.Learn.Portal.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
    }
}