using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class Constructor_Proveedores
    {
        public int id_proveedores { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public string DUI { get; set; }
        public string telefono { get; set; }
        public int id_empresa { get; set; }
        public int id_estado_prov { get; set; }
        public Constructor_Proveedores (){ }
    }
}
