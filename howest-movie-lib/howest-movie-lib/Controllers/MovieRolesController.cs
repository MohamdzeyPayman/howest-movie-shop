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
    public class MovieRolesController : ControllerBase
    {
        private readonly db_moviesContext _context;

        public MovieRolesController(db_moviesContext context)
        {
            _context = context;
        }

        // GET: api/MovieRoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieRole>>> GetMovieRole()
        {
            return await _context.MovieRole.ToListAsync();
        }

        // GET: api/MovieRoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieRole>> GetMovieRole(long id)
        {
            var movieRole = await _context.MovieRole.FindAsync(id);

            if (movieRole == null)
            {
                return NotFound();
            }

            return movieRole;
        }

        // PUT: api/MovieRoles/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieRole(long id, MovieRole movieRole)
        {
            if (id != movieRole.MovieId)
            {
                return BadRequest();
            }

            _context.Entry(movieRole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieRoleExists(id))
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

        // POST: api/MovieRoles
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MovieRole>> PostMovieRole(MovieRole movieRole)
        {
            _context.MovieRole.Add(movieRole);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MovieRoleExists(movieRole.MovieId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMovieRole", new { id = movieRole.MovieId }, movieRole);
        }

        // DELETE: api/MovieRoles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovieRole>> DeleteMovieRole(long id)
        {
            var movieRole = await _context.MovieRole.FindAsync(id);
            if (movieRole == null)
            {
                return NotFound();
            }

            _context.MovieRole.Remove(movieRole);
            await _context.SaveChangesAsync();

            return movieRole;
        }

        private bool MovieRoleExists(long id)
        {
            return _context.MovieRole.Any(e => e.MovieId == id);
        }
    }
}
