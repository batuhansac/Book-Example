using System.Xml.Linq;

namespace Book_Example.Models;

public class Author : EntityBase<int>
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Yazar : {Name}";
    }
}
