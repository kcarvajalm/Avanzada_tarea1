using System;

namespace Tarea1
{
    class UniversidadEduca
    {

        //Inicio de Arreglo de Objetos
        private static Sede[] sedes = new Sede[20];
        private static Estudiante[] estudiantes = new Estudiante[2];
        private static Profesor[] profesores = new Profesor[20];
        private static Curso[] cursos = new Curso[20];
        static void Main(string[] args)
        {
            Array.Clear(estudiantes, 0, estudiantes.Length);

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }


        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
            Console.WriteLine("*** BIENVENIDO AL SISTEMA DE REGISTRO ***\n");
            Console.WriteLine("Opciones del Sistema:\n");
            Console.WriteLine("1) Registrar Sedes");
            Console.WriteLine("2) Registrar Cursos");
            Console.WriteLine("3) Registrar Profesores");
            Console.WriteLine("4) Registrar Estudiantes");
            Console.WriteLine("5) Realizar Matricula");
            Console.WriteLine("6) Salir");
            Console.WriteLine("\n*'*'*'*'*'*'*'*'*'*'*'*'*'*'*'*");

            Console.Write("\nPor Favor seleccione una opción:\n");

            switch (Console.ReadLine())
            {
                case "1":

                    return true;
                case "2":
                    Console.Write("Opcion 2 ");
                    Console.Write("\r\nPress Enter to return to Main Menu");
                    Console.ReadKey();
                    return true;
                case "3":
                    return true;
                case "4":
                    Console.Clear();


                    int ultimoregistro = Array.IndexOf(estudiantes, null);

                    if (ultimoregistro == -1)
                    {
                        Console.Write("Cupo lleno de estudiantes");
                        return true;

                    }

                    Console.Write("El ultimo resgistro es :" + ultimoregistro);
                    Console.ReadKey();

                    Estudiante estudiante = new Estudiante();
                    estudiante = registrarEstudiante(estudiante, sedes);
                    estudiantes.SetValue(estudiante, ultimoregistro);

                    foreach (Estudiante i in estudiantes)
                    {
                        Console.Write(i);

                    }


                    Console.ReadKey();

                    return true;
                case "5":
                    return true;
                case "6":
                    Console.WriteLine("\nUNIVERSISDA EDUCA\nGracias por utilizar el Sistema de Registro\n" +
                        "Kenneth Carvajal\nTarea 1: Programación Avanzada\nUNED - II Cuatrimestre 2021 ");
                    return false;
                default:
                    return true;
            }
        }


        private static Estudiante registrarEstudiante(Estudiante estudiante, Sede[] sedes)
        {
            Console.Clear();

            Console.Write("Ingrese la identificacion del Estudiante: ");
            estudiante.Id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del Estudiante: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Ingrese el Primer Apellido del Estudiante: ");
            estudiante.Apellido_1 = Console.ReadLine();
            Console.Write("Ingrese el Segundo Apellido del Estudiante: ");
            estudiante.Apellido_2 = Console.ReadLine();

            Console.Write("Ingrese el Genero del Estudiante: ");
            estudiante.Genero = char.Parse(Console.ReadLine());

            Console.Write("Ingrese la fecha de nacimiento: ");
            estudiante.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Sede lasede = null;
            while (lasede == null)
            {
                Console.Write("Ingrese el Id de la Sede que pertenece: ");
                int Idsede = int.Parse(Console.ReadLine());
                lasede = validarSede(sedes, Idsede);
                if (lasede != null)
                {
                    estudiante.Sede = lasede;
                }

            }
            Console.Write("Datos Estudiante :" + estudiante.ToString());
            Console.ReadKey();
            return estudiante;

        }

        private static Sede validarSede(Sede[] sede, int id)
        {
            try
            {
                sede[id] = Array.Find(sede, dato => dato.Id == id);
            }
            catch
            {
                Console.Write("La sede indicada no exite ");
                return null;
            }
            return sede[id];

        }
    }





}

