namespace Book_Example.Exceptions;

public class BookTitleException: Exception
{
    public BookTitleException(string title) : base($"{title} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {title.Length}")
    {
    }   
}
