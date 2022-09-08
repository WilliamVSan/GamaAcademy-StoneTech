﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProjeto
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
            using (var db = new EstoqueEntities())
            {
                var query = from c in db.Produtoes
                            select c;

                foreach (var produto in query)
                {
                    Console.WriteLine($"[{produto.ProdutoId}] Status: Ativo | Nome: {produto.NomeProduto} | Quantidade: {produto.Quantidade} |" +
                                            $" Preço Compra: {produto.PrecoCompra} | Preço Venda: {produto.PrecoVenda} |");
                };
            } 
        }
        public void Adicional(List<Produto> lista)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Informações Adicionais |  ||  ||  ||  ||  |\n" +
                          "-----------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            using (var db = new EstoqueEntities())
            {
                var query = from c in db.Produtoes
                            select c;

                foreach (var produto in query)
                {
                    Console.WriteLine($"[{produto.ProdutoId}] Status: Ativo | Nome: {produto.NomeProduto} | Armazenagem: {produto.Armazenagem} | Perca Lucro: {Math.Round(produto.PercaLucro),2}% |");
                }

            };
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();
        }
        public void ListandoCategoria()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Listando Categorias |  ||  ||  ||  ||  |\n" +
                          "-------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            using (var db = new EstoqueEntities())
            {
                var query = from c in db.Categorias
                            select c;

                foreach (var categoria in query)
                {
                    Console.WriteLine($"[{categoria.CategoriaId}] | Nome: {categoria.NomeCategoria} |" +
                $" Descrição: {categoria.Descricao} | Tipo: {categoria.Tipo} |");
                }
            };

        }
        public void ListandoVendas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Listando Vendas |  ||  ||  ||  ||  |\n" +
                          "-------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            using (var db = new EstoqueEntities())
            {
                var query = from c in db.Vendas
                            select c;
                foreach (var compra in query)
                {
                    Console.WriteLine($"[{compra.VendaId}] | Nome: {compra.NomeVenda} |" +
                $" Preço: {compra.PrecoVenda} | Produto ID: {compra.VendaId} |");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();

        }
        public void ListandoCompras()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Listando Compras |  ||  ||  ||  ||  |\n" +
                          "-------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            using (var db = new EstoqueEntities())
            {
                var query = from c in db.Compras
                            select c;

                foreach (var compra in query)
                {
                    Console.WriteLine($"[{compra.CompraId}] | Nome: {compra.NomeCompra} |" +
                $" Preço: {compra.PrecoCompra} | Produto ID: {compra.CompraId} |");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPressione qualquer tecla para voltar");
            Console.ReadKey();
        }
        public void ListandoEdicao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("|  ||  ||  ||  ||  | Listando Produtos |  ||  ||  ||  ||  |\n" +
                          "-----------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
            using (var db = new EstoqueEntities())
            {
                var query = from c in db.Produtoes
                            select c;

                foreach (var produto in query)
                {
                    Console.WriteLine($"[{produto.ProdutoId}] Status: Ativo | Nome: {produto.NomeProduto} | Quantidade: {produto.Quantidade} |" +
                                            $" Preço Compra: {produto.PrecoCompra} | Preço Venda: {produto.PrecoVenda} |");
                };
            }
        }
        public void MaisInformacoes(List<Produto> lista)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPressione 'M' para mais informações.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ou pressione qualquer tecla para voltar.");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.M) { Adicional(lista); };
            
            
        }
    }
}
