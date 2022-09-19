using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Estructura
{
    internal class GrabarArchivo
    {
        public static void Iniciar ()
        {
            using StreamWriter writer = File.CreateText("Personas.txt");

            foreach (Persona persona in Persona.Todas)
            {
                string linea = persona.Documento.ToString() + "|" + persona.Nombre + "|" + persona.Apellido + "|" 
                    + persona.FechaDeNacimiento.ToString();
                writer.WriteLine(linea);
            }
        }
    }
}
