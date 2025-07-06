using Microsoft.EntityFrameworkCore.Metadata;
using PeliculasAPI.Interfaces;
using PeliculasAPI.Models;

namespace PeliculasAPI.Services;

public class MovieServices : IMovieServices
{
    private readonly IMovieRepository _repository;
    
    public  MovieServices(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return await _repository.GetAllMoviesAsync();
    }

    public async Task AddMovieAsync(Movie movie)
    {
        await _repository.AddMovieAsync(movie);
    }

    public async Task UpdateMovieAsync(Movie movie)
    {
        await _repository.UpdateMovieAsync(movie);
    }

    public async Task DeleteMovieAsync(int id)
    {
        await _repository.DeleteMovieAsync(id);
    }

    public async Task<Movie?> GetMovieByIdAsync(int id)
    {
        return await _repository.GetMovieByIdAsync(id);
    }
}