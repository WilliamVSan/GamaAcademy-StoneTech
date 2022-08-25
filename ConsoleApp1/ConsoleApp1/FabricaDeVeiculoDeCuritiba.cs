using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FabricaDeVeiculoDeCuritiba
    {
        public Veiculo CriaVeiculo(string tipo)
        {
            if(tipo == "carro")
            {
                return new Carro() { modelo = "Civic"};
            }
            if(tipo == "moto")
            {
                return new Moto();
            }
            return new Veiculo();
        }
    }
}
