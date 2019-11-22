using System;
namespace Exercise4
{
    public class FilterCreator : ICreatorFilter
    {
        public IFiltro<Person> CreateFilter(string option, string wordSearch)
        {
            
            switch (option)
            {
                case "1":
                    return new NameFilter(wordSearch);
                case "2":
                    return new LastnameFilter(wordSearch);
                case "3":
                    return new AgeFilter(wordSearch);
                case "4":
                    return new IdFilter(wordSearch);

                default:
                    return new NameFilter(wordSearch);
            }
        }
    }
}
