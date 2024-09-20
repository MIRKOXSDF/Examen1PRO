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

        public void Game()
        {
            Console.WriteLine("Coloca el nombre del granjero : ");
            string nombre = Console.ReadLine();
            try
            {
                Console.WriteLine("Coloca la cantidad de dinero : ");
                dinero = float.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
               
            }



            granjero = new Granjero(nombre, dinero);
            Console.WriteLine($"El granjero se llama {nombre} y tiene  {dinero} de dinero");


        }
    }
}
