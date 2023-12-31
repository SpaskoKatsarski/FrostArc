﻿namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

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
        [MaxLength(50)]
        public string DisplayName { get; set; } = null!;

        [Required]
        [MaxLength(2048)]
        public string ProfilePicture { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Community> Communities { get; set; }

        [InverseProperty(nameof(Community.Owner))]
        public ICollection<Community> OwnedCommunities { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<PostReaction> PostReactions { get; set; } = null!;
    }
}
