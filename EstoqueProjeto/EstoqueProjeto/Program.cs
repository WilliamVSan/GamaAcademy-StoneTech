using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EstoqueProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variavel do loop.
            bool continuar = true;

            //Adicionar novos produtos.
            AdicionarProduto adicionar = new AdicionarProduto();
            //Listar produtos.
            ListarProduto listarProduto = new ListarProduto();
            //Barra de carregamento.
            Carregando barraDeCarregamento = new Carregando();
            //Criando lista de produtos.
            List<Produto> listaProdutos = new List<Produto>();
            //Loop para continuar no sistema.
            while (continuar)
            {

                Console.Clear();
                //Função para mudar a cor das letras.
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|  ||  ||  | Bem vindo ao gerenciamento de PRODUTOS |  ||  ||  |\n");

                Console.WriteLine("Pressione a tecla correspondente para acessar uma das opções:");
                Console.ResetColor();
                Console.Write("L - Listar produtos\n" +
                              "A - Adicionar novo produto\n" +
                              "C - Listar compras\n" +
                              "V - Listar vendas\n" +
                              "S - Listar categorias\n" +
                              "E - Editar produto\n" +
                              "R - Remover produto\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pressione 'Q' para sair.\n");
                Console.ResetColor();
                Console.ResetColor();

                //Variavel pressione a tecla.
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.L:
                        Console.Clear();
                        listarProduto.Listando(listaProdutos);
                        listarProduto.MaisInformacoes(listaProdutos);
                        break;

                    case ConsoleKey.V:
                        Console.Clear();
                        listarProduto.ListandoVendas();
                        break;

                    case ConsoleKey.C:
                        Console.Clear();
                        listarProduto.ListandoCompras();
                        break;

                    case ConsoleKey.A:
                        Console.Clear();
                        adicionar.CriarProduto();
                        break;

                    case ConsoleKey.S:
                        Console.Clear();
                        listarProduto.ListandoCategoria();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPressione qualquer tecla para voltar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.Clear();
                        adicionar.EditarProduto();
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        using (var db = new EstoqueEntities())
                        {
                            adicionar.RemoverProduto();
                        }
                        break;
                    case ConsoleKey.Q:
                        continuar = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Opção inválida");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }
    }
}
