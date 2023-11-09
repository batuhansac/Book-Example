using Book_Example.Models;

namespace Book_Example.Data;

public interface ICategoryRepository : IEntityRepository<Category, string>
{

}
