using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMetodo03
{
     class ClaseExplicita
    {
        private static string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

        //No se puede usar de forma implicita
        //debe ser estatico
        private static IEnumerable<string> encontrados = (from p in postres
                                                   where p.Contains("manzana")
                                           orderby p
                                           select p);

        public static IEnumerable<int> ObtenerNumerosPares()
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            IEnumerable<int> pares = from n in numeros
                                     where n % 2 == 0
                                     select n;

            return pares;
        }
        

        //Este metodo regresa el resuktado del query
        public static IEnumerable<string> ObtenerPostres()
        {
            return encontrados;
        }

        //Este metodo regresa el resultado de un query inmediato
        public static int[] ObtenerNumerosImpares()
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            var resultados = from n in numeros
                             where n % 2 != 0
                             select n;

            return resultados.ToArray();
        }
            
    }
}
