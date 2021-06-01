
namespace Tarea1
{
    class Profesor : Persona
    {
        private int idProfe;
        private decimal sueldo;
        private string usuario;
        private string contraseña;
        private Sede sede;

        public Profesor(int idProfe, decimal sueldo, string usuario, string contraseña, Sede sede)
        {
            this.idProfe = idProfe;
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.sede = sede;
        }

        public int IdProfe { get => idProfe; set => idProfe = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

    }
}
