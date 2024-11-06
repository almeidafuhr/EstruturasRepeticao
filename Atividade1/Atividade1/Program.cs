using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
01 - Escreva um programa que solicite ao usuário depositar valores em uma conta bancária. 
Para finalizar o programa, solicite que ele deposite 0 como valor.
No final de cada operação mostre o saldo total.
*/

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 0;
            decimal deposito;

            do
            {
                Console.WriteLine("Digite um valor para depositar ou 0 para parar: ");
                deposito = decimal.Parse(Console.ReadLine());
                saldo += deposito;
                if (deposito == 0)
                    Console.WriteLine($"Saldo final: {saldo}");
                else
                    Console.WriteLine($"Saldo atual: {saldo}");
            } while (deposito != 0);
            Console.ReadKey();
        }
    }
}
