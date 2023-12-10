namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

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
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public ICollection<Game> Games { get; set; }
    }
}
