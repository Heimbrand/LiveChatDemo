namespace LiveChatDemo.CommonInterfaces;

public interface IRepository<IEntity, TId> where IEntity : IEntity<TId>
{
    Task<IEntity> GetByIdAsync(TId id);
    Task<IEnumerable<IEntity>> GetManyAsync(int start, int count);
    Task AddAsync(IEntity entity);
}