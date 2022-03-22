using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public class BaseIdEO
    {
        [Key]
        public int Id { get; set; }
    }
}
