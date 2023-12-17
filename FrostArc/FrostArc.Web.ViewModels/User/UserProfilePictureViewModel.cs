namespace FrostArc.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;

    public class UserProfilePictureViewModel
    {
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        [StringLength(2048, MinimumLength = 4)]
        public string ImageUrl { get; set; } = null!;
    }
}
