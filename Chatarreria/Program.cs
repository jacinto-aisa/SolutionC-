using Chatarreria.Builder;
using Chatarreria.Carroceria;
using Chatarreria.Motor;
using Chatarreria.Ruedas;

namespace Chatarreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICocheBuilder constructor = new BuilderCochev2();
            Coche miCocheDeportivoMolon = constructor.dameCoche(TiposVehiculo.Deportivo);
            Coche miBerlina = constructor.dameCoche(TiposVehiculo.Berlina);
            
            Console.WriteLine(miCocheDeportivoMolon.dameInformacion());
            Console.WriteLine("Precio: " + miCocheDeportivoMolon.dameImporte());

            Console.WriteLine(miBerlina.dameInformacion());
            Console.WriteLine("Precio: " + miBerlina.dameImporte());


        }
    }
}