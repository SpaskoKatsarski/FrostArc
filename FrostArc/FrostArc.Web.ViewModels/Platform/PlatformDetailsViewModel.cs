namespace FrostArc.Web.ViewModels.Platform
{
    using FrostArc.Web.ViewModels.Game;

    public class PlatformDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public IEnumerable<GameListViewModel> Games { get; set; } = null!;
    }
}
