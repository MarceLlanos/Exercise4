
using System.Collections.Generic;


namespace Exercise4
{
    public static class ListExtensionMethods
    {
        public static List<T> Filtrar<T>(this List<T> lista, IFiltro<T> filtro)
        {
            var resultado = new List<T>();

            foreach (var item in lista)
            {
                if (filtro.Verificar(item))
                {
                    resultado.Add(item);
                }
            }

            return resultado;
        }
    }

    public interface IFiltro<T>
    {
        bool Verificar(T t);
    }
}
