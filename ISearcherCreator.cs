using System.Collections.Generic;
namespace Exercise4
{
    public interface ISearcherCreator
    {
        IComparer<Person> CreateSearch(string toSearch);
    }
}
