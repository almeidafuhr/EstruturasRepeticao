using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
07 - Crie um programa que permita transferir valores entre duas contas (conta1 e conta2). 
Permita até 5 transferências e mostre os saldos finais de ambas as contas. 
A conta1 deve ter saldo inicial de R$5000.00 e a conta2 deve ter um saldo inicial de R$3000.00.
*/

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal conta1 = 5000, conta2 = 3000, transferencia;
            int operacao;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite 1 para tranferir da conta1 para conta 2... \nDigite 2 para tranferir da conta 2 para conta 1...\nOutro numero para encerrar...");
                Console.Write("Escolha: ");
                operacao = int.Parse(Console.ReadLine());
                if (operacao != 1 && operacao != 2)
                {
                    Console.WriteLine("\nEncerrando...");
                    break;
                }
                else { 
                    Console.WriteLine("Digite o valor que deseja tranferir: ");
                    transferencia = decimal.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case 1:
                            if (conta1 >= transferencia)
                            {
                                conta1 -= transferencia;
                                conta2 += transferencia;
                            }
                            else
                                Console.WriteLine($"Saldo insuficiente. Seu saldo: {conta1} Transferencia: {transferencia} ");
                            break;
                        case 2:
                            if (conta2 >= transferencia)
                            {
                                conta1 += transferencia;
                                conta2 -= transferencia;
                            }
                            else
                                Console.WriteLine($"Saldo insuficiente. Seu saldo: {conta2} Transferencia: {transferencia} ");
                            break;

                        default:
                            break;
                    }
                }  
            }

            Console.WriteLine($"\nConta 1: R$ {conta1}\nConta 2: R$ {conta2}");
            Console.ReadKey();
        }
    }
}
