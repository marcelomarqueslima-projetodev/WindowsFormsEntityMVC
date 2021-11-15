using System;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsEntityMVC.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
