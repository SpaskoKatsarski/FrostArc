namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ModeratorCommunity
    {
        [ForeignKey(nameof(Moderator))]
        public string ModeratorId { get; set; } = null!;

        public ApplicationUser Moderator { get; set; } = null!;

        [ForeignKey(nameof(Community))]
        public string CommunityId { get; set; } = null!;

        public Community Community { get; set; } = null!;
    }
}
