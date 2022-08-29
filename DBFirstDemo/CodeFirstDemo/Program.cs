using CodeFirstDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando e Inicializando banco de dados a partir do código C#...");
            using(var db = new EscolaContext())
            {
                new EscolaInitializer().InitializeDatabase(db);
            }
            Console.WriteLine("Concluido!");
            Console.ReadKey();
        }
    }
}
