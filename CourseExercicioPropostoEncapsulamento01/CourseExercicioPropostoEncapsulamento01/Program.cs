using System;
using System.Globalization;

namespace CourseExercicioPropostoEncapsulamento01
{
    class Program
    {
        static void Main(string[] args)
        {
            char resposta = ' ';
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Dados da Conta:\n" + conta);

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            Console.Write("Entre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            Console.WriteLine("Dados da conta atualizados:\n" + conta);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            Console.Write("Entre com o Valor para Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine("Dados da conta atualizados:\n" + conta);





        }
    }
}
