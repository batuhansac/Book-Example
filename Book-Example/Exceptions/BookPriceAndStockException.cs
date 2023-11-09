namespace Book_Example.Exceptions;

public class BookPriceAndStockException : Exception
{
    public BookPriceAndStockException(double price, int stock) : base($"Girdiğiniz stok ve değer bilgisi negatif değerler olamaz. Stok: {stock}, Kitap değeri: {price}")
    {
    }
}
