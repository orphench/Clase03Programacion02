using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03Programacion02
{
    class Alumno
    {
        /*todo lo que se puede sistematizar y estructutar es un objeto, 
        pueden ser infinitos y van a tener la misma estructura y comportamiento
        */

        public string nombre;//estructura de objeto
        private int legajo;

        public void mostrar()//metodo
        {
            Console.Write(this.nombre + legajo);
            
        }

        private bool compararme(Alumno unAlumno)
        {
            bool respuesta = false;
            
            if(this.nombre == unAlumno.nombre && this.legajo == unAlumno.legajo)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public Alumno(int legajo)//Constructor para acceder a atributos privados
        {
            this.nombre = "ASD";
            this.legajo = legajo;
        }

        public int Getlegajo()
        {
            return this.legajo;   
        }

        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        
        public static bool compararDosAlumnos (Alumno alumno1, Alumno alumno2)
        {
            /*bool respuesta = false;
            if(alumno1.nombre == alumno2.nombre && alumno1.legajo == alumno2.legajo )
            {
                respuesta = true;
            }

            return respuesta;*/

            return alumno1.compararme(alumno2);
        }

        public static void MostrarAlumno(Alumno alumno)
        {
            Console.WriteLine(alumno.nombre + alumno.legajo);
        }

        //Clases con primera letra en mayuscula y sustantivos
        //metodos en minuscula y verbos
        
    }
}
