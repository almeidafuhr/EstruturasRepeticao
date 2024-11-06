using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
02 - Escreva um programa que permita ao usuário informar quantas operações bancárias deseja fazer e, 
em seguida, permita que ele faça depósitos ou saques até completar esse número de operações informadas no inicio.
No final, mostre o saldo total.
*/

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacoes, op;
            decimal saldo = 0;

            Console.WriteLine("Digite quantas operações deseja fazer: ");
            operacoes = int.Parse(Console.ReadLine());

            for(int i = 0; i < operacoes; i++)
            {
                Console.WriteLine($"\nOperação {i}: \n1 - Saque \n2 - Depósito \nSua escolha: ");
                op = int.Parse(Console.ReadLine());  //Switch case
                if (op == 1)  //Saque
                {
                    Console.WriteLine("Quanto deseja sacar? ");
                    decimal saque = decimal.Parse(Console.ReadLine());
                    if (saldo >= saque)
                        saldo -= saque;
                    else
                        Console.WriteLine("Saldo Insuficiente! ");
                }
                else if (op == 2)  //Depósito
                {
                    Console.WriteLine("Quanto deseja depositar? ");
                    decimal deposito = decimal.Parse(Console.ReadLine());
                    saldo += deposito;
                }
                else
                    Console.WriteLine("Dígito Inválido! ");  //Inválido
            }

            Console.WriteLine($"Saldo Final: R$ {saldo}");
            Console.ReadKey();
        }
    }
}
