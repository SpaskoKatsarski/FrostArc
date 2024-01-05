namespace FrostArc.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    using FrostArc.Data.Models;
    using FrostArc.Data.Configurations;

    public class FrostArcDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FrostArcDbContext(DbContextOptions<FrostArcDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Developer> Developers { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Community> Communities { get; set; }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<GamePlatform> GamesPlatforms { get; set; }

        public DbSet<PostReaction> PostsReactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(GameEntityTypeConfiguration).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
