using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Interfaces;
using PeliculasAPI.Models;

namespace PeliculasAPI.Repository;

// Andamos probando Asincronia por aqui
public class MovieRepository : IMovieRepository
{
    private readonly MoviesContext _context;

    public MovieRepository(MoviesContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return await _context.Movies.ToListAsync();
    }

    public async Task AddMovieAsync(Movie movie)
    {
        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateMovieAsync(Movie movie)
    {
        _context.Movies.Update(movie);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMovieAsync(int id)
    {
        Movie? movie = await _context.Movies.FindAsync(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Movie?> GetMovieByIdAsync(int id)
    {
          return await _context.Movies.FindAsync(id);
    }
}