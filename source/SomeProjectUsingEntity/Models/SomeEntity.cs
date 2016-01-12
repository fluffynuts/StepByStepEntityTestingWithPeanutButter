using System.ComponentModel.DataAnnotations;

namespace SomeProjectUsingEntity.Models
{
    public class SomeEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}
