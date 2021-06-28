/*
 * Kenneth Carvajal Mesen
 * 1-1183-0218
 * Tarea 1 Programación Avanzada
 * UNED II Cuatrimestre 2021
 */

namespace Tarea1
{
    class Persona
    {
        private string nombre;
        private string apellido_1;
        private string apellido_2;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido_1, string apellido_2)
        {
            this.nombre = nombre;
            this.apellido_1 = apellido_1;
            this.apellido_2 = apellido_2;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_1 { get => apellido_1; set => apellido_1 = value; }
        public string Apellido_2 { get => apellido_2; set => apellido_2 = value; }

        public override string ToString()
        {
            return "Nombre: " + nombre + " - " + "Apellido_1: " + apellido_1 + " - " + "Apellido_2: " + apellido_2;
        }
    }
}
