using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleDevolucion
    {
        public int idPrestamo { get; set; }
        public int codigo { get; set; }
        public int cantidad { get; set; }
        public int cantidadDañada { get; set; }
    }
}
