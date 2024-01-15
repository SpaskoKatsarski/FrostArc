namespace FrostArc.Data.Configurations
{
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.AspNetCore.Identity;

    using FrostArc.Data.Models;
    using static FrostArc.Common.GeneralApplicationConstants;

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
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            return new HashSet<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                    DisplayName = DefaultUser.DisplayName,
                    ProfilePicture = User.DefaultProfilePicture,
                    UserName = DefaultUser.Email,
                    NormalizedUserName = DefaultUser.Email.ToUpper(),
                    Email = DefaultUser.Email,
                    NormalizedEmail = DefaultUser.Email.ToUpper(),
                    EmailConfirmed = false,
                    PasswordHash = hasher.HashPassword(null, DefaultUser.Password),
                    SecurityStamp = "1BC726483DA146C7AB96961EBD8FA88B",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                }
            };
        }
    }
}
