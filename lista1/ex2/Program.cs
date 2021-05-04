using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            
            Console.WriteLine("Informe seu Nome");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 18)
                Console.WriteLine($"{nome} é maior que 18 anos");
            else
                Console.WriteLine($"{nome} não é maior que 18 anos");
        }
    }
}
