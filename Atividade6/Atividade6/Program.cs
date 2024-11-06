using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
06 - Escreva um programa que permita saques ilimitados até que o saldo seja inferior a um valor mínimo de R$ 100,00. 
Mostre a quantidade de saques realizados.O saldo inicial deve ser de R$5000.00.
*/
namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saque, saldo = 5000;
            int cont = 0;

            do  //Usar um if para testar saldo
            {
                Console.WriteLine("Quanto deseja sacar? ");
                saque = decimal.Parse(Console.ReadLine());
                if(saldo > saque && saldo > 100)
                {
                    saldo -= saque;
                    cont++;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente! ");
                }

            } while (saldo > 100);

            Console.WriteLine($"\nSaldo: {saldo} \nQuantidade de saques: {cont}");

            Console.ReadKey();
        }
    }
}
