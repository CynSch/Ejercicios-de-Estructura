using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Estructura
{
    internal class Persona
    {
        public static List<Persona> Todas = new List<Persona>();
        public int Documento { get; set; } // 7-8 digitos
        public string Nombre { get; set; } //max 30 digitos
        public string Apellido { get; set; } // max 30 digitos
        public DateOnly FechaDeNacimiento { get; set; } //menor a la actual
    }
}
