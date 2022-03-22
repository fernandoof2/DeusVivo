using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class CompanhiaEO : BaseIdEO
    {
        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public string Nome { get; set; }
    }
}
