using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class IdComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }
    }
}
