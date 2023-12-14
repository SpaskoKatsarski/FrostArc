namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.User)
                .WithMany(p => p.Comments)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
