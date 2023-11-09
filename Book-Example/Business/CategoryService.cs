using Book_Example.Data;
using Book_Example.Exceptions;
using Book_Example.Models;

namespace Book_Example.Business;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void Add(Category category)
    {
        try
        {
            AddRules(category);
            _categoryRepository.Add(category);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(string id)
    {
        try
        {
            _categoryRepository.Delete(id);
            GetList();
        }
        catch (CategoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(string id)
    {
        {
            try
            {
                Category? category = _categoryRepository.GetById(id);
                Console.WriteLine(category);

            }
            catch (CategoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

    public void GetList()
    {
        _categoryRepository
            .GetAll()
            .ForEach(c => Console.WriteLine(c));
    }

    private void AddRules(Category category)
    {
        if (category.Name.Length < 2 || string.IsNullOrWhiteSpace(category.Name))
        {
            throw new CategoryNameException(category.Name);
        }
    }
}
