namespace FrostArc.Web.ViewModels.Post
{
    using FrostArc.Web.ViewModels.Comment;

    public class PostAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string? ImageUrl { get; set; } = null!;

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public IEnumerable<CommentPostViewModel> Comments { get; set; } = null!;

        public string Community { get; set; } = null!;
    }
}
