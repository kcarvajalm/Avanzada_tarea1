/*
 * Kenneth Carvajal Mesen
 * 1-1183-0218
 * Tarea 1 Programación Avanzada
 * UNED II Cuatrimestre 2021
 */



namespace Tarea1
{
    class Curso
    {
        private int id;
        private string nombre;
        private string descripcion;

        public Curso()
        {
        }

        public Curso(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return "ID_Curso: " + id + " - " + "Nombre_Curso: " + nombre + " - " + "Descripcion_Curso: " + descripcion + "\n";
        }
    }


}
