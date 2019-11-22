using System;
namespace Exercise4
{
    public class IdFilter:IFiltro<Person>
    {
        int id;
        public IdFilter(string id)
        {
            this.id = int.Parse(id);
        }

        public bool Verificar(Person t)
        {
            return t.Id == id;
        }
    }
}
