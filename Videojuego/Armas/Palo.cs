using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Palo : Arma
    {
        public Palo()
        {
            this.dano = 2;
        }

        public override void Atacar()
        {
            Console.WriteLine("Soy un palo. Le quito " + this.dano + " de energia al enemigo");
        }
    }
}
