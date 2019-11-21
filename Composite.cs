using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Composite : IComparer<Person>
    {
        List<IComparer<Person>> compares;

        public Composite()
        {
            compares = new List<IComparer<Person>>();
        }
        public void AddComparer(IComparer<Person> comparer)
        {
            compares.Add(comparer);
        }
        
        public int Compare(Person x, Person y)
        {
            foreach (var item in compares)
            {
                var comparisonResult = item.Compare(x,y);
                if (comparisonResult != 0)
                {
                    return comparisonResult;
                }
            }
            return 0;
        }
    }
}
