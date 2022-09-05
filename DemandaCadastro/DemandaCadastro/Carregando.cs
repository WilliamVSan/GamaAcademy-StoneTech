using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemandaCadastro
{
    public class Carregando
    {
        private readonly string[] barraDeCarregamento = 
        { "           █▒▒▒▒▒▒▒▒▒ 10%", "           ██▒▒▒▒▒▒▒▒ 20%", "           ███▒▒▒▒▒▒▒ 30%",
          "           ████▒▒▒▒▒▒ 40%", "           █████▒▒▒▒▒ 50%",
          "           ██████▒▒▒▒ 60%", "           ███████▒▒▒ 70%", "           ████████▒▒ 80%",
          "           █████████▒ 90%", "           ██████████ 100%"
        };
    
    public void Carregamento(string texto)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Console.WriteLine(texto);
            Console.Write(barraDeCarregamento[i]);
            Thread.Sleep(150);
        };
    }
    }
}
