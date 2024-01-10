namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Platform
    {
        public Platform()
        {
            this.GamePlatforms = new HashSet<GamePlatform>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public ICollection<GamePlatform> GamePlatforms { get; set; }
    }
}
