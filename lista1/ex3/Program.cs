using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao pattern de triangulo");
            Console.WriteLine("Informe quantas linhas deseja imprimir");

            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
