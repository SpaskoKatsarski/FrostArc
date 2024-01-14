namespace FrostArc.Web.ViewModels.Community
{
    using FrostArc.Web.ViewModels.User;

    public class CommunityUsersViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public IEnumerable<UserAllViewModel> Users { get; set; } = null!;
    }
}
