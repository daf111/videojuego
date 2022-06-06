using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Ametralladora : Arma
    {
        public Ametralladora()
        {
            this.dano = 2;
        }

        public override void Atacar()
        {
            Console.WriteLine("Soy una ametralladora. Le quito " + (this.dano * 2) + " de energia al enemigo");
        }
    }
}
