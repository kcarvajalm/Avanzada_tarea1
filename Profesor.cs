
namespace Tarea1
{
    class Profesor : Persona
    {
        private int id;
        private decimal sueldo;
        private string usuario;
        private string contraseña;
        private Sede sede;
        private Curso[] cursos = new Curso[20];

        public Profesor()
        {
        }

        public Profesor(int id, decimal sueldo, string usuario, string contraseña, Sede sede, Curso[] cursos)
        {
            this.id = id;
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.sede = sede;
            this.cursos = cursos;
        }

        public int Id { get => id; set => id = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public Sede Sede { get => sede; set => sede = value; }
        public Curso[] Cursos { get => cursos; set => cursos = value; }

        public override string ToString()
        {
            return "ID_Profesor: " + id + "\n"
                      + base.ToString() + "\n"
                      + "Sueldo: " + sueldo + " - " + "Usuario: " + usuario + " - " + "Contraseña: " + contraseña + "\n";
                      // "Sede: " + Sede.ToString();
        }


    }
}
