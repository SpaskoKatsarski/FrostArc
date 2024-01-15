namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataValidationConstants.Platform;

    public class Platform
    {
        public Platform()
        {
            this.GamePlatforms = new HashSet<GamePlatform>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public ICollection<GamePlatform> GamePlatforms { get; set; }
    }
}
