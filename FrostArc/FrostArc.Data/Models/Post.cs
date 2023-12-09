namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid();
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(1000, MinimumLength = 2)]
        public string Content { get; set; } = null!;

        //TODO Add Foreign key to User

        public string? ImageUrl { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public int Likes { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public int Dislikes { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
