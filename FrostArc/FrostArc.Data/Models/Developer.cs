namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.DataValidationConstants.Developer;

    public class Developer
    {
        public Developer()
        {
            this.Id = Guid.NewGuid();
            this.Games = new HashSet<Game>();
        }

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
