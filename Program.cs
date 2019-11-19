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
            var people = new List<Person>();
            //TODO: Add a number of person within the list
            people.Add(new Person { Name = "Ester", LastName = "Quiroga" });
            people.Add(new Person { Name = "Juan", LastName = "Reanult" });
            people.Add(new Person { Name = "David", LastName = "Montanio" });
            people.Add(new Person { Name = "Ivan", LastName = "Esparza" });
            people.Add(new Person { Name = "Pedro", LastName = "Agno" });
            people.Add(new Person { Name = "Karen", LastName = "Morales" });
            people.Add(new Person { Name = "Veronica", LastName = "Jimenez" });
            people.Add(new Person { Name = "Any", LastName = "Vargas" });
            people.Add(new Person { Name = "Carla", LastName = "Trigo" });

            PersonComparer personComparer = new PersonComparer();
            people.Sort(personComparer);
            int i = 0;
            foreach (Person item in people)
            {
                
                i++;
                Console.WriteLine("Person {0}: {1} {2}",i, item.Name, item.LastName);
                
            }

            
            
            //TODO: Print the sorted names in the console

            Console.ReadKey();
        }
    }
}
