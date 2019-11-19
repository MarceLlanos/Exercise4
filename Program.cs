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
            people.Add(new Person { Name = "Ester", LastName = "Quiroga" , Id= 9 });
            people.Add(new Person { Name = "Juan", LastName = "Reanult", Id =  10 });
            people.Add(new Person { Name = "David", LastName = "Montanio", Id = 1 });
            people.Add(new Person { Name = "Ivan", LastName = "Esparza", Id = 5 });
            people.Add(new Person { Name = "Pedro", LastName = "Agno", Id = 3 });
            people.Add(new Person { Name = "Karen", LastName = "Morales", Id = 3 });
            people.Add(new Person { Name = "Veronica", LastName = "Jimenez", Id = 89 });
            people.Add(new Person { Name = "Any", LastName = "Vargas", Id = 6 });
            people.Add(new Person { Name = "Carla", LastName = "Trigo", Id = 4 });
            people.Add(new Person { Name = "Isabel", LastName = "Lopez", Id = 7 });

            string option;
            Console.WriteLine("For sort by Name write '1', sort by LastName '2', sort by Id '3'");
            option = Console.ReadLine();

            int i = 0;

            if (option == "1")
            {
                NameComparer nameComparer = new NameComparer();
                people.Sort(nameComparer);

                foreach (Person item in people)
                {
                    i++;
                    Console.WriteLine("Person {0}: {1} {2} {3}", i, item.Name, item.LastName, item.Id);
                }
            }
            if ( option == "2")
            {
                LastNameComparer lastNameComparer = new LastNameComparer();
                people.Sort(lastNameComparer);

                foreach (Person item in people)
                {
                    i++;
                    Console.WriteLine("Person {0}: {1} {2} {3}", i, item.Name, item.LastName, item.Id);
                }
            }
            if( option == "3")
            {
                IdComparer idComparer = new IdComparer();
                people.Sort(idComparer);

                foreach (Person item in people)
                {
                    i++;
                    Console.WriteLine("Person {0}: {1} {2} {3}", i, item.Name, item.LastName, item.Id);
                }
            }

            Console.ReadKey();
        }
    }
}
