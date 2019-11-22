using System.Collections.Generic;
namespace Exercise4
{
    public class CompositeFilter:IFiltro<Person>
    {
        List<IFiltro<Person>> filters;
        
        public CompositeFilter()
        {
            
            filters = new List<IFiltro<Person>>();
        }

        public void AddFilters(IFiltro<Person> filtro)
        {
            filters.Add(filtro);
        }

        public bool Verificar(Person t)
        {
            foreach (var item in filters)
            {
                if (!item.Verificar(t))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
