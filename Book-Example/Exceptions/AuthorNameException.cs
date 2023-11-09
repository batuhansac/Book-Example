namespace Book_Example.Exceptions;

public class AuthorNameException : Exception
{
    public AuthorNameException(string name) : base($"{name} minimum 2 karakterli ve boş karakter olmamalıdır grdiğiniz karakter sayısı : {name.Length}")
    {
    }
}
