namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } = null!;

        //TODO Add Foreign key to User

        public string? ImageUrl { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public int Likes { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public int Dislikes { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(Community))]
        public Guid CommunityId { get; set; }

        [Required]
        public Community Community { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; } = null!;
    }
}
