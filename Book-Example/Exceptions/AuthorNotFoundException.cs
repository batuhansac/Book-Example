namespace Book_Example.Exceptions;

public class AuthorNotFoundException : Exception
{
    public AuthorNotFoundException(int id) : base($"Id değeri {id} olan bir yazar bulunamadı.")
    {
        
    }
}
