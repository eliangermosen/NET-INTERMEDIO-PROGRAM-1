using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Club
    {
        public Socio socioUno = new Socio("John", 2);
        public Socio socioDos = new Socio("Manuel", 1);
        public Socio socioTres = new Socio("Stacy", 4);

        public string MayorAntiguedad()
        {
            Socio[] socios = { socioUno, socioDos, socioTres };
            var socioMayor = socios.MaxBy(s => s.Antiguedad)!;
            return $"El socio o la socia con mayor antiguedad es {socioMayor.Nombre} con {socioMayor.Antiguedad} años!";
        }
    }
}
