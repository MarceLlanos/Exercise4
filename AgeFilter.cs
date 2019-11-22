using System;
namespace Exercise4
{
    public class AgeFilter:IFiltro<Person>
    {
        int AgeSearch;


        public AgeFilter(string wordSearch)
        {
            this.AgeSearch = int.Parse(wordSearch);
        }



        public bool Verificar(Person t)
        {
            return t.Age == AgeSearch ;
        }
    }
}
