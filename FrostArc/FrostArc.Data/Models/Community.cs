namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Community
    {
        public Community()
        {
            this.Id = Guid.NewGuid();
            this.Posts = new HashSet<Post>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public ICollection<Post> Posts { get; set; }

        //TODO: Many-to-Many with Users (Members)
        //      property for Moderator
    }
}
