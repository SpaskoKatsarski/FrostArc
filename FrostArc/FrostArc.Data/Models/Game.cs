﻿namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.GamePlatforms = new HashSet<GamePlatform>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [ForeignKey(nameof(Developer))]
        public Guid DeveloperId { get; set; }

        public Developer Developer { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }

        [Required]
        public Genre Genre { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(600)]
        public string ImageUrl { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public ICollection<GamePlatform> GamePlatforms { get; set; }
    }
}
