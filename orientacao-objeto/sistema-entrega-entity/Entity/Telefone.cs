namespace sistema_entrega.Entity
{
    public class Telefone
    {
        public string Numero { get; set; }
        public string DDD { get; set; }
        public string DDI { get; set; }

        public string Ramal { get; set; }

        public TipoTelefone TipoTelefone { get; set; }
    }
}