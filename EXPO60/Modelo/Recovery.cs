using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Modelo
{
    class Recovery
    {

        public string recovery(string solicitud)
        {
            return ValidarLogin.recover(solicitud);
        }
    }
}
