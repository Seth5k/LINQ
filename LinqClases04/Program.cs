using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqClases04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de Linq con clases

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

            //Encontramos a los reprobados
            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0
                             select e;

            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r);
            }
            //Console.ReadLine();

            //Mostramos solo un atributo de los encotrados por medio de la propiedad
            Console.WriteLine("Solo un atributo");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r.Nombre);
            }
            //Console.ReadLine();

            var mercadotecnia = from e in estudiantes
                                where e.Curso == "Mercadotecnia"
                                select e.Nombre;

            Console.WriteLine("Nombres de Mercadotecnia");
            foreach (string n in mercadotecnia)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
