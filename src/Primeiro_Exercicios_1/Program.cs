using System;

namespace Primeiro_Exercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoas dados1 = new Pessoas();
            Pessoas dados2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome : ");
            dados1.nome = Console.ReadLine();
            Console.Write("Idade : ");
            dados1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome : ");
            dados2.nome = Console.ReadLine();
            Console.Write("Idade : ");
            dados2.idade = int.Parse(Console.ReadLine());

            if (dados1.idade > dados2.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {dados1.nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {dados2.nome}");
            }            

            Console.ReadKey();

        }
    }
}
