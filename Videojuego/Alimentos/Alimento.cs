using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Alimento
    {
        private int energia;

        public Alimento(int energia)
        {
            this.energia = energia;
        }

        public int valorEnergetico()
        {
            return this.energia;
        }
    }
}
