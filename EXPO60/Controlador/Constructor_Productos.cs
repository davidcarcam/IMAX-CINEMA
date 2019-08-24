using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class Constructor_Productos
    {
        public int idproducto { get; set; }
        public string nombre { get; set; }
        public string precio { get; set; }
        public int local { get; set; }
      
        public int proveedor { get; set; }
        public int tipoproducto { get; set; }
        public Constructor_Productos() { }
    }
}
