using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Alienigena : Personaje
    {
        public Alienigena() : base()
        {
        }
        public Alienigena(int seteoEnergiaInicial)
        {
            this.energia = seteoEnergiaInicial;
        }
        public override void Pelear() 
        {
            if (base.PerderEnergia(3)) {
                Console.WriteLine("Peleo como alienigena");
                this.arma.Atacar();
            }
            else
            {
                Console.WriteLine("...");
            }
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola soy un Alien");
        }
    }
}
