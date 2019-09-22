using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPO60.Controlador
{
     class Constructor_pelicula
    {
        public int id_pelicula { get; set; }
        public string Titulo { get; set; }
        public string Año { get; set; }
        public string Director { get; set; }
        public int Idioma { get; set; }
        public int tipo { get; set; }
        public int dimensiones { get; set; }
        public int clasificacion { get; set; }
        public int estado { get; set; }
        public string foto { get; set; }
        public Constructor_pelicula() { }
    }
}
