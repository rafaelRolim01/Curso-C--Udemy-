using System;
using System.Globalization;

namespace Course09
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);

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
