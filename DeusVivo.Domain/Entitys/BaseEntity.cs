namespace DeusVivo.Domain.Entitys
{
    public class BaseEntity : BaseId
    {
        public int? CompanhiaId { get; set; }
        public Companhia? Companhia { get; set; }
        public DateTime? CriacaoDataHora { get; set; }
        public int? CriacaoId { get; set; }
        public Usuario? CriacaoUsuario { get; set; }
        public DateTime? AlteracaoDataHora { get; set; }
        public int? AlteracaoId { get; set; }
        public Usuario? AlteracaoUsuario { get; set; }
    }
}
