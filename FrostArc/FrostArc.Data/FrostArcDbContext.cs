namespace FrostArc.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    using FrostArc.Data.Models;
    using Microsoft.AspNetCore.Identity;

    public class FrostArcDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FrostArcDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Developer> Developers { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Community> Communities { get; set; }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof())

            base.OnModelCreating(builder);
        }
    }
}
