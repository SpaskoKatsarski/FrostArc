namespace FrostArc.Web.ViewModels.Community
{
    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Web.ViewModels.User;

    public class CommunityFeedViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int MembersCount { get; set; }

        public string OwnerId { get; set; } = null!;

        public IEnumerable<PostAllViewModel> Posts { get; set; } = null!;

        public IEnumerable<UserAllViewModel> Users { get; set; } = null!;
    }
}
