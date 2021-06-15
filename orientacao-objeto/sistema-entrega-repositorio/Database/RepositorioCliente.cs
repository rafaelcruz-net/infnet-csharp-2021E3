using Dapper;
using sistema_entrega.Entity;
using sistema_entrega_entity.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace sistema_entrega_repositorio.Database
{
    public class RepositorioCliente : IRepositoryCliente
    {
        private string Connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sistema_gerencia_entrega;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Create(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"dbo.InsertCustomer";

                conn.Execute(sql, new
                {
                    Nome = cliente.Nome,
                    Email = cliente.Email,
                    Endereco = cliente.Endereco
                }, commandType: System.Data.CommandType.StoredProcedure);
            }

        }

        public void Delete(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"dbo.DeleteCustomer";

                conn.Execute(sql, new
                {
                    IdCliente = cliente.IdCliente,
                }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public List<Cliente> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"[dbo].[SelectAllCustomers]";

                var resultado = conn.Query<Cliente>(sql, commandType: System.Data.CommandType.StoredProcedure);

                return resultado.AsList();
            }
        }

        public Cliente GetCliente(int id)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"[dbo].[SelectCustomerById]";

                conn.Open();
                
                var command = conn.CreateCommand();

                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@IdCliente", id));

                var result = command.ExecuteReader();

                Cliente cliente = null;

                while (result.Read())
                {
                    cliente = new Cliente(); 
                    cliente.Email = result[2].ToString();
                    cliente.Nome = result[1].ToString();
                    cliente.IdCliente = Convert.ToInt32(result[0]);
                    cliente.Endereco = result[3].ToString();
                }

                conn.Close();

                return cliente;
            }
        }

        public void Update(Cliente cliente, int id)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"dbo.UpdateCustomer";

                conn.Execute(sql, new
                {
                    Nome = cliente.Nome,
                    Email = cliente.Email,
                    Endereco = cliente.Endereco,
                    IdCliente = id
                }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
