using Book_Example.Data;
using Book_Example.Exceptions;
using Book_Example.Models;

namespace Book_Example.Business;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void Add(Author author)
    {
        try
        {
            AddRules(author);
            _authorRepository.Add(author);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _authorRepository.Delete(id);
            GetList();
        }
        catch (AuthorNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        {
            try
            {
                Author? author = _authorRepository.GetById(id);
                Console.WriteLine(author);

            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    public void GetList()
    {
        _authorRepository
            .GetAll()
            .ForEach(c => Console.WriteLine(c));
    }

    private void AddRules(Author author)
    {
        if (author.Name.Length < 2 || string.IsNullOrWhiteSpace(author.Name))
        {
            throw new AuthorNameException(author.Name);
        }
    }
}
