using System;
using System.Collections.Generic;

namespace Exercise4
{
    class ComparerCreator: IComparerCreator
    {

        
        public IComparer<Person> CreateComparer(string option)
        {
            switch (option)
            {
                case "1":
                    return new NameComparer();
                case "2":
                    return new LastNameComparer();
                case "3":
                    return new AgeComparer();
                case "4":
                    return new IdComparer();
                default:
                    return new NameComparer(); ;
            };
        }
    }
}
