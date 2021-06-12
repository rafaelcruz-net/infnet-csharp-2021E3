using sistema_entrega.Entity;
using System;
using sistema_entrega_entity.Utils;
using sistema_entrega_entity.Repository;
using sistema_entrega_repositorio;
using Newtonsoft.Json;

namespace sistema_entrega
{
    class Program
    {
        private static sistema_entrega_repositorio.Database.RepositorioCliente repositoryCliente = new sistema_entrega_repositorio.Database.RepositorioCliente();

        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("============== Gerencia de Entrega ===========");
            Console.WriteLine("==============================================");

            var sair = false;

            while (!sair)
            {
                ExibeOpções();
                var opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        CadastroCliente();
                        break;
                    case "2":
                        AtualizarCliente();
                        break;
                    case "3":
                        ExcluirCliente();
                        break;
                    case "4":
                        ObterCliente();
                        break;
                    case "5":
                        ListarTodosClientes();
                        break;
                    case "q":
                        Console.WriteLine("Até Logo :)");
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
                
            }

        }

        private static void ListarTodosClientes()
        {
            Console.WriteLine("Exibindo Clientes");
            Console.WriteLine("");
            var clientes = repositoryCliente.GetAll();
            Console.WriteLine(JsonConvert.SerializeObject(clientes, Formatting.Indented));
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private static void ObterCliente()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o identificado do cliente");
            
            var id = Convert.ToInt32(Console.ReadLine());
            var cliente = repositoryCliente.GetCliente(id);

            Console.WriteLine("");
            Console.WriteLine($"Exibindo Cliente com o identificador {id}");
            Console.WriteLine("");
            Console.WriteLine(JsonConvert.SerializeObject(cliente, Formatting.Indented));
            Console.WriteLine("");
            Console.WriteLine("");

        }

        private static void ExcluirCliente()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o identificador do cliente para realizar a exclusão");

            var id = Convert.ToInt32(Console.ReadLine());

            var cliente = repositoryCliente.GetCliente(id);

            if (cliente == null)
                Console.WriteLine("Cliente não encontrado");
            else
            {
                repositoryCliente.Delete(cliente);
                Console.WriteLine("Cliente excluido com sucesso");
            }

        }

        private static void AtualizarCliente()
        {
            Console.WriteLine("");
            Console.WriteLine("Digite o identificado do cliente");

            var id = Convert.ToInt32(Console.ReadLine());
            var cliente = repositoryCliente.GetCliente(id);

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
            }
            else
            {
                Console.WriteLine("Informe o nome do cliente");
                cliente.Nome = Console.ReadLine();

                Console.WriteLine("Informe o Email do cliente");
                cliente.Email = Console.ReadLine();

                Console.WriteLine("Informe o Endereco do cliente");
                cliente.Endereco = Console.ReadLine();

                repositoryCliente.Update(cliente, id);

                Console.WriteLine("Cliente atualizado com sucesso!");
            }
        }

        private static void CadastroCliente()
        {
            var cliente = new Cliente();

            Console.WriteLine("Informe o nome do cliente");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Email do cliente");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("Informe o Endereco do cliente");
            cliente.Endereco = Console.ReadLine();

            repositoryCliente.Create(cliente);

            Console.WriteLine("Cadastro Realizado com sucesso!");
        }

        private static void ExibeOpções()
        {
            Console.WriteLine("Selecione as opções");
            Console.WriteLine("1 - Para criar um Cliente");
            Console.WriteLine("2 - Para atualizar um Cliente");
            Console.WriteLine("3 - Para excluir um Cliente");
            Console.WriteLine("4 - Para obter um Cliente");
            Console.WriteLine("5 - Para exibir todos os Clientes");
            Console.WriteLine("q - Para sair");
        }
    }
}
