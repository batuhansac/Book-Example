using Book_Example.Data;
using Book_Example.Exceptions;
using Book_Example.Models;

namespace Book_Example.Business;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public void Add(Book book)
    {
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
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
            _bookRepository.Delete(id);
            GetList();
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);

        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetByIsbn(string isbn)
    {
        try
        {
            Book? book = _bookRepository.GetByIsbn(isbn);
            Console.WriteLine(book);
        }
        catch(BookNotFoundWithIsbn ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }
    private void AddRules(Book book)
    {
        if (book.Title.Length < 2)
        {
            throw new BookTitleException(book.Title);
        }

        if (book.Price < 0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }
}
