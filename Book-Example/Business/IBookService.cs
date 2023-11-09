using Book_Example.Models;

namespace Book_Example.Business;

public interface IBookService : IEntityService<Book, int>
{
    void GetByIsbn(string isbn);
}
