
using Microsoft.AspNetCore.Mvc; 
using Microsoft.EntityFrameworkCore; 
using MovieLeans.Data;
using MovieLeans.Models;
public class AnalyticsController: Controller
{
    private readonly MovieLeansContext _context;
    public AnalyticsController(MovieLeansContext context)
    {
    _context = context;
    }
// Método para obtener las películas más populares por género 
    public async Task<IActionResult> PopularMoviesByGenre()
    {
        var popularMovies = await _context.Movies
        .GroupBy (m => m. Genre)
        .Select(g => new
        {
            Genre = g.Key,
            Count = g.Count()
        }
        Count = g.Count()
        })
        .OrderByDescending(g => g.Count) 
        .ToListAsync();
        return View(popularMovies);
}