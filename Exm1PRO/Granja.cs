using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exm1PRO
{
    class Granja
    {
        List<Animals> animal;
        Granjero granjero;
        float dinero;

        public void AgregarNombre()
        {
            Console.WriteLine("Coloca el nombre del granjero : ");
            string nombre = Console.ReadLine();
            bool active = true;
            while(active)
            {
                try
                {
                    Console.WriteLine("Coloca la cantidad de dinero : ");
                    dinero = float.Parse(Console.ReadLine());
                    if (dinero < 0)
                    {
                        Console.WriteLine("El dinero no puede ser un número negativo.");
                        continue;

                    }
                    active = false;


                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");

                }
               


            }
       



            granjero = new Granjero(nombre, dinero);
            Console.WriteLine($"El granjero se llama {nombre} y tiene  ${dinero} de dinero");


        }
    }
}
