using System.ComponentModel.DataAnnotations;

namespace FrostArc.Web.ViewModels.Post
{
    public class PostFormViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public string CommunityId { get; set; } = null!;
    }
}
