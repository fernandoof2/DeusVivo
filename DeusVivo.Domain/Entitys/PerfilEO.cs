using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class PerfilEO : BaseEntityEO
    {   
        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public string Nome { get; set; }
    }
}
