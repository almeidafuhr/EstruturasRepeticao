using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
04 - Permita que o usuário faça depósitos e saques, mostrando o saldo e o extrato ao final, 
com no máximo 5 operações possíveis por execução.
*/

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 0, saque = 0, deposito = 0;
            char continuar;
            int op;
            List<string> extrato = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("1 - Sacar \n2 - Depositar \nDigite: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Quanto deseja sacar? ");
                        saque = decimal.Parse(Console.ReadLine());
                        if (saldo >= saque)
                        {
                            saldo -= saque;
                            extrato.Add("Saque - ");
                            extrato.Add(saque.ToString());
                        }
                        else
                            Console.WriteLine("Saldo Insuficiente! ");
                        break;
                    case 2:
                        Console.WriteLine("Quanto deseja depositar? ");
                        deposito = decimal.Parse(Console.ReadLine());
                        saldo += deposito;
                        extrato.Add("Depósito - ");
                        extrato.Add(deposito.ToString());
                        break;
                    default:
                        break;
                }

                Console.WriteLine("s - sim\nn - não\nDeseja continuar? ");
                continuar = char.Parse(Console.ReadLine());
                if (continuar == 'n')
                    break;
            }

            Console.WriteLine($"Saldo: R$ {saldo}\n");

            extrato.ForEach(Console.WriteLine);

            Console.ReadKey();

        }
    }
}
