using sistema_entrega_entity.Repository;
using System;
using System.Collections.Generic;

namespace sistema_entrega.Entity
{
    public class Cliente
    {
        public Cliente()
        {
          

        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

    }
}