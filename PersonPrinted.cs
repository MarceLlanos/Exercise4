using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class PersonPrinted
    {
        public void PrintPerson(List<Person> personCollection, string option)
        {
            int i = 0;
            foreach (var item in personCollection)
            {
                Console.WriteLine("{0}", i);
            }
            
        }

    }
}
