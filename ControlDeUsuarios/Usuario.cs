using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeUsuarios
{
    internal class Usuario
    {
        public String usuario { get; set; }
        public String contrasena { get; set; }

        public Usuario() { 
        this.usuario = "root";
        this.contrasena = "root";
        }
    }
}
