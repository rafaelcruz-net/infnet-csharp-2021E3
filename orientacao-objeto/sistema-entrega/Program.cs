using System;
using sistema_entrega.Entity;

namespace sistema_entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            
            Console.WriteLine($"Nome do cliente: {cliente.NomeCompleto}");
            Console.Read();
        }
    }
}
