using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class IdSelector:OptionSelector
    {
        public IdSelector()
        {
        }

        public void PrintSelection(string option, List<Person> people)
        {
            IdComparer idComparer = new IdComparer();
            people.Sort(idComparer);
            int i = 0;

            if (option == "3")
            {
                foreach (Person item in people)
                {
                    i++;
                    Console.WriteLine("Person {0}: {1} {2} {3}", i, item.Name, item.LastName, item.Id);
                }
            }
        }
    }
}
