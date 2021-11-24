using System;
using System.Globalization;

namespace CourseExercicioPropostoIf05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Cachorro Quente ---------R$ 4,00" +
                              "\n2 - X-Salada ----------------R$ 4,50" +
                              "\n3 - X-Bacon -----------------R$ 5,00" +
                              "\n4 - Torrada Simples ---------R$ 2,00" +
                              "\n5 - Refrigerante ------------R$ 1,50"
            );
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Escolha uma das Opções acima: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Quantidade do Pedido: ");
            int qtd = int.Parse(Console.ReadLine());

            double valor = 0.0;
            if (n == 1)
            {
                valor = qtd * 4.00;
                Console.WriteLine("Total a Pagar: R$ {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n == 2)
            {
                valor = qtd * 4.50;
                Console.WriteLine("Total a Pagar: R$ {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n == 3)
            {
                valor = qtd * 5.00;
                Console.WriteLine("Total a Pagar: R$ {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n == 4)
            {
                valor = qtd * 2.00;
                Console.WriteLine("Total a Pagar: R$ {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (n == 5)
            {
                valor = qtd * 1.50;
                Console.WriteLine("Total a Pagar: R$ {0}", valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Opção invalida!");
            }



        }
    }
}
