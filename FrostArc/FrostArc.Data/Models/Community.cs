namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.DataValidationConstants.Community;

    public class Community
    {
        public Community()
        {
            this.Id = Guid.NewGuid();
            this.Posts = new HashSet<Post>();
            this.Users = new HashSet<ApplicationUser>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }

        [Required]
        public ApplicationUser Owner { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
