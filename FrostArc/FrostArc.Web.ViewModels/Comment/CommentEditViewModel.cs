namespace FrostArc.Web.ViewModels.Comment
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using static Common.DataValidationConstants.Comment;

    public class CommentEditViewModel
    {
        public string Id { get; set; } = null!;

        public string? User { get; set; }

        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        [Display(Name = "Comment")]
        public string Content { get; set; } = null!;

        [Display(Name = "Title of Post")]
        public string? PostTitle { get; set; }

        public string? PostOwner { get; set; }

        [Description("Indicates if the user has rights to edit or delete the comment.")]
        public bool HasAccess { get; set; }
    }
}
