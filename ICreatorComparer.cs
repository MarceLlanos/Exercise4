using System.Collections.Generic;

namespace Exercise4
{
    public interface ICreatorComparer
    {

        IComparer<Person> CreateComparer(string option);
    }
}
