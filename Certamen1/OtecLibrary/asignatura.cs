using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class asignatura
    {
        private int id;
        private string nombreAsig;

        public int Id { get => id; set => id = value; }
        public string NombreAsig { get => nombreAsig; set => nombreAsig = value; }
        public asignatura()
        {

        }
        public asignatura(int id, string nombreAsig)
        {
            this.id = id;
            this.nombreAsig = nombreAsig;
        }
    }
}
