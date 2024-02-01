namespace FrostArc.Web.ViewModels.Community
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataValidationConstants.Community;

    public class CommunityFormViewModel
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Url]
        [StringLength(ImageUrlMaxLength, MinimumLength = ImageUrlMinLength)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;
    }
}
