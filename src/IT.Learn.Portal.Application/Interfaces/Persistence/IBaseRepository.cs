namespace IT.Learn.Portal.Application.Interfaces.Persistence
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task<IList<TEntity>> GetListAsync(); 

        Task<TEntity> GetByIdAsync(int id);
    }
}