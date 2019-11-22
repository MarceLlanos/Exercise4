using System;
namespace Exercise4
{
    public interface ICreatorFilter
    {
        IFiltro<Person> CreateFilter(string option, string wordSearch);
    }
}
