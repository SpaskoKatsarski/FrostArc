namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.DataValidationConstants.Post;

    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid();
            this.Comments = new HashSet<Comment>();
            this.PostReactions = new HashSet<PostReaction>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } = null!;

        [MaxLength(ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Required]
        [Range(LikesMinValue, LikesMaxValue)]
        public int Likes { get; set; }

        [Required]
        [Range(DislikesMinValue, DislikesMaxValue)]
        public int Dislikes { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        [ForeignKey(nameof(Community))]
        public Guid CommunityId { get; set; }

        [Required]
        public Community Community { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; }

        public ICollection<PostReaction> PostReactions { get; set; } = null!;
    }
}
