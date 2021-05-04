using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME O NUMERO A SER CALCULADO DE FATORIAL");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            //N! = 6X5X4X3X2X1 OU 1X2X3X4X5X6

            for (int i = 1; i <= n; i++)
                result *= i; // result = result * i;

            Console.WriteLine($"Fatorial de {n} é {result}");
        }

        
    }
}
