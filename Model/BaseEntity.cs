using System.ComponentModel.DataAnnotations;

namespace Server.Model
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}