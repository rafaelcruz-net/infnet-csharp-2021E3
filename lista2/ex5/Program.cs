using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Caixa Eletronico");
            Console.WriteLine("Digite o valor do troco");
            int valor = Convert.ToInt32(Console.ReadLine());

            int[] notas = new int[] { 50, 25, 10, 5, 1};

            int index = 0;
            int qtNota = 0;
            string result = "";

            while(valor != 0) 
            {
                qtNota = valor / notas[index];

                if (qtNota != 0) 
                {
                    result += $"{qtNota} de R$ {notas[index]} \n";
                    valor = valor % notas[index];
                }

                index++;
            }

            Console.WriteLine(result);
        }
    }
}
