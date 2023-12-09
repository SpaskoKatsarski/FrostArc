namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Community
    {
        public Community()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        //TODO: Many-to-Many with Users (Members)
        //      property for Moderator
    }
}
