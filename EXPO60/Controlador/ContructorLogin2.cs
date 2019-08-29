using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
   public class ContructorLogin2
    {
        public static string usuario { get; set; }
        public static string clave { get; set; }
        public static string nombre { get; set; }
        public static int nivel { get; set; }
        public ContructorLogin2(string usuario, string clave)
        {
            usuario = ContructorLogin2.usuario;
            clave = ContructorLogin2.clave;
        }
    }
}
