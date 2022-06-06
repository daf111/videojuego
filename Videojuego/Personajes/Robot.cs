using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Robot : Personaje
    {
        public override void Pelear()
        {
            if (base.PerderEnergia(2)) {
                Console.WriteLine("Peleo como robot");
            }
            else
            {
                Console.WriteLine("...");
            }
        }

        public override void Correr()
        {
            if (base.PerderEnergia(2))
            {
                Console.WriteLine("Corriendo como robot");
            }
            else
            {
                Console.WriteLine("...");
            }
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola soy un robot");
        }
    }
}
