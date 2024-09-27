using System.ComponentModel.DataAnnotations;
namespace MovieLeans. Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}