using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using howest_movie_lib.Models;

namespace howest_movie_lib.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreMoviesController : ControllerBase
    {
        private readonly db_moviesContext _context;

        public GenreMoviesController(db_moviesContext context)
        {
            _context = context;
        }

        // GET: api/GenreMovies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreMovie>>> GetGenreMovie()
        {
            return await _context.GenreMovie.ToListAsync();
        }

        // GET: api/GenreMovies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenreMovie>> GetGenreMovie(long id)
        {
            var genreMovie = await _context.GenreMovie.FindAsync(id);

            if (genreMovie == null)
            {
                return NotFound();
            }

            return genreMovie;
        }

        // PUT: api/GenreMovies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenreMovie(long id, GenreMovie genreMovie)
        {
            if (id != genreMovie.MovieId)
            {
                return BadRequest();
            }

            _context.Entry(genreMovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenreMovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GenreMovies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GenreMovie>> PostGenreMovie(GenreMovie genreMovie)
        {
            _context.GenreMovie.Add(genreMovie);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GenreMovieExists(genreMovie.MovieId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGenreMovie", new { id = genreMovie.MovieId }, genreMovie);
        }

        // DELETE: api/GenreMovies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GenreMovie>> DeleteGenreMovie(long id)
        {
            var genreMovie = await _context.GenreMovie.FindAsync(id);
            if (genreMovie == null)
            {
                return NotFound();
            }

            _context.GenreMovie.Remove(genreMovie);
            await _context.SaveChangesAsync();

            return genreMovie;
        }

        private bool GenreMovieExists(long id)
        {
            return _context.GenreMovie.Any(e => e.MovieId == id);
        }
    }
}
