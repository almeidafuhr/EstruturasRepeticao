using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
09 - Permita que o usuário insira o saldo da conta em cada mês por 6 meses. Ao final, mostre a média do saldo mensal.
*/

namespace Atividade9
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldo, acumulador = 0;
            int meses = 6;

            for(int i = 0; i < meses; i++)
            {
                Console.WriteLine($"Digite o saldo para o {i+1}º Mês: ");
                saldo = decimal.Parse(Console.ReadLine());
                acumulador = acumulador += saldo;
            }

            Console.WriteLine($"\nA média do saldo mensal é {acumulador/meses}");
            Console.ReadKey();
        }
    }
}
