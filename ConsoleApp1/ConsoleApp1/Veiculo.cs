using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Veiculo
    {
        public int numeroDeRodas;
        public string modelo;
        public int numeroDePortas;
        public int velocidadeDoCarro = 0;
        public bool carroLigado = false;

        public void Acelerar(int velocidadeAcelerada)
        {
            if (carroLigado == false)
            {
                Console.WriteLine("Você precisa ligar o carro primeiro.");
            }
            else
            {
                Console.WriteLine("Acelerando...");
                velocidadeDoCarro += velocidadeAcelerada;
                Console.WriteLine("Velocidade atual: " + velocidadeDoCarro + "Km/h");
            }

        }
        public void Freiar()
        {
            if (velocidadeDoCarro <= 0)
            {
                Console.WriteLine("O carro já está parado...");
            }
            else
            {
                Console.WriteLine("Freiando...");
                velocidadeDoCarro -= 30;
                Console.WriteLine("Velocidade atual: " + velocidadeDoCarro + "Km/h");
            }

        }

        public void Ligar()
        {
            if (carroLigado == false)
            {
                Console.WriteLine("Ligando carro...");
                carroLigado = true;
            }
            else
            {
                Console.WriteLine("O carro já está ligado...");
            }

        }

        public void Desligar()
        {
            if (carroLigado == true)
            {
                Console.WriteLine("Desligando carro...");
                carroLigado = false;
                velocidadeDoCarro = 0;
            }

            else
            {
                Console.WriteLine("O carro já está desligado.");
            }
        }

    }
}
