using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemandaCadastro
{
    public class Program
    {
        /*
         Demanda: Sistema para cadastro de Produtos.
         Data: 29/08
        */
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
                              "C - Checar produto\n" +
                              "E - Editar produto\n\n");
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
                        break;

                    case ConsoleKey.A:
                        Console.Clear();
                        listaProdutos.Add(adicionar.CriarProduto());
                        barraDeCarregamento.Carregamento("| || || | Criando produto | || || |\n");
                        break;

                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("C");
                        break;

                    case ConsoleKey.E:
                        Console.Clear();
                        adicionar.EditarProduto(listaProdutos);
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
