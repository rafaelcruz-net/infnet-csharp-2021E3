using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao diamante .net");
            Console.WriteLine("Digite quantidade de linha do diamante");

            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int s = 1; s <= rows - i; s++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = rows - 1; i >= 1; i--)
            {
                for (int s = 1; s <= rows - i; s++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
