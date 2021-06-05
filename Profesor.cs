
namespace Tarea1
{
    class Profesor : Persona
    {
        private int id;
        private decimal sueldo;
        private string usuario;
        private string contraseña;
        private Sede sede;

        public Profesor(int id, decimal sueldo, string usuario, string contraseña, Sede sede)
        {
            this.id = id;
            this.sueldo = sueldo;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.sede = sede;
        }

        public int Id { get => id; set => id = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        internal Sede Sede { get => sede; set => sede = value; }

        public override string ToString()
        {
            return base.ToString() + "ID_Profesor: " + id + " - " + "Sueldo: " + sueldo +
                        " - " + "Usuario: " + usuario + " - " + "Contraseña: " + contraseña + "Sede: " + Sede.ToString();
        }
    }
}
