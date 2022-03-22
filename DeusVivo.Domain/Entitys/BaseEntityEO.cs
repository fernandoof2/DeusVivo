namespace DeusVivo.Domain.Entitys
{
    public class BaseEntityEO : BaseIdEO
    {
        public int? CompanhiaId { get; set; }
        public CompanhiaEO? Companhia { get; set; }
        public DateTime? CriacaoDataHora { get; set; }
        public int? CriacaoId { get; set; }
        public UsuarioEO? CriacaoUsuario { get; set; }
        public DateTime? AlteracaoDataHora { get; set; }
        public int? AlteracaoId { get; set; }
        public UsuarioEO? AlteracaoUsuario { get; set; }
    }
}
