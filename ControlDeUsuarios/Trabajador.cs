using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeUsuarios
{
    internal class Trabajador
    {
        public String id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String UID { get; set; }

        public Trabajador() { 
        
            id = "";
            nombre = "";
            apellido = "";
            UID = "";
        }
    }
}
