using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class ConstructorRecuperar_admin
    {
        public static string usuario { get; set; }

        public string clave { get; set; }

        public static string nombre { get; set; }

        public static int nivel { get; set; }
        public static string usuarioRecu { get; set; }

        public static int nivelRecu { get; set; }

        public ConstructorRecuperar_admin(string usuario, string clave)
        {
            usuario = ConstructorRecuperar_admin.usuario;
            clave = this.clave;
            usuarioRecu = ConstructorRecuperar_admin.usuarioRecu;
        }
    }
}
