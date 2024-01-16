namespace FrostArc.Web.ViewModels.Community
{
    public class CommunityDetailsViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int MembersCount { get; set; }

        public string OwnerId { get; set; } = null!;

        public string OwnerName { get; set; } = null!;
    }
}
