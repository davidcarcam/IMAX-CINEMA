using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class Constructor_DetalleTicket
    {
        public int id_detalleTicket { get; set; }
        public string cantidad { get; set; }
        public string subtotal { get; set; }
        public string funcion_titulo { get; set; }
        public string duracion { get; set; }
        public string hora { get; set; }
        public string dia { get; set; }

        public string sala { get; set; }
        public string clasifiacion { get; set; }
        public string precio { get; set; }

        public Constructor_DetalleTicket() { }
    }
}
