using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a name:");
            String text;
            text = Console.ReadLine();
            Console.Write("Hola mundo {0}", text);
            Console.ReadKey();
        }
    }
}
