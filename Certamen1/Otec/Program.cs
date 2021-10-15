using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtecLibrary;

namespace Otec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            administrador admin = new administrador("Ignacio soto","11.111.111-1","90587436","los alamos 666");
            sede Conce = new sede(15, "Sede concepción", "arturo prat 196","412793400" ,admin) ;
            coordinador coordinador = new coordinador("Martina Gonzalez","12.123.456-8","98751428","avenida siempre viva 1313");
            asignatura asignature1 = new asignatura(1, "Matemáticas");
            asignatura asignature3 = new asignatura(2, "Computación");
            asignatura asignature4 = new asignatura(3, "Matemáticas II");
            asignatura asignature5 = new asignatura(3, "Computación II");
            List<asignatura> ListAsig = new List<asignatura>();
            ListAsig.Add(asignature1);
            ListAsig.Add(asignature3);
            ListAsig.Add(asignature4);
            ListAsig.Add(asignature5);
            curso primerCurso = new curso(2,"CAJERO",coordinador,ListAsig,Conce);
            Console.WriteLine(primerCurso.datosCurso());

            administrador admin2 = new administrador("Lourdes Benza", "18.354.154-8", "23658741", "Arturo prat 1578");
            sede Chillan = new sede(15, "Sede chillan", "Av. vicente mendez 1240", "422274277", admin2);
            coordinador coordinador2 = new coordinador("Alejandro Ruiz", "17.591.000-9", "89562314", "AV. matta 789");
            asignatura asig1 = new asignatura(1, "Matemática");
            asignatura asig2 = new asignatura(2, "Lenguaje");
            asignatura asig4 = new asignatura(3, "Computación");
            List<asignatura> ListAsignatures = new List<asignatura>();
            ListAsignatures.Add(asig1);
            ListAsignatures.Add(asig2);
            ListAsignatures.Add(asig4);
            curso SegundoCurso = new curso(2, "Asistente párvulo", coordinador2, ListAsignatures, Chillan);
            Console.WriteLine(SegundoCurso.datosCurso());

            administrador admin3 = new administrador("Carolina Ruiz", "18.478.321-9", "78451236", "AV. los carrera 045");
            sede Temuco = new sede(15, "Sede temuco", "Salvo 321", "424564789", admin3);
            coordinador coordinador3 = new coordinador("Valentina Molina", "17.365.789-8", "78520394", "Campillo 784");
            asignatura asig6 = new asignatura(1, "Matemática");
            asignatura asig7 = new asignatura(2, "Contabilidad");
            asignatura asig8 = new asignatura(3, "Computación II");
            List<asignatura> ListAsignatu = new List<asignatura>();
            ListAsignatu.Add(asig6);
            ListAsignatu.Add(asig7);
            ListAsignatu.Add(asig8);
            curso TercerCurso = new curso(2, "ADMINISTRACION", coordinador3, ListAsignatu, Temuco);
            Console.WriteLine(TercerCurso.datosCurso());
            Console.ReadKey();
        }
    }
}
