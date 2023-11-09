using Book_Example.Exceptions;
using Book_Example.Models;

namespace Book_Example.Data;

public class AuthorRepository : IAuthorRepository
{
    private readonly List<Author> _author;

    public AuthorRepository()
    {
        _author = new List<Author>()
        {
            new Author { Id = 1, Name = "Sir Arthur Conan Doyle"},
            new Author { Id = 2, Name = "Maurice Leblanc"},
            new Author { Id = 3, Name = "Mustafa Kemal Atatürk"},
            new Author { Id = 4, Name = "Jack Weatherford"},
            new Author { Id = 5, Name = "Peyami Safa"},
            new Author { Id = 6, Name = "Gök Türk"},
            new Author { Id = 7, Name = "David Burns"},
            new Author { Id = 8, Name = "Bilinmiyor"},
        };
    }
    public void Add(Author author)
    {
        _author.Add(author);
    }

    public void Delete(int id)
    {
        Author? author = _author.SingleOrDefault(a => a.Id == id);

        if (author is not null)
        {
            _author.Remove(author);
        }
    }

    public List<Author> GetAll()
    {
        return _author;
    }

    public Author? GetById(int id)
    {
        Author? author = _author.SingleOrDefault(x => x.Id == id);

        if (author is not null)
        {
            return author;
        }

        return null;
    }
}
