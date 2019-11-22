using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise4
{
    public class AddCompares
    {
        List<IComparer<Person>> comparers;

        public void AddComparerToList(IComparer<Person> comparer)
        {
            comparers.Add(comparer);
        }
    }
}
