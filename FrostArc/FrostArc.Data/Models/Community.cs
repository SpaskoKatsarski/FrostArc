namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

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
        [MaxLength(25)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(2048)]
        public string ImageUrl { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
