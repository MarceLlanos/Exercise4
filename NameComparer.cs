﻿using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class NameComparer: IComparer<Person>
    {
        public NameComparer()
        {
        }

        public int Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
