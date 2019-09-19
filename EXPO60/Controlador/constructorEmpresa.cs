using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    public class constructorEmpresa
    {
        public int id_empresa { get; set; }
        public static string nombreEmpresa { get; set; }
        public string direccionEmpresa { get; set; }
        public string nombre { get; set; }
        public string nit { get; set; }
        public string logo { get; set; }
        public string representante { get; set; }
        public int id_tipo_empresa { get; set; }
        public constructorEmpresa() { }
    }
}
