using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exm1PRO
{
    class Animals : IAnimal
    {
        public string nombre;
        public int cantidadDeLeche;

        public Animals(string name, int cantidadDeLeche)
        {
            this.nombre = name;
            this.cantidadDeLeche = cantidadDeLeche;
        }

        public void Ordeñar()
        {
            if (cantidadDeLeche > 0)
            {
                Console.WriteLine($"Ordeñaste a {nombre} y obtuviste {cantidadDeLeche} litros de leche.");

            }
            else
            {
                Console.WriteLine($"{nombre} no tiene leche disponible.");

            }
        }
    }
}
