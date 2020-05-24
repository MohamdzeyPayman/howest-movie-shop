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
    public class ShopCustomersController : ControllerBase
    {
        private readonly db_moviesContext _context;

        public ShopCustomersController(db_moviesContext context)
        {
            _context = context;
        }

        // GET: api/ShopCustomers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopCustomer>>> GetShopCustomer()
        {
            return await _context.ShopCustomer.ToListAsync();
        }

        // GET: api/ShopCustomers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopCustomer>> GetShopCustomer(long id)
        {
            var shopCustomer = await _context.ShopCustomer.FindAsync(id);

            if (shopCustomer == null)
            {
                return NotFound();
            }

            return shopCustomer;
        }

        // PUT: api/ShopCustomers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopCustomer(long id, ShopCustomer shopCustomer)
        {
            if (id != shopCustomer.Id)
            {
                return BadRequest();
            }

            _context.Entry(shopCustomer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopCustomerExists(id))
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

        // POST: api/ShopCustomers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ShopCustomer>> PostShopCustomer(ShopCustomer shopCustomer)
        {
            _context.ShopCustomer.Add(shopCustomer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShopCustomer", new { id = shopCustomer.Id }, shopCustomer);
        }

        // DELETE: api/ShopCustomers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShopCustomer>> DeleteShopCustomer(long id)
        {
            var shopCustomer = await _context.ShopCustomer.FindAsync(id);
            if (shopCustomer == null)
            {
                return NotFound();
            }

            _context.ShopCustomer.Remove(shopCustomer);
            await _context.SaveChangesAsync();

            return shopCustomer;
        }

        private bool ShopCustomerExists(long id)
        {
            return _context.ShopCustomer.Any(e => e.Id == id);
        }
    }
}
