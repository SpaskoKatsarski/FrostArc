using System.ComponentModel.DataAnnotations;

namespace FrostArc.Web.ViewModels.Community
{
    public class CommunityFormViewModel
    {
        public string? Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(1000, MinimumLength = 10)]
        public string Description { get; set; } = null!;

        [Required]
        [Url]
        [MaxLength(2048)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;
    }
}
