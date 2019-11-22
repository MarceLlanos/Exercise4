using System;
namespace Exercise4
{
    public class LastnameFilter:IFiltro<Person>
    {
        string lastname;
        public LastnameFilter(string lastname)
        {
            this.lastname = lastname;
        }

        public bool Verificar(Person t)
        {
            return t.LastName == lastname;
        }
    }
}
