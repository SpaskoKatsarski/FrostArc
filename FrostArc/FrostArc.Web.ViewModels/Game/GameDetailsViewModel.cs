namespace FrostArc.Web.ViewModels.Game
{
    public class GameDetailsViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string DeveloperId { get; set; } = null!;

        public string Developer { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public IEnumerable<string> Platforms { get; set; } = null!;
    }
}
