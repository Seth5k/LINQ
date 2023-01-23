using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq05ArrayListTips
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "Hola", 5, 6.7, false, 4, 2, "Saludos", 3.5, 3 });

            //Obtener numeros enteros
            var enteros = lista.OfType<int>();

            foreach (int n in enteros)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------");
            //Console.ReadLine();



            //Creamos un lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientado a Objetos",9.0),
                new CEstudiante("Juan","S875","Programacion Basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","S456","Orientado a Objetos",8.3)
            };

            //Tenemos que transformar el ArrayList a un tipo que implemente a
            //IEnumerable<T> para poder ser usado con Linq
            var estL = estudiantes.OfType<CEstudiante>();

            //Ahora usamos Linq
            //Encontramos a los reprobados
            var reprobados = from e in estL
                             where e.Promedio <= 5.0
                             select e;

            //Mostramos
            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
