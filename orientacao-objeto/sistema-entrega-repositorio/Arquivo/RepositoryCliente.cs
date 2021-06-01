using Newtonsoft.Json;
using sistema_entrega.Entity;
using sistema_entrega_entity.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace sistema_entrega_repositorio.Arquivo
{
    public class RepositoryCliente : IRepositoryCliente
    {
        private string file_entrega = "file_entrega.txt";
        private string path_arquivo = @"C:\sistema_gerencial\file";
        private List<Cliente> Clientes { get; set; }

        public RepositoryCliente()
        {
            if (Directory.Exists(path_arquivo) == false)
                Directory.CreateDirectory(path_arquivo);

            var pathArquivo = Path.Combine(path_arquivo, file_entrega);

            if (File.Exists(pathArquivo) == false)
                File.Create(pathArquivo);

        }

        public void GravaArquivo()
        {
            var pathArquivo = Path.Combine(path_arquivo, file_entrega);
            using (FileStream file = File.Open(pathArquivo, FileMode.Open, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    var json = JsonConvert.SerializeObject(this.Clientes);

                    writer.Write(json);
                    writer.Flush();
                    writer.Close();
                }

                file.Close();
            }
        }

        public void LerArquivo()
        {
            var pathArquivo = Path.Combine(path_arquivo, file_entrega);
            using (FileStream file = File.Open(pathArquivo, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    var list_json = reader.ReadToEnd();
                    this.Clientes = JsonConvert.DeserializeObject<List<Cliente>>(list_json);

                    if (Clientes == null)
                        Clientes = new List<Cliente>(); 

                    reader.Close();
                }
                file.Close();
            }
        }

        public void Create(Cliente cliente)
        {
            var maxId = 0;

            if (this.Clientes.Count > 0)
                maxId = this.Clientes.Max(x => x.Id) + 1;

            cliente.Id = maxId;

            this.Clientes.Add(cliente);

        }

        public void Delete(Cliente cliente)
        {
            var client_delete = this.Clientes.Find(x => x.Id == cliente.Id);
            Clientes.Remove(client_delete);
        }

        public List<Cliente> GetAll()
        {
            return this.Clientes;
        }

        public Cliente GetCliente(int id)
        {
            return this.Clientes.Find(x => x.Id == id);
        }

        public void Update(Cliente cliente, int id)
        {
            throw new NotImplementedException();
        }
    }
}
