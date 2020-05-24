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
    public class ShopMoviePricesController : ControllerBase
    {
        private readonly db_moviesContext _context;

        public ShopMoviePricesController(db_moviesContext context)
        {
            _context = context;
        }

        // GET: api/ShopMoviePrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopMoviePrice>>> GetShopMoviePrice()
        {
            return await _context.ShopMoviePrice.ToListAsync();
        }

        // GET: api/ShopMoviePrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopMoviePrice>> GetShopMoviePrice(long id)
        {
            var shopMoviePrice = await _context.ShopMoviePrice.FindAsync(id);

            if (shopMoviePrice == null)
            {
                return NotFound();
            }

            return shopMoviePrice;
        }

        // PUT: api/ShopMoviePrices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopMoviePrice(long id, ShopMoviePrice shopMoviePrice)
        {
            if (id != shopMoviePrice.MovieId)
            {
                return BadRequest();
            }

            _context.Entry(shopMoviePrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopMoviePriceExists(id))
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

        // POST: api/ShopMoviePrices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ShopMoviePrice>> PostShopMoviePrice(ShopMoviePrice shopMoviePrice)
        {
            _context.ShopMoviePrice.Add(shopMoviePrice);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShopMoviePriceExists(shopMoviePrice.MovieId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShopMoviePrice", new { id = shopMoviePrice.MovieId }, shopMoviePrice);
        }

        // DELETE: api/ShopMoviePrices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShopMoviePrice>> DeleteShopMoviePrice(long id)
        {
            var shopMoviePrice = await _context.ShopMoviePrice.FindAsync(id);
            if (shopMoviePrice == null)
            {
                return NotFound();
            }

            _context.ShopMoviePrice.Remove(shopMoviePrice);
            await _context.SaveChangesAsync();

            return shopMoviePrice;
        }

        private bool ShopMoviePriceExists(long id)
        {
            return _context.ShopMoviePrice.Any(e => e.MovieId == id);
        }
    }
}
