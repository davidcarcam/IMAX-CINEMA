using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
    class Constructor_Asientos
    {
        public int ID_Asiento { get; set; }
        public string Asiento { get; set; }
        public int ID_Sala { get; set; }
        public int ID_Estado_Asiento { get; set; }
        public Constructor_Asientos() { }
    }
}