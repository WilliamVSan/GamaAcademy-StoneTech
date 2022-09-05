using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemandaCadastro
{
    public class ListarProduto : Produto
    {
        public void Listando(List<Produto> lista)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Listando Produtos |  ||  ||  ||  ||  |\n" +
                          "-----------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Status == true)
                {
                    Console.WriteLine($"[{i}] Status: Ativo | Nome: {lista[i].NomeProduto} | Quantidade: {lista[i].Quantidade} |" +
                    $" Preço Compra: {lista[i].PrecoCompra} | Preço Venda: {lista[i].PrecoVenda} |");
                }
                
            };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPressione 'M' para mais informações.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ou pressione qualquer tecla para voltar.");
            var input = Console.ReadKey();
            if(input.Key == ConsoleKey.M){Adicional(lista);};
        }
        public void Adicional(List<Produto> lista)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Informações Adicionais |  ||  ||  ||  ||  |\n" +
                          "-----------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Status == true)
                {
                    Console.WriteLine($"[{i}] Status: Ativo | Nome: {lista[i].NomeProduto} | Armazenagem: {lista[i].Armazenagem} | Perca Lucro: {Math.Round(lista[i].PercaLucro), 2}% |");
                }

            };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();
        }
        public void ListandoCategoria(List<Categoria> lista)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Listando Categorias |  ||  ||  ||  ||  |\n" +
                          "-------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < lista.Count; i++)
            {
                    Console.WriteLine($"[{i}] | Nome: {lista[i].NomeCategoria} |" +
                    $" Descrição: {lista[i].Descricao} | Tipo: {lista[i].Tipo} |");

            };
        }
    }
}
