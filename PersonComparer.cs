using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var comparePerson = string.Compare(x.Name, y.Name);
            if (comparePerson != 0)
            {
                return comparePerson;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
