namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ModeratorCommunity
    {
        [ForeignKey(nameof(Moderator))]
        public Guid ModeratorId { get; set; }

        public ApplicationUser Moderator { get; set; } = null!;

        [ForeignKey(nameof(Community))]
        public Guid CommunityId { get; set; }

        public Community Community { get; set; } = null!;
    }
}
