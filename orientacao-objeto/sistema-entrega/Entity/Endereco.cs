namespace sistema_entrega.Entity
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        //1 - COMERCIAL
        //2 - RESIDENCIAL
        //3 - OUTROS
        public TipoEnderecoEnum TipoEndereco { get; set; }
    }
}