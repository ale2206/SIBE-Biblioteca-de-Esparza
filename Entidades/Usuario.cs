using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string identificacion { get; set; }
        public string nombreCompleto { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string tipo { get; set; }
        public bool estado { get; set; }
    }
}
