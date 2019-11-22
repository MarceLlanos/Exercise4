using System;
namespace Exercise4
{
    public class CompositeCreatorFilter
    {
        public CompositeFilter CreateFilterComposite(string option, string searchWord)
        {
            var options = option.Split(' ');
            var searcher = searchWord.Split(' ');
            
            FilterCreator resultFilterCreate = new FilterCreator();
            CompositeFilter compositeFilter = new CompositeFilter();

            for (int i = 0; i < options.Length; i++)
            {
                compositeFilter.AddFilters(resultFilterCreate.CreateFilter(options[i], searcher[i]));
            }

            return compositeFilter;
        }
        
    }
}
