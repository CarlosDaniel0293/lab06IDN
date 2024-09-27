
using System.ComponentModel.DataAnnotations;
namespace MovieLeans.Models
{
    public class Review
    {
    }
    public int Id { get; set; }
    [Required]
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Comment { get; set; }
    [Range(1, 5)]
    public int Rating { get; set; } 
}// Calificación de 1 a 5