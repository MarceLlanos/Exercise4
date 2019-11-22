using System.Collections.Generic;

namespace Exercise4
{
    interface IComparerCreator
    {
       IComparer<Person> CreateComparer(string option);
    }
}
