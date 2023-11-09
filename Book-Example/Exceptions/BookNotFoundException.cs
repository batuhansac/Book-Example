namespace Book_Example.Exceptions;

public class BookNotFoundException : Exception
{
    public BookNotFoundException(int id) : base($"Id değeri {id} olan bir kitap bulunamadı.")
    {
    }
}
