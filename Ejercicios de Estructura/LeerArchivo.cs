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
            Console.WriteLine("Leyendo información guardada previamente...");

            using StreamReader reader = new StreamReader("Personas.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                //Documento|Nombre|Apellido|FechadeNacimiento

                string [] datos = linea.Split('|');

                Persona persona = new Persona();
                persona.Documento = int.Parse(datos[0]);
                persona.Nombre = datos[1]; 
                persona.Apellido = datos[2];
                persona.FechaDeNacimiento = DateOnly.Parse(datos[3]);

                Persona.Todas.Add(persona);
            }
        }
    }
}
