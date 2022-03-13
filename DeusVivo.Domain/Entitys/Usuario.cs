using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class Usuario : BaseId
    {
        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        public string Senha { get; set; }
    }
}
