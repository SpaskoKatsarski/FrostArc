namespace FrostArc.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Platform
    {
        public Platform()
        {
            this.Games = new HashSet<Game>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = null!;

        public ICollection<Game> Games { get; set; }
    }
}
