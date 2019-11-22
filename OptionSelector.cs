using System;
using System.Collections.Generic;

namespace Exercise4
{
    public interface OptionSelector
    {
        void PrintSelection(string option, List<Person> people);
    }
}
