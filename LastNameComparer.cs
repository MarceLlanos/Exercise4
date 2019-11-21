using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class LastNameComparer : IComparer<Person>
    {
        public LastNameComparer()
        {
        }
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
    }
}
