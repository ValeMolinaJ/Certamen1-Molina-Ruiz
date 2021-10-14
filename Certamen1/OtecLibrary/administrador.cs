using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
   public class administrador
    {
        private string nombre;
        private string run;
        private string telefono;
        private string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Run { get => run; set => run = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public administrador()
        {

        }
        public administrador(string nombre, string run, string telefono, string direccion)
        {
            this.nombre = nombre;
            this.run = run;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
