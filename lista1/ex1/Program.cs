using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 0)
                Console.WriteLine($"Número é positivo: valor {x}");
            else 
                Console.WriteLine($"Número é negativo: valor {x}");

            Console.Read();
        }
    }
}
