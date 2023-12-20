namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class GenreTypeEntityConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(this.SeedGenres());
        }

        private IEnumerable<Genre> SeedGenres()
        {
            ICollection<Genre> genres = new List<Genre>()
            {
                new Genre { Id = 1, Name = "Action", Description = "Games emphasizing physical challenges, including hand–eye coordination and reaction time." },
                new Genre { Id = 2, Name = "Adventure", Description = "Games focusing on exploration, puzzle-solving, and narrative." },
                new Genre { Id = 3, Name = "RPG (Role-Playing Game)", Description = "Games where players assume the roles of characters in a fictional setting." },
                new Genre { Id = 4, Name = "Simulation", Description = "Games designed to simulate real-world activities." },
                new Genre { Id = 5, Name = "Strategy", Description = "Games where the focus is on strategic decision making." },
                new Genre { Id = 6, Name = "Sports", Description = "Games that simulate the playing of sports." },
                new Genre { Id = 7, Name = "Racing", Description = "Games that involve racing against opponents." },
                new Genre { Id = 8, Name = "Fighting", Description = "Games centered around close-ranged combat between a limited number of characters." },
                new Genre { Id = 9, Name = "Shooter", Description = "Games focusing on combat with various firearms." },
                new Genre { Id = 10, Name = "MMO (Massively Multiplayer Online)", Description = "Online games capable of supporting large numbers of players simultaneously."  },
                new Genre { Id = 11, Name = "MOBA (Multiplayer Online Battle Arena)", Description = "Games featuring two opposing teams competing against each other." },
                new Genre { Id = 12, Name = "Horror", Description = "Games designed to scare the player with an ominous atmosphere and chilling storylines." },
                new Genre { Id = 13, Name = "Puzzle", Description = "Games that challenge the player's problem-solving skills." },
                new Genre { Id = 14, Name = "Music/Rhythm", Description = "Games that challenge the player's sense of rhythm and music timing." },
                new Genre { Id = 15, Name = "Educational", Description = "Games with an educational component, often aimed at younger players." },
                new Genre { Id = 16, Name = "Platformer", Description = "Games focusing on jumping and climbing through levels with uneven terrain." },
                new Genre { Id = 17, Name = "Stealth", Description = "Games where players often engage in gameplay focused on stealth and not being seen." },
                new Genre { Id = 18, Name = "Survival", Description = "Games focusing on survival of the player as a primary goal." },
                new Genre { Id = 19, Name = "VR (Virtual Reality)", Description = "Games designed to be played using virtual reality equipment." },
                new Genre { Id = 20, Name = "AR (Augmented Reality)", Description = "Games that blend the real-world environment with game elements." },
                new Genre { Id = 21, Name = "Indie", Description = "Games produced by individual developers or small teams without substantial financial backing." },
                new Genre { Id = 22, Name = "Sandbox", Description = "Games that allow a high degree of player freedom with minimal limitations." },
                new Genre { Id = 23, Name = "Battle Royale", Description = "Games featuring large numbers of players competing to be the last person standing." }
            };

            return genres;
        }
    }
}
