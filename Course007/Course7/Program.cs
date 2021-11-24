using System;
using System.Globalization;

namespace Course7
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine("Entre od dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine();
            Console.Write("Digite a quantidade de produto a ser adicionado ao Estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do Estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
