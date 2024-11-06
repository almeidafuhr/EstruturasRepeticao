using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
08 - Escreva um programa que simule 12 meses de depósitos fixos de R$ 500,00 em uma conta. 
Mostre o saldo total ao final de cada mês.
 */
namespace Atividade8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal depositoFixo = 500, conta, simulacao = 0;

            Console.WriteLine("Valor inicial da conta: ");
            conta = decimal.Parse(Console.ReadLine());

            for(int i = 0; i < 12; i++)
            {
                simulacao += depositoFixo;
                Console.WriteLine($"Saldo Total Mês {i+1}: {conta + simulacao}");
            }
            Console.ReadKey();
        }
    }
}
