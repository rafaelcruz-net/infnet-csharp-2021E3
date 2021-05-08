using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao fibonacci .net");
            Console.WriteLine("Digite quantidade da serie fibonacci");
            int serie = Convert.ToInt32(Console.ReadLine());
            int previous = 0, next = 1, temp;

            Console.Write($"{previous} {next}");

            for (int i = 2; i < serie; i++)
            {
                temp = previous + next;
                Console.Write($" {temp} ");
                previous = next;
                next = temp;
            }

        }
    }
}
