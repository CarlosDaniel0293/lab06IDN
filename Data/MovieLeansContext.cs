using Microsoft.Entity FrameworkCore; 
using MovieLeans.Models;
namespace MovieLeans.Data
{
    public class MovieLeansContext: DbContext
    {
    public MovieLeansContext (DbContextOptions<MovieLeansContext> options) : base(options)
    { 
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }
    }
}