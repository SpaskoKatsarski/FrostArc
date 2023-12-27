namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.Community)
                .WithMany(c => c.Posts)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(p => p.Likes)
                .HasDefaultValue(0);

            builder
                .Property(p => p.Dislikes)
                .HasDefaultValue(0);
        }
    }
}
