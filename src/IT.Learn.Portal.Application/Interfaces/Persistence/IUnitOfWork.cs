namespace IT.Learn.Portal.Application.Interfaces.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository EventRepository { get; }

        void CompleteAsync();
    }
}