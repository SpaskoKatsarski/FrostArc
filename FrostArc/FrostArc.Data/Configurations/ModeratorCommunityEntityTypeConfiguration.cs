namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data.Models;

    public class ModeratorCommunityEntityTypeConfiguration : IEntityTypeConfiguration<ModeratorCommunity>
    {
        public void Configure(EntityTypeBuilder<ModeratorCommunity> builder)
        {
            builder
                .HasKey(mc => new { mc.ModeratorId, mc.CommunityId });
        }
    }
}
