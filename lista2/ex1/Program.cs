using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME O NUMERO A SER MULTIPLICADO");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");


        }
    }
}
