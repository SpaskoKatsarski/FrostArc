namespace FrostArc.Web.ViewModels.Post
{
    using System.ComponentModel.DataAnnotations;
    using static Common.DataValidationConstants.Post;

    public class PostFormViewModel
    {
        public string? Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        [Url]
        [Display(Name = "Image URL")]
        public string? ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public string CommunityId { get; set; } = null!;
    }
}
