namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .HasOne(g => g.Developer)
                .WithMany(d => d.Games)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(g => g.Genre)
                .WithMany(g => g.Games)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
