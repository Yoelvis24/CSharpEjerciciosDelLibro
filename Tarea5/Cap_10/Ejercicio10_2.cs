using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tarea5.Cap_10
{
    class Ejercicio10_2
    {
        //El ejercicio solo pide el diseño de una clase que tenga 
        //informacion de un Estudiante de la escuela
        //por lo que este este ejercicio se ve un poco vacio.
        Estudiantes estudiante = new Estudiantes();
    }

    class Estudiantes
    {
        public int Codigo { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string Seccion { get; set; }
        public string Curso { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double MontoMensualidad { get; set; }
        public string NombreTutor { get; set; }
        public string TelefonoTutor { get; set; }


        public Estudiantes()
        {
            Codigo = 0;
            NombreCompleto = "";
            Edad = 0;
            Seccion = "";
            Curso = "";
            Direccion = "";
            Telefono = "";
            MontoMensualidad = 0.0;
            NombreTutor = "";
            TelefonoTutor = "";
        }

        public Estudiantes(string Codigo, string Nombre, int EdadEstudiante, string CursoEstudiante, string Seccion, string DireccionEstudiante, string TelefonoEstudiante, double Mensualidad, string NombreTutorEst, string TelefonoTutorEst)
        {
            Codigo = Codigo;
            NombreCompleto = Nombre;
            Edad = EdadEstudiante;
            Seccion = Seccion;
            Curso = CursoEstudiante;
            Direccion = DireccionEstudiante;
            Telefono = TelefonoEstudiante;
            MontoMensualidad = Mensualidad;
            NombreTutor = NombreTutorEst;
            TelefonoTutor = TelefonoTutorEst;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Estudiante: \n\tCódigo: {Codigo} \n\tNombre: {NombreCompleto} \n\tEdad: {Edad} \n\tSeccion: {Seccion} \n\tCurso: {Curso} \n\tDireccion: {Direccion} \n\tTelefono: {Telefono} \n\tMensualidad: {MontoMensualidad} \n\tNombre del Tutor: {NombreTutor} \n\tTelefono del Tutor: {TelefonoTutor}");
            return (sb.ToString());
        }
    }
}
