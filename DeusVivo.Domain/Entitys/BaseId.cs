using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class BaseId
    {
        [Key]
        public int Id { get; set; }
    }
}
