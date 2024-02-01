namespace FrostArc.Web.ViewModels.Comment
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataValidationConstants.Comment;

    public class CommentEditViewModel
    {
        public string Id { get; set; } = null!;

        public string User { get; set; } = null!;

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; } = null!;

        [Display(Name = "Title of Post")]
        public string PostTitle { get; set; } = null!;

        public string PostOwner { get; set; } = null!;
    }
}
