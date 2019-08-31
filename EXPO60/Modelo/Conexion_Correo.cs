using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Modelo
{
    class Conexion_Correo: Validacion_Correo
    {
        public Conexion_Correo()
        {
            sendermail = "ayuda.imax@gmail.com";
            password = "Ricaldone2019";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            initializesmtpclient();
        }
    }
}
