using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class Constructo_Factura_Local
    {
        public int id_factura_local { get; set; }
        public string monto_fac_local { get; set; }
        public string fecha_fac_local { get; set; }
        public string nombre_cliente { get; set; }
        public int id_usuario { get; set; }
        public Constructo_Factura_Local() { }
    }
}
