using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        public int idPrestamo { get; set; }
        public String identificacion { get; set; }
        public String fechaHora { get; set; }
        public String nombreUsuario { get; set; }
        public List<DetallePrestamo> listaDetalles { get; set; } 
    }
}
