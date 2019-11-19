using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class LastNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.LastName, y.LastName);
        }
    }
}
