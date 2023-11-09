using Book_Example.Models;

namespace Book_Example.Data;

public interface IBookRepository : IEntityRepository<Book, int>
{
    Book? GetByIsbn(string isbn);
}
