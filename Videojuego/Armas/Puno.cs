using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Puno : Arma
    {
        public Puno()
        {
            this.dano = 1;
        }

        public override void Atacar()
        {
            Console.WriteLine("Soy un puño. Le quito " + this.dano + " de energia al enemigo");
        }
    }
}
