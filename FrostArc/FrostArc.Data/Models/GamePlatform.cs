namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GamePlatform
    {
        [ForeignKey(nameof(Game))]
        public Guid GameId { get; set; }

        public Game Game { get; set; } = null!;

        [ForeignKey(nameof(Platform))]
        public int PlatformId { get; set; }

        public Platform Platform { get; set; } = null!;
    }
}
