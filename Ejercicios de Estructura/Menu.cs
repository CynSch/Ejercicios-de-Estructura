using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Estructura
{
    internal class Menu
    {
        public static void Listar()
        {

            do
            {
                Console.WriteLine("1. Agregar persona");
                Console.WriteLine("2. Guardar");
                Console.WriteLine("3. Ver lista de personas guardadas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese su opción");

                string ingreso = Console.ReadLine();

                if(!int.TryParse(ingreso, out int opcion))
                {
                    Console.WriteLine("Ingrese un número de opción");
                    continue;
                }

                if(opcion == 1)
                {
                    AgregarPersonas.Iniciar();
                }

                if(opcion == 2)
                {
                    GrabarArchivo.Iniciar();
                }

                if(opcion==3)
                {
                    ListarPersonas.Listar();
                }

                if(opcion == 4)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Ingrese un numero del 1 al 4");
                }
            } while (true);
        }
    }
}
