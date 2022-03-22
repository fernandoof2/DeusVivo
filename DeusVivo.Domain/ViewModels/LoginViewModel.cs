using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
