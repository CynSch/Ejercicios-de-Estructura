using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Estructura
{
    internal class AgregarPersonas
    {
        internal static void Iniciar()
        {
            while (true)
            {
                //Datos que componen la persona:
                //Documento|Nombre|Apellido|Fecha de Nacimiento

                //ciclo del documento
                int documento = 0;
                while (true)
                {
                    Console.WriteLine("Ingrese el numero de documento de la persona");
                    string ingreso = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(ingreso))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                        continue;
                    }
                    
                    if(!int.TryParse(ingreso, out int documentoingresado))
                    {
                        Console.WriteLine("Ingrese un valor numerico valido");
                        continue;
                    }

                    if(documentoingresado < 1000000 || documentoingresado > 99999999)
                    {
                        Console.WriteLine("El numero debe tener entre 7 y 8 digitos");
                        continue;
                    }
                    documento = documentoingresado;
                    break;
                }

                //ciclo de Nombre
                string nombre = "";
                while(true)
                {
                    Console.WriteLine("Ingrese el nombre de la persona");
                    nombre = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("Debe ingresar un nombre");
                        continue;
                    }    

                    if (nombre.Length > 30)
                    {
                        Console.WriteLine("Debe utilizar como máximo 30 caracteres");
                        continue;
                    }

                   bool ok = true;
                    foreach (char caracter in nombre)
                    {
                        if(caracter < 'A' || caracter > 'z')
                        {
                            Console.WriteLine("Debe utilizar letras solamente");
                            ok = false;
                            break;
                        }
                    }
                    if(!ok)
                    {
                        continue;
                    }
                    break;
                }

                //ciclo de Apellido
                string apellido = "";
                while (true)
                {
                    Console.WriteLine("Ingrese el apellido de la persona");
                    apellido = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(apellido))
                    {
                        Console.WriteLine("Debe ingresar un apellido");
                        continue;
                    }

                    if (apellido.Length > 30)
                    {
                        Console.WriteLine("Debe utilizar como máximo 30 caracteres");
                        continue;
                    }

                    bool ok = true;
                    foreach (char caracter in apellido)
                    {
                        if (caracter < 'A' || caracter > 'z')
                        {
                            Console.WriteLine("Debe utilizar letras solamente");
                            ok = false;
                            break;
                        }
                    }
                    if (!ok)
                    {
                        continue;
                    }
                    break;
                }

                //ciclo de Fecha de Nacimiento
                DateOnly fechadenacimiento = DateOnly.FromDateTime(DateTime.Now);
                while(true)
                {
                    Console.WriteLine("Ingrese la fecha de nacimiento");
                    string ingresado = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresado))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                        continue;
                    }

                    if(!DateOnly.TryParse(ingresado, out DateOnly fechadenacimientoingresada))
                    {
                        Console.WriteLine("Debe ingresar un valor fecha");
                        continue;
                    }

                    if(fechadenacimientoingresada >= DateOnly.FromDateTime(DateTime.Now))
                    {
                        Console.WriteLine("La fecha debe ser previa al dia de hoy (no futura)");
                        continue;
                    }

                    fechadenacimiento = fechadenacimientoingresada;
                    break;
                }

                var persona = new Persona();
                persona.Documento = documento;
                persona.Nombre = nombre;
                persona.Apellido = apellido;
                persona.FechaDeNacimiento = fechadenacimiento;

                Persona.Todas.Add(persona);

                break;
            }
        }
    }
}
