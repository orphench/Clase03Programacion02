using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03Programacion02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Alumno unAlumno = new Alumno(666);
            
            //unAlumno.nombre = "Christopher";

            //Console.WriteLine(unAlumno.nombre);
            unAlumno.Setnombre("Pepito");
            unAlumno.Getlegajo();
            unAlumno.mostrar();
            

            Auto.fecha = "lala";

            Auto unauto = new Auto("Fiat");
            Auto unauto2 = new Auto("Fiat");
            Auto unauto3 = new Auto("Fiat");

            Alumno.MostrarAlumno(unAlumno);

            Console.ReadKey();
        }
    }
}
