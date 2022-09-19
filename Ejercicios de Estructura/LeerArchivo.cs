using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Estructura
{
    internal class LeerArchivo
    {
        public static void Inicio()
        {
            using StreamReader reader = new StreamReader("Personas.txt");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

            }
        }
    }
}
