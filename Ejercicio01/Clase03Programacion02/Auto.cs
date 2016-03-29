using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03Programacion02
{
    class Auto
    {
        Rueda ruedaUno;
        Rueda ruedaDos;
        Rueda ruedaTres;
        Rueda ruedaCuatro;
        private string marca;
        public static string fecha;

        static Auto()//constructor estatico
        {
            Auto.fecha = (new DateTime().ToString());
        }

        public Auto(string Marca)
        {
            this.marca = "Fiat";
            fecha = "ooo";
        }



    }
}
