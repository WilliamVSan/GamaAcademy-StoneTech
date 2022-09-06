using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EstoqueProjeto
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
        Carregando carregamento = new Carregando();
        private ListarProduto listarProduto = new ListarProduto();
        List<Produto> listaProdutos = new List<Produto>();
        private static string nomeProduto;
        private static string vendaProduto;
        private static string compraProduto;
        private static string armazenagemProduto;
        private static string quantidadeProduto;
        private string escolhaTabela;


        //private string categoriaProduto;

        public void CriarProduto()
        {
            using (var db = new EstoqueEntities())
            {


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|  ||  ||  | Preenchimento ficha do PRODUTO |  ||  ||  |\n");

                listarProduto.ListandoCategoria();

                Console.Write("\nDigite o ID da categoria: ");
                int escolhaUsuario = Convert.ToInt16(Console.ReadLine());

                do
                {
                    bool has;//Criando bool para checagem
                    do
                    {
                        Console.Write("Nome do produto: ");
                        nomeProduto = Console.ReadLine();
                        has = db.Produtoes.Any(cus => cus.NomeProduto == nomeProduto);//Checagem se o nome já existe
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (has)
                        {
                            Console.WriteLine("Este produto já existe.");
                        }
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    } while (has);
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

                /*do
                {
                    Console.Write("Digite o 'compra' ou 'venda' para escolher a tabela: ");
                    escolhaTabela = Console.ReadLine().ToLower();
                } while (escolhaTabela != "compra" && escolhaTabela != "vende");*/


                Calculos calculos = new Calculos();
                Produto produto = new Produto()
                {
                    NomeProduto = nomeProduto,
                    Quantidade = Convert.ToInt16(quantidadeProduto),
                    Armazenagem = armazenagemProduto,
                    PrecoCompra = float.Parse(compraProduto),
                    PrecoVenda = float.Parse(vendaProduto),
                    PercaLucro = calculos.CalcularPerca(float.Parse(compraProduto), float.Parse(vendaProduto)),
                    Status = true,
                    CategoriaId = escolhaUsuario
                };

                db.Produtoes.Add(produto);
                carregamento.Carregamento("|  ||  ||  | Criando Produto |  ||  ||  |\n");
                db.SaveChanges();
            }
        }
        public void EditarProduto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Editando Produto |  ||  ||  ||  ||  |\n" +
                          "----------------------------------------------------------\n");
            listarProduto.ListandoEdicao();

            using (var db = new EstoqueEntities())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nDigite o Id do produto: ");
                int escolhaEditar = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                Console.Write("|  ||  ||  ||  ||  | Editando Produto |  ||  ||  ||  ||  |\n" +
                          "----------------------------------------------------------\n");
                var query = from c in db.Produtoes where c.ProdutoId == escolhaEditar select c;
                foreach (var c in query)
                {
                    Console.ResetColor();
                    Console.WriteLine($"[{c.ProdutoId}] Status: Ativo | Nome: {c.NomeProduto} | Quantidade: {c.Quantidade} |" +
                                           $" Preço Compra: {c.PrecoCompra} | Preço Venda: {c.PrecoVenda} |");
                }
                Console.Write("\nNome do produto: ");
                string novoNome = Console.ReadLine();
                Console.Write("Quantidade em estoque: ");
                int novaQuantidade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Armazenagem do produto: ");
                string novaArmazenagem = Console.ReadLine();
                Console.Write("Preço de compra: ");
                double novaCompra = Convert.ToDouble(Console.ReadLine());
                Console.Write("Preço de venda: ");
                double novaVenda = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o ID da categoria: ");
                int novaCategoria = Convert.ToInt32(Console.ReadLine());
                
                foreach (var c in query)
                {
                    c.NomeProduto = novoNome;
                    c.Quantidade = novaQuantidade;
                    c.Armazenagem = novaArmazenagem;
                    c.PrecoCompra = novaCompra;
                    c.PrecoVenda = novaVenda;
                    c.CategoriaId = novaCategoria;
                }
                db.SaveChanges();
                Console.ReadKey();
            };
        }
    }

}

//    Console.ForegroundColor = ConsoleColor.White;
//    Console.Write("Digite o ID do produto: ");
//    int escolhaUsuario = Convert.ToInt16(Console.ReadLine());
//    Console.Clear();
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write("|  ||  ||  ||  ||  | Editando Produto |  ||  ||  ||  ||  |\n" +
//                  "----------------------------------------------------------\n");
//    Console.ForegroundColor = ConsoleColor.White;
//    using (var db = new EstoqueEntities())
//    {
//        var query = db.Produtoes.Find(ProdutoId)
//        Console.WriteLine($"[{escolhaUsuario}] Status: Ativo | Nome: {lista[escolhaUsuario].NomeProduto} | Quantidade: {lista[escolhaUsuario].Quantidade} |" +
//                $" Preço Compra: {lista[escolhaUsuario].PrecoCompra} | Preço Venda: {lista[escolhaUsuario].PrecoVenda} | Armazenagem: {lista[escolhaUsuario].Armazenagem} | Perca Lucro: {lista[escolhaUsuario].PercaLucro}% |\n");
//    }


//public void CriarCategoria(List<Categoria> lista)
//{

//}


