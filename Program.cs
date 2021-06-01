using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sede sede = new Sede();
            sede.Id = 1;
            sede.Descripcion = "La Primera";

            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = "Kenneth";
            estudiante.Apellido_1 = "Carvajal";
            estudiante.Apellido_2 = "Mesen";
            estudiante.IdEstudiante = 1;
            estudiante.Genero = 'M';
            estudiante.Sede = sede;

            Console.WriteLine(estudiante.ToString());




            //Console.WriteLine(sede.ToString());


        }
    }
}
