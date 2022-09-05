using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemandaCadastro
{
    public class AdicionarProduto
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private string nomeProduto;
        private string quantidadeProduto;
        private string armazenagemProduto;
        private string compraProduto;
        private string vendaProduto;
        ListarProduto listarProduto = new ListarProduto();
        ListarProduto listarCategoria = new ListarProduto();
        //private string categoriaProduto;

        public Produto CriarProduto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|  ||  ||  | Preenchimento ficha do PRODUTO |  ||  ||  |\n");
            //while(listarCategoria == null)
            //{
            //    Console.WriteLine("|  ||  ||  | Não existem categorias, por favor crie uma nova categoria  |  ||  ||  |\n");
            //}
            //int escolhaUsuario = Convert.ToInt16(Console.ReadLine());
            
            do
            {
                Console.Write("Nome do produto: ");
                nomeProduto = Console.ReadLine();
            } while (nomeProduto == string.Empty);

            do
            {
                Console.Write("Quantidade em estoque: ");
                quantidadeProduto = Console.ReadLine();
            } while (quantidadeProduto == string.Empty);

            do
            {
                Console.Write("Armazenagem do produto: ");
                armazenagemProduto = Console.ReadLine();
            } while (armazenagemProduto == string.Empty);
            do
            {
                Console.Write("Preço de compra: ");
                compraProduto = Console.ReadLine();
            } while (compraProduto == string.Empty);
            do
            {
                Console.Write("Preço de venda: ");
                vendaProduto = Console.ReadLine();
            } while (vendaProduto == string.Empty);


            Calculos calculos = new Calculos();
            return new Produto()
            {
                //categoria = categoriaProduto,
                NomeProduto = nomeProduto,
                Quantidade = Convert.ToInt16(quantidadeProduto),
                Armazenagem = armazenagemProduto,
                PrecoCompra = float.Parse(compraProduto),
                PrecoVenda = float.Parse(vendaProduto),
                PercaLucro = calculos.CalcularPerca(float.Parse(compraProduto), float.Parse(vendaProduto)),
                Status = true
            };

        }
        public void EditarProduto(List<Produto> lista)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Editando Produto |  ||  ||  ||  ||  |\n" +
                          "----------------------------------------------------------\n");
            listarProduto.Listando(lista);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o indice do produto: ");
            int escolhaUsuario = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Editando Produto |  ||  ||  ||  ||  |\n" +
                          "----------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[{escolhaUsuario}] Status: Ativo | Nome: {lista[escolhaUsuario].NomeProduto} | Quantidade: {lista[escolhaUsuario].Quantidade} |" +
                    $" Preço Compra: {lista[escolhaUsuario].PrecoCompra} | Preço Venda: {lista[escolhaUsuario].PrecoVenda} | Armazenagem: {lista[escolhaUsuario].Armazenagem} | Perca Lucro: {lista[escolhaUsuario].PercaLucro}% |\n");

        }
        public void CriarCategoria(List<Categoria> lista)
        {

        }
    }

}
