namespace FrostArc.Web.ViewModels.Comment
{
    using System.ComponentModel.DataAnnotations;

    public class CommentDeleteViewModel
    {
        public string Id { get; set; } = null!;

        [Display(Name = "Comment")]
        public string Content { get; set; } = null!;

        [Display(Name = "Post Title")]
        public string PostTitle { get; set; } = null!;

        public string PostOwner { get; set; } = null!;
    }
}
