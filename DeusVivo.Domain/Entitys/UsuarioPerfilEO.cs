using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class UsuarioPerfilEO : BaseAuditEO
    {   
        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public int UsuarioId { get; set; }

        public UsuarioEO usuario { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public int PerfilId { get; set; }

        public PerfilEO Perfil { get; set; }
    }
}
