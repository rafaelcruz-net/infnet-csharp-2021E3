using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piramide .NET");
            Console.WriteLine("Digite o ultimo numero da piramide");
            int rows = Convert.ToInt32(Console.ReadLine());

            int space = rows + 4;
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {

                for (int s = space; s >= 1; s--)
                    Console.Write(" ");

                for (int c = 1; c <= i; c++)
                {
                    Console.Write($"{number.ToString().PadLeft(2, '0')} ");
                    number = number + 1;
                }


                Console.WriteLine();
                space = space - 1;

                if (number > rows)
                    break;
            }
        }
    }
}
