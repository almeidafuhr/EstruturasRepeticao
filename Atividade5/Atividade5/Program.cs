using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*05 - Escreva um programa que calcule o saldo de uma conta com juros compostos, 
onde o usuário pode informar o saldo inicial e a taxa de juros mensal. 
O cálculo deve ser feito por 12 meses.*/

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldo, taxa, saldoFinal = 0;

            Console.WriteLine("Digitar o saldo inicial: ");
            saldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digitar a taxa inicial: ");
            taxa = decimal.Parse(Console.ReadLine());
            saldoFinal = saldo;

            for(int i = 0; i < 12; i++)
            {
                saldoFinal -= (saldoFinal * taxa);   
            }
            Console.WriteLine($"Saldo Final: R$ {saldoFinal}");
        }
    }
}
