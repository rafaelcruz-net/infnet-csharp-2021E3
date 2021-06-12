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
                var sql = @"INSERT INTO CLIENTE(Nome, Email, Endereco) Values(@p1, @p2, @p3);";

                conn.Execute(sql, new
                {
                    p1 = cliente.Nome,
                    p2 = cliente.Email,
                    p3 = cliente.Endereco
                });
            }

        }

        public void Delete(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"DELETE FROM CLIENTE WHERE IdCliente = @p1";

                conn.Execute(sql, new
                {
                    p1 = cliente.IdCliente,
                });
            }
        }

        public List<Cliente> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"SELECT * FROM CLIENTE";

                var resultado = conn.Query<Cliente>(sql);

                return resultado.AsList();
            }
        }

        public Cliente GetCliente(int id)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                var sql = @"SELECT * FROM CLIENTE WHERE IdCliente = @p1";

                conn.Open();
                
                var command = conn.CreateCommand();

                command.CommandText = sql;
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new SqlParameter("@p1", id));

                var result = command.ExecuteReader();

                Cliente cliente = new Cliente();

                while (result.Read())
                {
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
                var sql = @"UPDATE CLIENTE 
                            SET Nome = @p1,
                                Email = @p2,
                                Endereco = @p3
                            WHERE IdCliente = @p4
                            ";

                conn.Execute(sql, new
                {
                    p1 = cliente.Nome,
                    p2 = cliente.Email,
                    p3 = cliente.Endereco,
                    p4 = id
                });
            }
        }
    }
}
