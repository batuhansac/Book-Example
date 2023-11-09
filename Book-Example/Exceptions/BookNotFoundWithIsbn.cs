namespace Book_Example.Exceptions;

public class BookNotFoundWithIsbn : Exception
{
    public BookNotFoundWithIsbn(string isbn) : base($"{isbn} ISBN değerine ait bir kitap bulunamadı.")
    {
    }
}
