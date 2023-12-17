namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ApplicationUserEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(u => u.ProfilePicture)
                .HasDefaultValue("https://cdn-icons-png.flaticon.com/512/1053/1053244.png");
        }
    }
}
