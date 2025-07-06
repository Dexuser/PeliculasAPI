using PeliculasAPI.Models;

namespace PeliculasAPI.Interfaces;

public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetAllMoviesAsync();
    Task AddMovieAsync(Movie movie);
    Task UpdateMovieAsync(Movie movie);
    Task DeleteMovieAsync(int id);
    Task<Movie?> GetMovieByIdAsync(int id);
}