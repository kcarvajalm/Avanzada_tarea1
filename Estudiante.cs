using System;

namespace Tarea1
{
    class Estudiante : Persona
    {
        private int idEstudiante;
        private DateTime fechaNacimiento;
        private char genero;
        private Sede sede;

        public Estudiante()
        {
        }

        public Estudiante(int idEstudiante, DateTime fechaNacimiento, char genero, Sede sede)
        {
            this.idEstudiante = idEstudiante;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.sede = sede;
        }

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Genero { get => genero; set => genero = value; }
        public Sede Sede { get => sede; set => sede = value; }

        public override string ToString()
        {
            return "ID_Estudiante: " + idEstudiante + " - " + "fechaNacimiento: " + fechaNacimiento +
                        " - " + "genero: " + genero + " - " + "sede: " + sede;
        }
    }
}
