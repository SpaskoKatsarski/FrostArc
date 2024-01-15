namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using static Common.DataValidationConstants.ApplicationUser;

    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Comments = new HashSet<Comment>();
            this.Communities = new HashSet<Community>();
            this.Posts = new HashSet<Post>();
            this.PostReactions = new HashSet<PostReaction>();
        }

        [Required]
        [MaxLength(DisplayNameMaxLength)]
        public string DisplayName { get; set; } = null!;

        [Required]
        [MaxLength(ProfilePictureMaxLength)]
        public string ProfilePicture { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = null!;

        public ICollection<Community> Communities { get; set; } = null!;

        [InverseProperty(nameof(Community.Owner))]
        public ICollection<Community> OwnedCommunities { get; set; } = null!;

        public ICollection<Post> Posts { get; set; } = null!;

        public ICollection<PostReaction> PostReactions { get; set; } = null!;
    }
}
