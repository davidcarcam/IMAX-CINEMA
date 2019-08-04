using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class ContructorLogin
    {
        public static string usuario { get; set; }
        public string clave { get; set; }
        public static string nombre { get; set; }
        public static int nivel { get; set; }
        public ContructorLogin(string usuario, string clave)
        {
            usuario = ContructorLogin.usuario;
            clave = this.clave;
        }

    }
}
