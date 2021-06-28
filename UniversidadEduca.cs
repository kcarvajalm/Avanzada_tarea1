using System;

namespace Tarea1
{
    class UniversidadEduca
    {

        //Inicio de Arreglo de Objetos
        private static Sede[] sedesArreglo = new Sede[2];
        private static Estudiante[] estudiantesArreglo = new Estudiante[20];
        private static Profesor[] profesArreglo = new Profesor[20];
        private static Curso[] cursosArreglo = new Curso[20];

        static void Main(string[] args)
        {
            // Se realiza el clear a los arreglos
            Array.Clear(estudiantesArreglo, 0, estudiantesArreglo.Length);
            Array.Clear(sedesArreglo, 0, sedesArreglo.Length);
            Array.Clear(profesArreglo, 0, profesArreglo.Length);
            Array.Clear(cursosArreglo, 0, cursosArreglo.Length);


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
            Console.WriteLine("2) Registrar Profesores");
            Console.WriteLine("3) Registrar Estudiantes");
            Console.WriteLine("4) Registrar Cursos");
            Console.WriteLine("5) Realizar Matricula");
            Console.WriteLine("6) Asignar curso a profesor");
            Console.WriteLine("7) Mostrar Estudiantes");
            Console.WriteLine("8) Mostrar Profesores");
            Console.WriteLine("9) Salir");
            Console.WriteLine("\n*'*'*'*'*'*'*'*'*'*'*'*'*'*'*'*");

            Console.Write("\nPor Favor seleccione una opción:\n");

            switch (Console.ReadLine())
            {
                case "1":

                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** REGISTRO DE SEDES ***** \n\n");


                    int ultimoRegSedes = Array.IndexOf(sedesArreglo, null);
                    if (ultimoRegSedes == -1)
                    {
                        Console.Clear();
                        Console.Write("Atención!!!\n No se pueden registrar mas sedes");
                        Console.ReadKey();
                        return true;
                    }

                    Sede sede = new Sede();
                    sede = registrarSede(sede);
                    if (sede == null)
                    {
                        return true;
                    }

                    sedesArreglo.SetValue(sede, ultimoRegSedes);
                    Console.WriteLine("\n***** Sede Registrada ***** \n\n");
                    Console.ReadKey();
                    return true;


                case "2":


                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** REGISTRO DE PROFESORES ***** \n\n");

                    ultimoRegSedes = Array.IndexOf(sedesArreglo, null);
                    if (ultimoRegSedes == 0)
                    {
                        Console.Write("Atención!!!\n Proceda primero a registrar una sede");
                        Console.ReadKey();
                        return true;
                    }

                    int ultimoRegProfes = Array.IndexOf(profesArreglo, null);
                    if (ultimoRegProfes == -1)
                    {
                        Console.Clear();
                        Console.Write("Atención!!!\n No se pueden registrar mas Profesores");
                        Console.ReadKey();
                        return true;
                    }

                    Profesor profesor = new Profesor();
                    profesor = registrarProfesores(profesor);
                    if (profesor == null)
                    {
                        return true;
                    }
                    profesArreglo.SetValue(profesor, ultimoRegProfes);
                    Console.WriteLine("\n***** Profesor Registrado ***** \n\n");
                    Console.ReadKey();
                    return true;


                case "3":
                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** REGISTRO DE ESTUDIANTES ***** \n\n");

                    ultimoRegSedes = Array.IndexOf(sedesArreglo, null);
                    if (ultimoRegSedes == 0)
                    {
                        Console.Write("Atención!!!\n Proceda primero a registrar una sede");
                        Console.ReadKey();
                        return true;
                    }
                    int ultimoRegEstudiantes = Array.IndexOf(estudiantesArreglo, null);

                    if (ultimoRegEstudiantes == -1)
                    {
                        Console.Write("Atención!!!\n No se pueden registrar mas estudiantes");
                        return true;

                    }
                    Estudiante estudiante = new Estudiante();
                    estudiante = registrarEstudiante(estudiante);
                    if (estudiante == null)
                    {
                        return true;
                    }

                    estudiantesArreglo.SetValue(estudiante, ultimoRegEstudiantes);
                    Console.WriteLine("\n***** Estudiante Registrado ***** \n\n");
                    Console.ReadKey();
                    return true;



                case "4":
                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** REGISTRO DE CURSOS ***** \n\n");

                    int ultimoRegCursos = Array.IndexOf(cursosArreglo, null);

                    if (ultimoRegCursos == -1)
                    {
                        Console.Write("Atención!!!\n No se pueden registrar mas cursos");
                        Console.ReadKey();
                        return true;

                    }
                    Curso curso = new Curso();
                    curso = registrarCurso(curso);
                    if (curso == null)
                    {
                        return true;
                    }
                    cursosArreglo.SetValue(curso, ultimoRegCursos);
                    Console.WriteLine("\n***** Curso Registrado ***** \n\n");
                    Console.ReadKey();
                    return true;



                case "5":
                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** MATRICULA DE ESTUDIANTE ***** \n\n");

                    ultimoRegEstudiantes = Array.IndexOf(estudiantesArreglo, null);
                    if (ultimoRegEstudiantes == 0)
                    {
                        Console.Write("Atención!!!\n Proceda primero a registrar estudiantes");
                        Console.ReadKey();
                        return true;
                    }

                    ultimoRegCursos = Array.IndexOf(cursosArreglo, null);

                    if (ultimoRegCursos == 0)
                    {
                        Console.Write("Atención!!!\n Proceda primero a registrar cursos");
                        Console.ReadKey();
                        return true;
                    }

                    Estudiante conMatricula = matriculaEstudiante();
                    if (conMatricula != null)
                    {
                        int index = Array.FindIndex(estudiantesArreglo, (x) => x != null && x.Id.Equals(conMatricula.Id));
                        estudiantesArreglo.SetValue(conMatricula, index);
                        Console.WriteLine("\n***** Matricula Realizada ***** \n\n");
                        Console.ReadKey();
                    }

                    return true;


                case "6":
                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** ASIGNACION DE CURSOS A PROFESORES ***** \n\n");

                    ultimoRegProfes = Array.IndexOf(profesArreglo, null);
                    if (ultimoRegProfes == 0)
                    {
                        Console.Write("Atención!!!\n Proceda primero a registrar profesores");
                        Console.ReadKey();
                        return true;
                    }

                    ultimoRegCursos = Array.IndexOf(cursosArreglo, null);

                    if (ultimoRegCursos == 0)
                    {
                        Console.Write("Atención!!!\n Proceda primero a registrar cursos");
                        Console.ReadKey();
                        return true;
                    }

                    Profesor conCurso = asignacionCurso();
                    if (conCurso != null)
                    {
                        int index = Array.FindIndex(profesArreglo, (x) => x != null && x.Id.Equals(conCurso.Id));
                        profesArreglo.SetValue(conCurso, index);
                        Console.WriteLine("\n***** Asignacion correcta de curso ***** \n\n");
                        Console.ReadKey();
                    }

                    return true;

                case "7":
                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** ESTUDIANTES REGISTRADOS ***** \n\n");

                    ultimoRegEstudiantes = Array.IndexOf(estudiantesArreglo, null);

                    if (ultimoRegEstudiantes == 0)
                    {
                        Console.Write("Atención!!!\n No existen estudiantes Registrados");
                        Console.ReadKey();
                        return true;

                    }

                    foreach (Estudiante e in estudiantesArreglo)
                    {
                        if (e != null)
                        {
                            Console.Write(e);
                            Console.Write(e.Sede);
                            Console.Write("\n- - - - - - - - - - - - - - - -\n");

                            foreach (Curso c in e.Cursos)
                            {
                                if (c != null)
                                {
                                    Console.Write("\nRegistrado en los cursos\n");
                                    Console.Write(c);
                                    Console.Write("\n-----------------------------\n");
                                }
                            }
                            Console.Write("\n*********************************\n");
                        }
                    }
                    Console.ReadKey();

                    return true;
                case "8":
                    Console.Clear();
                    Console.WriteLine("***** UNIVERSIDAD EDUCA ***** \n\n");
                    Console.WriteLine("***** PROFESORES REGISTRADOS ***** \n\n");

                    ultimoRegProfes = Array.IndexOf(profesArreglo, null);

                    if (ultimoRegProfes == 0)
                    {
                        Console.Write("Atención!!!\n No existen profesores Registrados");
                        Console.ReadKey();
                        return true;

                    }
                    // Imprime en datalle los datos de los profesores con los cursos asignados
                    foreach (Profesor p in profesArreglo)
                    {
                        if (p != null)
                        {
                            Console.Write(p);
                            Console.Write(p.Sede);
                            Console.Write("\n- - - - - - - - - - - - - - - -\n");

                            foreach (Curso c in p.Cursos)
                            {
                                if (c != null)
                                {
                                    Console.Write("\nAsignado en curso\n");
                                    Console.Write(c);
                                    Console.Write("\n-----------------------------\n");
                                }
                            }
                            Console.Write("\n*********************************\n");

                        }

                    }
                    Console.ReadKey();

                    return true;


                case "9":
                    Console.Clear();
                    Console.WriteLine("\nUNIVERSISDA EDUCA\nGracias por utilizar el Sistema de Registro\n" +
                        "Kenneth Carvajal\nTarea 1: Programación Avanzada\nUNED - II Cuatrimestre 2021 ");
                    Console.ReadKey();
                    return false;
                default:
                    return true;
            }
        }


