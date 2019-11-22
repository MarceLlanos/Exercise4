using System;
using System.Collections.Generic;

namespace Exercise4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();
            people.Add(new Person { Name = "Karen", LastName = "Morales", Id = 3, Age = 24 });
            people.Add(new Person { Name = "Geraldine", LastName = "Morales", Id = 3, Age = 27 });
            people.Add(new Person { Name = "Karen", LastName = "Aguilar", Id = 3, Age = 27 });
            people.Add(new Person { Name = "Juan", LastName = "Quispe", Id = 5, Age = 25 });
            people.Add(new Person { Name = "Ivan", LastName = "Esparza", Id = 89, Age = 32 });
            people.Add(new Person { Name = "Veronica", LastName = "Jimenez", Id = 43, Age = 28 });
            people.Add(new Person { Name = "Pedro", LastName = "Lozada", Id = 2, Age = 23 });
            people.Add(new Person { Name = "Natalia", LastName = "Magarinios", Id = 10, Age = 11 });
            people.Add(new Person { Name = "Any", LastName = "Montanio", Id = 23, Age = 29 });

            Console.WriteLine("MENU");
            Console.WriteLine("1= By Name");
            Console.WriteLine("2= By Lastname");
            Console.WriteLine("3= By Age");
            Console.WriteLine("4= By Id");
            
            string option = Console.ReadLine();
            
            Displayer displayer = new Displayer();
            CompositeCreator compositeCreator = new CompositeCreator();
            
            people.Sort(compositeCreator.CreateComposite(option));

            displayer.Display(people);
            
            Console.WriteLine("");
            Console.WriteLine("SEARCH:");
            Console.WriteLine("1= Name:");
            Console.WriteLine("2= Lastname:");
            Console.WriteLine("3= Age:");
            Console.WriteLine("4= Id:");
            string optionSearch = Console.ReadLine();
            Console.Write("search word:");
            string wordSearch = Console.ReadLine();

            CompositeCreatorFilter filter = new CompositeCreatorFilter();

            displayer.Display(people.Filtrar(filter.CreateFilterComposite(optionSearch, wordSearch)));
            Console.ReadKey();
        }
    }
}
