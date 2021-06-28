using System;

namespace Tarea1
{
    class Estudiante : Persona
    {
        private int id;
        private DateTime fechaNacimiento;
        private char genero;
        private Sede sede;
        private Curso[] cursos = new Curso[20];

        public Estudiante()
        {
        }

        public Estudiante(int id, DateTime fechaNacimiento, char genero, Sede sede, Curso[] cursos)
        {
            this.id = id;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.sede = sede;
            this.cursos = cursos;
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char Genero { get => genero; set => genero = value; }
        public Sede Sede { get => sede; set => sede = value; }
        public Curso[] Cursos { get => cursos; set => cursos = value; }

        public override string ToString()
        {
            return "ID_Estudiante: " + id + "\n"
                    + base.ToString() + "\n"
                    + "Fecha_Nacimiento: " + fechaNacimiento + " - " + "Genero: " + genero + "\n";
            // "Sede: " + Sede.ToString() + "\n";
            //+ "Cursos" + Cursos.ToString();
        }


    }
}
