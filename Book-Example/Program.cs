using Book_Example.Business;
using Book_Example.Data;
using Book_Example.Models;

IBookService bookService = new BookService(new BookRepository());
ICategoryService categoryService = new CategoryService(new CategoryRepository());
IAuthorService authorService = new AuthorService(new AuthorRepository());

//Category category = new Category()
//{
//    Id = "D",
//    Name = " "
//};
//Book book = new Book()
//{
//    Id = 5,
//    Description = "Test",
//    Price = 2500,
//    Stock = -2000,
//    Title = "Test"
//};

//Console.WriteLine("Kayıt ekleme : ");
//bookService.Add(book);

//Console.WriteLine("Kayıt silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme:");
//bookService.GetById(2);

//Console.WriteLine("Kitapların listesi");
//bookService.GetList();

//Console.WriteLine("Kategori ekleme");
//categoryService.Add(category);

//Console.WriteLine("Id den Yazar Bulma");
//authorService.GetById(3);

bookService.GetByIsbn("12");