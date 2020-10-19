using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public String tipo { get; set; }
        public int cantidadExistencia { get; set; }
        public int cantidadBuenEstado { get; set; }
        public int cantidadMalEstado { get; set; }
        public int peso { get; set; }
        public String unidadMasa { get; set; }
        public String material { get; set; }
    }
}