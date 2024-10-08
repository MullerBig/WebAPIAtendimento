namespace WebAPI_Mercado.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string AbreviacaoNome { get; set; }

        public string Descricao { get; set; }

        public int TipoUsuarioId { get; set; }
    }
}
