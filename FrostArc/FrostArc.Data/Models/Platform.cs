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
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
