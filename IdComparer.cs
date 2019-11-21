using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class IdComparer: IComparer<Person>
    {
        public IdComparer()
        {
        }

        public int Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }
    }
}
