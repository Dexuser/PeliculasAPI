using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Interfaces;
using PeliculasAPI.Models;

namespace PeliculasAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieServices _movieServices;

    public MoviesController(IMovieServices moviesServies)
    {
        _movieServices = moviesServies;
    }
    
    [HttpGet]
    //[Route("GetAllMovies")]
    public async Task<ActionResult> GetAllMovies()
    {
        var movies = await _movieServices.GetAllMoviesAsync();
        if (movies.Count() == 0)
        {
            return NoContent();
        }
        return Ok(movies);
    }

    [HttpGet("{id}")]
    //[Route("GetAllMovies")]
    public async Task<ActionResult> GetAllMovies(int id)
    {
        var movie = await _movieServices.GetMovieByIdAsync(id);
        if (movie == null)
        {
            return NotFound();
        }
        return Ok(movie);
    }

    // Today I discovered that ASP.NET validates the models sended by himself. 
    // that's cool
    [HttpPost]
    //[Route("AddMovie")]
    public async Task<ActionResult> AddMovie(Movie movie)
    {
        await _movieServices.AddMovieAsync(movie);
        return Created();
    }

    [HttpPut]
    //[Route("UpdateMovie")]
    public async Task<ActionResult> UpdateMovie(Movie movie)
    {
        await _movieServices.UpdateMovieAsync(movie);
        return Ok();
    }

    [HttpDelete("{id}")]
    //[Route("DeleteMovie")]
    public async Task<ActionResult> DeleteMovie(int id)
    {
        await _movieServices.DeleteMovieAsync(id);
        return NoContent();
    }
}