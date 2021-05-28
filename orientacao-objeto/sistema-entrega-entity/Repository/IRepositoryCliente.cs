using sistema_entrega.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_entrega_entity.Repository
{
    public interface IRepositoryCliente
    {
        void Create(Cliente cliente);
        void Update(Cliente cliente, int id);
        void Delete(Cliente cliente);
        Cliente GetCliente(int id);
        List<Cliente> GetAll();
    }
}
