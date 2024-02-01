using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Socio
    {
        private string nombre { get; set; } = null!;
        /*
         * Antigüedad en el club (en años)
         */
        private int antiguedad { get; set; }
        public string Nombre
        {
            get { return nombre; }
        }
        public int Antiguedad
        {
            get { return antiguedad; }
        }
        public Socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }
    }
}
