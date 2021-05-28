using sistema_entrega.Entity;
using sistema_entrega_entity.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_entrega_repositorio.Memoria
{
    public class RepositoryCliente : IRepositoryCliente
    {
        private static List<Cliente> Clientes { get; set; } = new List<Cliente>(); 

        public void Create(Cliente cliente)
        {
            cliente.Id = RepositoryCliente.Clientes.Count + 1;
            RepositoryCliente.Clientes.Add(cliente);
        }

        public void Delete(Cliente cliente)
        {
            RepositoryCliente.Clientes.Remove(cliente);
        }

        public List<Cliente> GetAll()
        {
            return RepositoryCliente.Clientes;
        }

        public Cliente GetCliente(int id)
        {
            return RepositoryCliente.Clientes.Find(x => x.Id == id);
        }

        public void Update(Cliente cliente, int id)
        {
            var clienteOld = this.GetCliente(id);

            this.Delete(clienteOld);
            this.Create(cliente);
            
        }
    }
}
