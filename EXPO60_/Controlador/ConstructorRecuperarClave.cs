using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class ConstructorRecuperarClave
    {
        public static string usuario { get; set; }

        public string clave { get; set; }

        public static string nombre { get; set; }

        public static int nivel { get; set; }
        public static string usuarioRecu { get; set; }

        public static int nivelRecu { get; set; }

        public ConstructorRecuperarClave(string usuario, string clave)
        {
            usuario = ConstructorRecuperarClave.usuario;
            clave = this.clave;
            usuarioRecu = ConstructorRecuperarClave.usuarioRecu;
        }
    }
}
