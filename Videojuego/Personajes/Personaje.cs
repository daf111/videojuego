using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    abstract class Personaje
    {
        protected int energia;
        protected Arma arma;

        public Personaje()
        {
            this.energia = 10;
            this.arma = new Puno();
        }

        public void Caminar()
        {
            if (this.PerderEnergia(1)) 
            { 
                Console.WriteLine("Estoy caminando");
            }
            else
            {
                Console.WriteLine("...");
            }
        }
        public virtual void Correr()
        {
            if (this.PerderEnergia(4)) 
            { 
                Console.WriteLine("Estoy corriendo");
            }
            else
            {
                Console.WriteLine("...");
            }
        }
        
        public virtual void Correr(int factor_plus)
        {
            if (this.PerderEnergia(4 * factor_plus)) 
            { 
                Console.WriteLine("Estoy corriendo");
            }
            else
            {
                Console.WriteLine("...");
            }
        }

        protected bool PerderEnergia(int energia)
        {
            if (this.energia >= energia)
            {
                this.energia -= energia;
                return true;
            }
            else
            {
                return false;
            }
        }
        abstract public void Pelear();
        abstract public void Saludar();

        public void MostrarEnergia()
        {
            Console.WriteLine(this.energia);
        }

        public void Comer(Alimento alimento)
        {
            this.energia += alimento.valorEnergetico();
        }

        public void AsignarArma(Arma arma)
        {
            this.arma = arma;
        }
    }
}
