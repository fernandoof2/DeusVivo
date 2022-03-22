using System.ComponentModel.DataAnnotations.Schema;

namespace DeusVivo.Domain.Entitys
{
    public class BaseEntityEO : BaseIdEO
    {
        public int? CompanhiaId { get; set; }
        
        public CompanhiaEO? Companhia { get; set; }
        
        public DateTime? CriacaoDataHora { get; set; }
        
        [ForeignKey("UsuarioEO")]        
        public int? CriacaoUsuarioId { get; set; }
        
        public UsuarioEO? CriacaoUsuario { get; set; }
        
        public DateTime? AlteracaoDataHora { get; set; }
        
        [ForeignKey("UsuarioEO")]
        public int? AlteracaoUsuarioId { get; set; }
        
        public UsuarioEO? AlteracaoUsuario { get; set; }
    }
}
