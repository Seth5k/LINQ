using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqArreglo02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Implicita

            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            var valores = from n in numeros
                          where n % 2 == 0
                          select n;

            foreach (int num in valores)
            {
                Console.WriteLine(num);
                Console.WriteLine("------");
            }


            //Ejecucion diferida
            //La expresion de query no se evalua hasta que se itera sobre el arreglo
            //Se puede usar el ,ismo query y siempre obtenemos el resultado actualizado


            Console.WriteLine("Ejecucion diferida");
            numeros[1] = 12;

            foreach (int num in valores)
            {
                Console.WriteLine(num);
            }

            //Console.ReadLine();



            //Ejecucion Inmediata
            // query se ejecuta en el momento exacto en nostros lo definimos
            //Ventaja:Se ejecuta el momento del query
            //Se debe indicar el tipo se va a llevar a cabo y llevar a cabo la conversion

            Console.WriteLine("Ejecucion Inmediata");

            //cambios al arreglo no lleva actualizaciones al querry a diferencia de la ejecuion diferida

            //Guardamos los resultados como un arreglo
            int[] arrayValores = (from n in numeros
                                  where n % 2 == 0
                                  select n).ToArray<int>();

            //Guardamos los resultados como un list
            List<int> listValores = (from n in numeros
                                     where n % 2 == 0
                                     select n).ToList<int>();

            
            Console.WriteLine("El arreglo");
            foreach (int num in arrayValores)
            {
                Console.WriteLine(num);
            }

            numeros[0] = 28;
            Console.WriteLine("------ Se actualiza despues de la modificacion------?");

            Console.WriteLine("La Lista");
            Console.WriteLine("----------");
            foreach (int num in listValores)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
