namespace Book_Example.Business;

public interface IEntityService<TEntity, TId>
{
    void GetList();
    void Add(TEntity entity);
    void Delete(TId id);
    void GetById(TId id);
}
