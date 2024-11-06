using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
10 - Peça para o usuário sacar um valor de uma conta. 
Se o saque for maior que R$ 1000,00, solicite a tentativa novamente. 
Limite o número de tentativas a 3. Saldo inicial da conta deve ser de R$5000.00
*/

namespace Atividade10
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldoInicial = 5000, limiteSaque = 1000, saque;
            int tentativas = 3;

            for(int i = 0; i < tentativas; i++)
            {
                Console.WriteLine("Digite um valor para sacar: ");
                saque = decimal.Parse(Console.ReadLine());

                if(saque > limiteSaque)
                {
                    Console.WriteLine($"\nTentativa {i+1}: Saque maior que {limiteSaque}! Tente novamente...");
                    if (tentativas == i+1)
                    {
                        Console.WriteLine("\nConta Bloqueada!");
                        break;
                    }
                }
                else
                {
                    saldoInicial -= saque;
                    break;
                }
            }

            Console.WriteLine($"\nSaldo: R$ {saldoInicial}");
            Console.ReadKey();
        }
    }
}
