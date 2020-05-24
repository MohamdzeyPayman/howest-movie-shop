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
    public class ShopOrdersController : ControllerBase
    {
        private readonly db_moviesContext _context;

        public ShopOrdersController(db_moviesContext context)
        {
            _context = context;
        }

        // GET: api/ShopOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopOrder>>> GetShopOrder()
        {
            return await _context.ShopOrder.ToListAsync();
        }

        // GET: api/ShopOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopOrder>> GetShopOrder(long id)
        {
            var shopOrder = await _context.ShopOrder.FindAsync(id);

            if (shopOrder == null)
            {
                return NotFound();
            }

            return shopOrder;
        }

        // PUT: api/ShopOrders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopOrder(long id, ShopOrder shopOrder)
        {
            if (id != shopOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(shopOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopOrderExists(id))
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

        // POST: api/ShopOrders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ShopOrder>> PostShopOrder(ShopOrder shopOrder)
        {
            _context.ShopOrder.Add(shopOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopOrder", new { id = shopOrder.Id }, shopOrder);
        }

        // DELETE: api/ShopOrders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShopOrder>> DeleteShopOrder(long id)
        {
            var shopOrder = await _context.ShopOrder.FindAsync(id);
            if (shopOrder == null)
            {
                return NotFound();
            }

            _context.ShopOrder.Remove(shopOrder);
            await _context.SaveChangesAsync();

            return shopOrder;
        }

        private bool ShopOrderExists(long id)
        {
            return _context.ShopOrder.Any(e => e.Id == id);
        }
    }
}
