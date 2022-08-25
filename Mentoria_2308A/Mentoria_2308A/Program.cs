using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentoria_2308A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Programa que retorna o valor de um salário por: dia, mes, ano
             Valor: 2500
             5 dias da semana, 8 horas por dia.
            */

            //Criando variáveis.
            double salario, salarioHora, salarioDiario, salarioAnual;
            string nomeFuncionario;

            //Imprimindo introdução para o usuário.
            Console.WriteLine("Bem vindo ao calculador de salário.");

            Console.Write("Digite o nome do usuário: ");
            nomeFuncionario = Console.ReadLine();
            Console.Write("Digite o salário a ser calculado: ");
            salario = Convert.ToDouble(Console.ReadLine());

            //Calculando salários
            salarioHora = salario / 220;
            salarioDiario = salario / 4.3;
            salarioAnual = salario * 12;

            //Imprimindo escolhas para o usuário.
            Console.WriteLine("Salario a hora - a\nSalário diario - b\nSalário Mensal - c\nSalário Anual - d");

            Console.WriteLine("Digite a sua escolha: ");
            switch (Console.ReadLine().ToLower())
            {
                case "a":
                    Console.WriteLine($"O salário a hora do funcionario: {nomeFuncionario} é de: {salarioHora1} R$");
                    break;
                case "b":
                    Console.WriteLine($"O salário diario do funcionario: {nomeFuncionario} é de: {salarioDiario}R$");
                    break;
                case "c":
                    Console.WriteLine($"O salário mensal do funcionario: {nomeFuncionario} é de: {salario}R$");
                    break;
                case "d":
                    Console.WriteLine($"O salário anual do funcionario: {nomeFuncionario} é de: {salarioAnual}R$");
                    break;

            }
        }
    }
}
