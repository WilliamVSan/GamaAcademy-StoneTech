using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fabrica = new FabricaDeVeiculoDeSaoPaulo();

            var veiculo = GetVeiculo(fabrica);

            Console.WriteLine(veiculo.modelo);
        }
        public static Veiculo GetVeiculo(IFabrica fabrica)
        {
            return fabrica.CriarVeiculo("carro");
        }

    }
}
