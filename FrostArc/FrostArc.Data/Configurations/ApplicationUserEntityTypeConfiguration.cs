namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static System.Net.WebRequestMethods;

    public class ApplicationUserEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .Property(u => u.ProfilePicture)
                .HasDefaultValue("https://cdn-icons-png.flaticon.com/512/1053/1053244.png");

            builder
                .HasData(this.SeedUsers());
        }

        private IEnumerable<ApplicationUser> SeedUsers()
        {
            return new HashSet<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                    DisplayName = "SyncK",
                    ProfilePicture = "https://cdn-icons-png.flaticon.com/512/1053/1053244.png"
                }
            };
        }
    }
}
