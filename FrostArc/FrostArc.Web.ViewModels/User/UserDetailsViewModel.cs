namespace FrostArc.Web.ViewModels.User
{
    using FrostArc.Web.ViewModels.Community;
    using FrostArc.Web.ViewModels.Post;

    public class UserDetailsViewModel
    {
        public string? Id { get; set; }

        public string DisplayName { get; set; } = null!;

        public string ProfilePicture { get; set; } = null!;

        public IEnumerable<PostAllViewModel> Posts { get; set; } = null!;

        public IEnumerable<CommunityAllViewModel> Communitites { get; set; } = null!;
    }
}
