using System;
using System.Collections.Generic;

namespace Course16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria"); // o Add, por padrão adiciona no final da lista 
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco"); // o Insert adiciona um elemento, mas indicando a posição

            Console.WriteLine("--------------------------------------------------");

            foreach (string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("List Count: " + list.Count); //Count conta o tamanho da lista 

            Console.WriteLine("--------------------------------------------------");

            string s1 = list.Find(x => x[0] == 'A'); // Find encontra a primeira ocorrência que comece com uma determinada letra 
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // FindLast encontra a última ocorrência que comece com uma determinada letra
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("--------------------------------------------------");

            int pos1 = list.FindIndex(x => x[0] == 'A'); // FindIndex encontra na lista a primeira posição que comece com uma determinada letra
            Console.WriteLine("First position 'A': "+ pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //FindLastIndex encotra na lista a ultima posição que comece com uma detraminada letra
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("--------------------------------------------------");

            List<string>  list2 = list.FindAll(x => x.Length == 5);
             
            foreach(string nome in list2)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------------------------------------------");

            list.RemoveRange(2, 2); // Remove, remove um nome da lista ultilizando um nome que queira remover  

            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------------------------------------------");

            list.RemoveAll(x => x[0] == 'M'); //RemoveAll, remove todos os nomes que comece com uma determinada letra

            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------------------------------------------");

            list.RemoveAt(0); //RemoveAt, remove indicando a posição do elemento

            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------------------------------------------------");
            //RemoveRange, remove elementos apartir de uma indicação de uma posição e a quantidade a ser removido
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
