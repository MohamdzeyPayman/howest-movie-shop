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
    public class ShopOrderDetailsController : ControllerBase
    {
        private readonly db_moviesContext _context;

        public ShopOrderDetailsController(db_moviesContext context)
        {
            _context = context;
        }

        // GET: api/ShopOrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShopOrderDetail>>> GetShopOrderDetail()
        {
            return await _context.ShopOrderDetail.ToListAsync();
        }

        // GET: api/ShopOrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShopOrderDetail>> GetShopOrderDetail(long id)
        {
            var shopOrderDetail = await _context.ShopOrderDetail.FindAsync(id);

            if (shopOrderDetail == null)
            {
                return NotFound();
            }

            return shopOrderDetail;
        }

        // PUT: api/ShopOrderDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShopOrderDetail(long id, ShopOrderDetail shopOrderDetail)
        {
            if (id != shopOrderDetail.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(shopOrderDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopOrderDetailExists(id))
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

        // POST: api/ShopOrderDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ShopOrderDetail>> PostShopOrderDetail(ShopOrderDetail shopOrderDetail)
        {
            _context.ShopOrderDetail.Add(shopOrderDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShopOrderDetailExists(shopOrderDetail.OrderId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShopOrderDetail", new { id = shopOrderDetail.OrderId }, shopOrderDetail);
        }

        // DELETE: api/ShopOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ShopOrderDetail>> DeleteShopOrderDetail(long id)
        {
            var shopOrderDetail = await _context.ShopOrderDetail.FindAsync(id);
            if (shopOrderDetail == null)
            {
                return NotFound();
            }

            _context.ShopOrderDetail.Remove(shopOrderDetail);
            await _context.SaveChangesAsync();

            return shopOrderDetail;
        }

        private bool ShopOrderDetailExists(long id)
        {
            return _context.ShopOrderDetail.Any(e => e.OrderId == id);
        }
    }
}
