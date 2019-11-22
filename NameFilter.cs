using System.Collections.Generic;
namespace Exercise4
{
    public class NameFilter:IFiltro<Person>
    {
        string name;
        public NameFilter(string name)
        {
            this.name = name;
        }
        public bool Verificar(Person t)
        {
            return t.Name == name;
        }
    }
}
