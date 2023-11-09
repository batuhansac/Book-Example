namespace Book_Example.Exceptions;

public class CategoryNotFoundException : Exception
{
    public CategoryNotFoundException(string id) : base($"Id değeri {id} olan kategori bulunamadı.")
    {
        
    }
}
