namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.Platforms = new HashSet<Platform>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
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

        public ICollection<Platform> Platforms { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 20)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(600)]
        public string ImageUrl { get; set; } = null!;
    }
}
