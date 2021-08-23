using System.ComponentModel.DataAnnotations;

namespace Server.Model
{
    public abstract class NamedEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }    
    }
}