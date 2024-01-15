namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataValidationConstants.Genre;

    public class Genre
    {
        public Genre()
        {
            this.Games = new HashSet<Game>();
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

        public ICollection<Game> Games { get; set; }
    }
}
