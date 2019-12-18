namespace appWebApi.Domain
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public string CodRFID { get; set; }
        public string Token { get; set; }
    }
}
