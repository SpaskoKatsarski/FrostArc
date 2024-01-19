namespace FrostArc.Web.ViewModels.Post
{
    public class PostDeleteViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public string CommunityId { get; set; } = null!;

        public string UserId { get; set; } = null!;

    }
}
