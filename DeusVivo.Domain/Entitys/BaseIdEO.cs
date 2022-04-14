using System.ComponentModel.DataAnnotations;

namespace DeusVivo.Domain.Entitys
{
    public abstract class BaseIdEO
    {
        [Key]
        public int Id { get; set; }
    }
}
