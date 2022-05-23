using System.ComponentModel.DataAnnotations;

namespace CarComponents.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }
    }
}
