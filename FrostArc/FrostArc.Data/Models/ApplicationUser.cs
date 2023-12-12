namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Comments = new HashSet<Comment>();
            this.Communities = new HashSet<Community>();
            this.Posts = new HashSet<Post>();
        }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Community> Communities { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
