using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LojaEntities())
            {
                
                //Criando clientes e pedidos
                Cliente cliente1 = new Cliente()
                {
                    Nome = "Mickey",
                    Email = "mickey@mouse.com"
                };
                db.Clientes.Add(cliente1);
                db.SaveChanges();

                Cliente cliente2 = new Cliente()
                {
                    Nome = "Peteta",
                    Email = "pateta@friend.com"
                };
                db.Clientes.Add(cliente2);
                db.SaveChanges();

                Cliente cliente3  = new Cliente()
                {
                    Nome = "Pluto",
                    Email = "pluto@dog.com"
                };
                db.Clientes.Add(cliente3);
                db.SaveChanges();

                cliente1.Pedidoes.Add(new Pedido
                {
                    Item = "Queijo",
                    Preco = 8
                });

                cliente2.Pedidoes.Add(new Pedido
                {
                    Item = "Sapatos",
                    Preco = 89
                });

                cliente3.Pedidoes.Add(new Pedido
                {
                    Item = "Raçao",
                    Preco = 16
                });

                db.SaveChanges();

                //LINQ
                var query = from c in db.Clientes.Include("Pedidoes")
                            select c;

                foreach(var cliente in query)
                {
                    Console.WriteLine($"Cliente: {cliente.Nome}");
                    Console.WriteLine("Pedidos:");
                    Console.WriteLine("========");
                    foreach(var p in cliente.Pedidoes)
                    {
                        Console.WriteLine($"Item: {p.Item}, Preço: {p.Preco}");
                    }
                }
                Console.WriteLine("Pressione qualquer tecla.");
                Console.ReadKey();
            }

        }
    }
}
