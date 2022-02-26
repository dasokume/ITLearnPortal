using IT.Learn.Portal.Application.Interfaces.Persistence;

namespace IT.Learn.Portal.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        IEventRepository IUnitOfWork.EventRepository { get => new EventRepository(); }

        public void CompleteAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}