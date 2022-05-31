using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(String[] args)

        {
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("\nEntr o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("\nHaverá depósito inicial (s/n)?  ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("\nEntre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(qtde);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(qtde);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}