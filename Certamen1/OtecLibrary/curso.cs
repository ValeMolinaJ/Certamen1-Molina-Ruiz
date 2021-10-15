using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class curso
    {
        private int idCurso;
        private string nombreCurso;
        private coordinador coordinador;
        private List<asignatura> asignaturas;
        private sede nombreSede;

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public coordinador Coordinador { get => coordinador; set => coordinador = value; }
        public List<asignatura> Asignaturas { get => asignaturas; set => asignaturas = value; }
        public sede NombreSede { get => nombreSede; set => nombreSede = value; }

        public curso()
        {

        }
        public curso(int idCurso, string nombreCurso, coordinador coordinador, List<asignatura> asignatura, sede nombreSede)
        {
            this.IdCurso = idCurso;
            this.NombreCurso = nombreCurso;
            this.Coordinador = coordinador;
            this.asignaturas = asignatura;
            this.NombreSede = nombreSede;
        }
        public int cantAsig(List<asignatura> asignatura)
        {
            int cont = 0;
            foreach (var item in asignatura)
            {
                cont++;
            }
            return cont;
        }

        public string datosCurso()
        {
            return "Nombre Administrador(a): " + NombreSede.Administrador.Nombre + "\nNombre Sede: " + nombreSede.NombreSede + "\nNombre Curso: " 
                    + nombreCurso + "\nNombre Coordinador(a): "+ coordinador.Nombre +"\nAsignaturas: " + cantAsig(asignaturas);
        }
    }
}
