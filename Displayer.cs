using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Displayer
    {
        public void Display(List<Person> people)
        {
            foreach (var item in people)
            {
                Console.WriteLine("Name:{0} Lastname:{1} Age:{2} Id:{3}", item.Name, item.LastName, item.Age, item.Id);
            }
        }
    }
}
