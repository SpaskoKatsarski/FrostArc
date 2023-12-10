namespace FrostArc.Web.ViewModels.Developer
{
    using FrostArc.Web.ViewModels.Game;

    public class DeveloperDetailsViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public IEnumerable<GameListViewModel> Games { get; set; } = null!;
    }
}
