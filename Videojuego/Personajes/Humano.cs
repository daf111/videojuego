using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Humano : Personaje
    {
        public override void Pelear() { 
            if (base.PerderEnergia(2)) {
                Console.WriteLine("Peleo como humano");
            }
            else
            {
                Console.WriteLine("...");
            }
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola soy un humano");
        }
    }
}
