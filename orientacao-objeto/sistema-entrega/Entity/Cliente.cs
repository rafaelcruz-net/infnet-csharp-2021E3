using System;
using System.Collections.Generic;

namespace sistema_entrega.Entity
{
    public class Cliente
    {
        public Cliente()
        {
            this.NomeCompleto = "Nome 1";
            this.Documento = "1234567";
            this.Email = "teste@teste.com";
            this.DataNascimento = new DateTime(2000, 12, 01);
            this.Enderecos = new List<Endereco>()
            {
                new Endereco()
                {
                    Bairro = "Teste",
                    CEP = "00000-000",
                    Cidade = "Dummy",
                    Complemento = "Apto 303",
                    Estado = "Rio de Janeiro",
                    Logradouro = "Rua do teste",
                    TipoEndereco = TipoEnderecoEnum.Residencial
                },
                new Endereco()
                {
                    Bairro = "Teste Comercial",
                    CEP = "00000-001",
                    Cidade = "Dummy",
                    Complemento = "SL 989",
                    Estado = "Rio de Janeiro",
                    Logradouro = "Rua do teste do comercial",
                    TipoEndereco = TipoEnderecoEnum.Comercial
                }
            };

        }

        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Endereco ObterEndereco(TipoEnderecoEnum tipoEndereco)
        {
            foreach (var endereco in this.Enderecos)
            {
                if (endereco.TipoEndereco == tipoEndereco)
                    return endereco;
            }

            return null;
        }

    }
}