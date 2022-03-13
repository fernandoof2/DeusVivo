using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class Cargo : BaseEntity
    {   
        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public string Nome { get; set; }
    }
}