        // Registra una sede en el sistema
        private static Sede registrarSede(Sede sede)
        {
            try
            {
                Console.Write("Ingrese la identificacion de la Sede: ");
                sede.Id = int.Parse(Console.ReadLine());
                if (buscarSede(sede.Id) != null)
                {
                    Console.Write("Atencion!!!\n Ya existe una sede con esa Identificacion\npor favor vuelva a intentarlo ");
                    Console.ReadKey();
                    return null;
                }

                Console.Write("Ingrese la descripcion de la Sede: ");
                sede.Descripcion = Console.ReadLine();

                return sede;
            }
            catch (Exception)
            {
                Console.Write("Atencion!!!\n Ha ingresado un dato incorrecto\npor favor vuelva a intentarlo ");
                Console.ReadKey();
                return null;

            }

        }


        // Registra un estudiante en el sistema
        private static Estudiante registrarEstudiante(Estudiante estudiante)
        {
            try
            {
                Console.Write("Ingrese la identificacion del Estudiante: ");
                estudiante.Id = int.Parse(Console.ReadLine());
                if (buscarEstudiante(estudiante.Id) != null)
                {
                    Console.Write("Atencion!!!\n Ya existe un estudiante con esa Identificacion\npor favor vuelva a intentarlo ");
                    Console.ReadKey();
                    return null;
                }

                Console.Write("Ingrese el nombre del Estudiante: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write("Ingrese el Primer Apellido del Estudiante: ");
                estudiante.Apellido_1 = Console.ReadLine();
                Console.Write("Ingrese el Segundo Apellido del Estudiante: ");
                estudiante.Apellido_2 = Console.ReadLine();

                while (!estudiante.Genero.Equals('F') && !estudiante.Genero.Equals('M'))
                {
                    Console.Write("Ingrese el Genero del Estudiante (F / M): ");
                    estudiante.Genero = char.Parse(Console.ReadLine());
                }


                Console.Write("Ingrese la fecha de nacimiento (dd/MM/yyyy): ");
                estudiante.FechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("Datos Estudiante :\n" + estudiante.ToString());
                Console.ReadKey();
                return estudiante;
            }
            catch (Exception)
            {
                Console.Write("Atencion!!!\n Ha ingresado un dato incorrecto\npor favor vuelva a intentarlo ");
                Console.ReadKey();
                return null;

            }

        }


        // Registra un profesor en el sistema
        private static Profesor registrarProfesores(Profesor profesor)
        {
            try
            {
                Console.Write("Ingrese la identificacion del Profesor: ");
                profesor.Id = int.Parse(Console.ReadLine());
                if (buscarProfesor(profesor.Id) != null)
                {
                    Console.Write("Atencion!!!\n Ya existe un profesor con esa Identificacion\npor favor vuelva a intentarlo ");
                    Console.ReadKey();
                    return null;
                }

                Console.Write("Ingrese el nombre del Profesor: ");
                profesor.Nombre = Console.ReadLine();

                Console.Write("Ingrese el Primer Apellido del Profesor: ");
                profesor.Apellido_1 = Console.ReadLine();
                Console.Write("Ingrese el Segundo Apellido del Profesor: ");
                profesor.Apellido_2 = Console.ReadLine();

                Console.Write("Ingrese el sueldo del Profesor: ");
                profesor.Sueldo = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese el Usuario del Profesor: ");
                profesor.Usuario = Console.ReadLine();

                Console.Write("Ingrese la contraseña: ");
                profesor.Contraseña = Console.ReadLine();

                Console.Clear();
                Console.Write("Datos Porfesor :\n" + profesor.ToString());
                Console.ReadKey();

                return profesor;

            }
            catch (Exception)
            {
                Console.Write("Atencion!!!\n Ha ingresado un dato incorrecto\npor favor vuelva a intentarlo ");
                Console.ReadKey();
                return null;

            }

        }


        // Registra un curso en el sistema 
        private static Curso registrarCurso(Curso curso)
        {
            try
            {
                Console.Write("Ingrese la identificacion del Curso: : ");
                curso.Id = int.Parse(Console.ReadLine());
                if (buscarCurso(curso.Id) != null)
                {
                    Console.Write("Atencion!!!\n Ya existe una sede con esa Identificacion\npor favor vuelva a intentarlo ");
                    Console.ReadKey();
                    return null;
                }
                Console.Write("Ingrese el nombre del Curso: ");
                curso.Nombre = Console.ReadLine();
                Console.Write("Ingrese la descripcion del Curso: ");
                curso.Descripcion = Console.ReadLine();

                Console.Clear();
                Console.Write("Datos del Curso :\n" + curso.ToString());
                Console.ReadKey();

                return curso;
            }
            catch (Exception)
            {
                Console.Write("Atencion!!!\n Ha ingresado un dato incorrecto\npor favor vuelva a intentarlo ");
                Console.ReadKey();
                return null;

            }

        }


        // Matricula un curso al estudiante seleccionado
        private static Estudiante matriculaEstudiante()
        {
            try
            {
                Console.Clear();
                Sede sedeMatricula = null;
                while (sedeMatricula == null)
                {
                    Console.Clear();
                    imprimirSedes();
                    Console.Write("Ingrese el id de la Sede : ");
                    int idSede = int.Parse(Console.ReadLine());
                    sedeMatricula = buscarSede(idSede);
                    if (sedeMatricula == null)
                    {
                        Console.Write("Atencion!!!\n No existe uns sede con el Id indicado\npor favor vuelva a intentarlo ");
                        Console.ReadKey();

                    }
                }

                Estudiante estudianteMatricula = null;
                while (estudianteMatricula == null)
                {
                    imprimirEstudiantes();
                    Console.Write("Ingrese el id del Estudiante: ");
                    int idEstudiante = int.Parse(Console.ReadLine());
                    estudianteMatricula = buscarEstudiante(idEstudiante);
                    if (estudianteMatricula == null)
                    {
                        Console.Write("Atencion!!!\n No existe un estudiante con el Id indicado\npor favor vuelva a intentarlo ");
                        Console.ReadKey();

                    }
                }

                Curso cursoMatricula = null;
                while (cursoMatricula == null)
                {

                    imprimirCursos();
                    Console.Write("Ingrese el id del Curso: ");
                    int idCurso = int.Parse(Console.ReadLine());
                    cursoMatricula = buscarCurso(idCurso);
                    if (cursoMatricula == null)
                    {
                        Console.Write("Atencion!!!\n No existe un curso con el Id indicado\npor favor vuelva a intentarlo ");
                        Console.ReadKey();
                    }
                }

                int ultimoCursoEstidiante = Array.IndexOf(estudianteMatricula.Cursos, null);

                if (ultimoCursoEstidiante == -1)
                {
                    Console.Write("Atencion!!!\n El estudiante no puede matricular mas cursos\n");
                    Console.ReadKey();

                    return null;

                }
                estudianteMatricula.Sede = sedeMatricula;
                estudianteMatricula.Cursos.SetValue(cursoMatricula, ultimoCursoEstidiante);

                Console.Clear();

                Console.Write("Datos de la Matricula del Estudiante\n");

                Console.Write(estudianteMatricula.ToString() + "\n"
                    + estudianteMatricula.Sede + "\n"
                    + estudianteMatricula.Cursos[ultimoCursoEstidiante] + "\n");


                Console.ReadKey();

                return estudianteMatricula;

            }
            catch (Exception)
            {
                Console.Write("Atencion!!!\n Ha ingresado un dato incorrecto\npor favor vuelva a intentarlo ");
                Console.ReadKey();
                return null;

            }

        }


        // Asigna un curso al profesor seleccionado
        private static Profesor asignacionCurso()
        {
            try
            {
                Console.Clear();
                Sede sedeMatricula = null;
                while (sedeMatricula == null)
                {
                    Console.Clear();
                    imprimirSedes();
                    Console.Write("Ingrese el id de la Sede : ");
                    int idSede = int.Parse(Console.ReadLine());
                    sedeMatricula = buscarSede(idSede);
                    if (sedeMatricula == null)
                    {
                        Console.Write("Atencion!!!\n No existe uns sede con el Id indicado\npor favor vuelva a intentarlo ");
                        Console.ReadKey();

                    }
                }

                Profesor profeCurso = null;
                while (profeCurso == null)
                {
                    imprimirProfesores();
                    Console.Write("Ingrese el id del Profesor: ");
                    int idProfesor = int.Parse(Console.ReadLine());
                    profeCurso = buscarProfesor(idProfesor);
                    if (profeCurso == null)
                    {
                        Console.Write("Atencion!!!\n No existe un profesor con el Id indicado\npor favor vuelva a intentarlo ");
                        Console.ReadKey();

                    }
                }

                Curso cursoMatricula = null;
                while (cursoMatricula == null)
                {

                    imprimirCursos();
                    Console.Write("Ingrese el id del Curso: ");
                    int idCurso = int.Parse(Console.ReadLine());
                    cursoMatricula = buscarCurso(idCurso);
                    if (cursoMatricula == null)
                    {
                        Console.Write("Atencion!!!\n No existe un curso con el Id indicado\npor favor vuelva a intentarlo ");
                        Console.ReadKey();
                    }
                }

                int ultimoCursoProfesor = Array.IndexOf(profeCurso.Cursos, null);

                if (ultimoCursoProfesor == -1)
                {
                    Console.Write("Atencion!!!\n El profesor no se le pueden asignar mas cursos\n");
                    Console.ReadKey();

                    return null;

                }
                profeCurso.Sede = sedeMatricula;
                profeCurso.Cursos.SetValue(cursoMatricula, ultimoCursoProfesor);

                Console.Clear();

                Console.Write("Datos de la Matricula del Estudiante\n");

                Console.Write(profeCurso.ToString() + "\n"
                    + profeCurso.Sede + "\n"
                    + profeCurso.Cursos[ultimoCursoProfesor] + "\n");


                Console.ReadKey();

                return profeCurso;

            }
            catch (Exception)
            {
                Console.Write("Atencion!!!\n Ha ingresado un dato incorrecto\npor favor vuelva a intentarlo ");
                Console.ReadKey();
                return null;

            }

        }


        // Busca la sede en el arreglo segun su ID
        private static Sede buscarSede(int id)
        {
            int index = -1;
            try
            {
                index = Array.FindIndex(sedesArreglo, (x) => x != null && x.Id.Equals(id));
                if (index == -1)
                {
                    return null;
                }
                else
                {
                    return sedesArreglo[index];
                }
            }
            catch (Exception)
            {
                Console.Write("Error buscando sede ");
                return null;
            }
        }


        // Busca el curso en el arreglo segun su ID
        private static Curso buscarCurso(int id)
        {
            int index = -1;
            try
            {
                index = Array.FindIndex(cursosArreglo, (x) => x != null && x.Id.Equals(id));
                if (index == -1)
                {
                    return null;
                }
                else
                {
                    return cursosArreglo[index];
                }
            }
            catch (Exception)
            {
                Console.Write("Error buscando curso ");
                return null;
            }
        }


        // Busca el estudiante en el arreglo segun su ID
        private static Estudiante buscarEstudiante(int id)
        {
            int index = -1;
            try
            {
                index = Array.FindIndex(estudiantesArreglo, (x) => x != null && x.Id.Equals(id));
                if (index == -1)
                {
                    return null;
                }
                else
                {
                    return estudiantesArreglo[index];
                }
            }
            catch (Exception)
            {
                Console.Write("Error buscando estudiante ");
                return null;
            }
        }


        // Busca el profesor en el arreglo segun su ID
        private static Profesor buscarProfesor(int id)
        {
            int index = -1;
            try
            {
                index = Array.FindIndex(profesArreglo, (x) => x != null && x.Id.Equals(id));
                if (index == -1)
                {
                    return null;
                }
                else
                {
                    return profesArreglo[index];
                }
            }
            catch (Exception)
            {
                Console.Write("Error buscando profesor ");
                return null;
            }
        }


        // Imprime las sedes del arreglo que no son null
        private static void imprimirSedes()
        {
            Console.Clear();
            Console.WriteLine("***** LISTA DE SEDES ***** \n\n");
            foreach (Sede s in sedesArreglo)
            {
                if (s != null)
                {
                    Console.Write(s);
                    Console.Write("\n=========================\n");

                }

            }
        }


        // Imprime los estudiantes del arreglo que no son null
        private static void imprimirEstudiantes()
        {
            Console.Clear();
            Console.WriteLine("***** LISTA DE ESTUDIANTES ***** \n\n");
            foreach (Estudiante e in estudiantesArreglo)
            {
                if (e != null)
                {
                    Console.Write(e);
                    Console.Write("\n*************************\n");

                }

            }
        }


        // Imprime los profesores del arreglo que no son null
        private static void imprimirProfesores()
        {
            Console.Clear();
            Console.WriteLine("***** LISTA DE PROFESORES ***** \n\n");
            foreach (Profesor p in profesArreglo)
            {
                if (p != null)
                {
                    Console.Write(p);
                    Console.Write("\n*************************\n");

                }

            }
        }


        // Imprime los cursos del arreglo que no son null
        private static void imprimirCursos()
        {
            Console.Clear();
            Console.WriteLine("***** LISTA DE CURSOS ***** \n\n");
            foreach (Curso c in cursosArreglo)
            {
                if (c != null)
                {
                    Console.Write(c);
                    Console.Write("\n-------------------------\n");

                }

            }
        }
    }





}

