using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FabricaDeVeiculoDeSaoPaulo: IFabrica
    {
        public Carro CriarCarros()
        {
            return new Carro()
            {
                modelo = "320i"
            };
        }
        public Veiculo CriarVeiculo(string tipoDeVeiculo)
        {
            return new Carro()
            {
                modelo = "320i8"
            };
        }
    }    
}

