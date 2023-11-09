namespace Book_Example.Exceptions;

public class CategoryNameException : Exception
{
    public CategoryNameException(string name) : base($"{name} 2 karakterden az ve boş karakter olmamalı girdiğiniz karakter sayısı : {name.Length}.")
    {

    }
}
