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
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(500, MinimumLength = 10)]
        public string Description { get; set; } = null!;

        public ICollection<Game> Games { get; set; }
    }
}
