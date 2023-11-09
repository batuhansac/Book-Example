namespace Book_Example.Data;

public interface IEntityRepository<TEntity, TId>
{
    void Add(TEntity entity);
    void Delete(TId id);
    List<TEntity> GetAll();
    TEntity? GetById(TId id);

}
