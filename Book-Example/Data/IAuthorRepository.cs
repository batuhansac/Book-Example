using Book_Example.Models;

namespace Book_Example.Data;

public interface IAuthorRepository : IEntityRepository<Author, int>
{
}
