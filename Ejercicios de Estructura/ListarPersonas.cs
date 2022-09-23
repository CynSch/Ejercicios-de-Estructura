using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Estructura
{
    internal class ListarPersonas
    {
        public static void Listar()
        {
            foreach (Persona persona in Persona.Todas)
            {
                Console.WriteLine("Documento: " + persona.Documento
                    + "\n Nombre: " + persona.Nombre
                    + "\n Apellido: " + persona.Apellido
                    + "\n Fecha de Nacimiento: " + persona.FechaDeNacimiento + "\n");
            }
        }
    }
}
