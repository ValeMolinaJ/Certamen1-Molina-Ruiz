using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class sede
    {
        private int idSede;
        private string nombreSede;
        private string direccion;
        private string telefono;
        private administrador administrador;
        public int IdSede { get => idSede; set => idSede = value; }
        public string NombreSede { get => nombreSede; set => nombreSede = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public administrador Administrador { get => administrador; set => administrador = value; }

        public sede()
        {

        }
        public sede(int idSede, string nombreSede,string direc, string telefono, administrador admin)
        {
            this.idSede = idSede;
            this.nombreSede = nombreSede;
            this.direccion = direc;
            this.telefono = telefono;
            this.administrador = admin;
        }
    }
}
