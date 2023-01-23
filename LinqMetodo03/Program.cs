using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMetodo03
{
     class Program
    {
        static void Main(string[] args)
        {
            //Obtener resultados de query desde metodos

            //Invocamos el metodo
            IEnumerable<int> resultados = ClaseExplicita.ObtenerNumerosPares();


            //Mostramos los resultados
            foreach (int num in resultados)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------");

            IEnumerable<string> postres= ClaseExplicita.ObtenerPostres();

            foreach (string p in postres)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-------");
            //Console.ReadLine();


            //ejemplo de los resultados de query inmediato
            int[]impares=ClaseExplicita.ObtenerNumerosImpares();
            foreach (int m in impares)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();
        }
    }
}
