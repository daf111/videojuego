using System;

namespace Videojuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Alimento alimento = new Alimento(5);

            Alienigena alienigena = new Alienigena();
            alienigena.MostrarEnergia();
            alienigena.Comer(alimento);
            alienigena.MostrarEnergia();

            Arma palo = new Palo();
            alienigena.AsignarArma(palo);
            alienigena.Pelear();

            Arma ametralladora = new Ametralladora();
            alienigena.AsignarArma(ametralladora);
            alienigena.Pelear();

            Arma puno = new Puno();
            alienigena.AsignarArma(puno);
            alienigena.Pelear();
        }
    }
}
