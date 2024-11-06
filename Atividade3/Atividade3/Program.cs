using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
03 - Peça para o usuário fazer depósitos até que o saldo total atinja um limite de R$ 10.000,00. 
Caso o saldo exceda o limite, mostre uma mensagem de alerta.
*/

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 0, limite = 10000;

            do
            {
                Console.WriteLine("Digite um valor para depositar:");
                saldo += decimal.Parse(Console.ReadLine());
                if (saldo > limite)
                    Console.WriteLine($"Limite {limite} excedido! \nSaldo: R$ {saldo}!");
            } while (saldo <= limite);

            Console.ReadKey();
        }
    }
}
