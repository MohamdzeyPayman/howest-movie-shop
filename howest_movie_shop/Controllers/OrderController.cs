using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using howest_movie_shop.Library.DTO;
using howest_movie_shop.Library.Handlers;
using howest_movie_shop.Library.Services;
using howest_movie_shop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace howest_movie_shop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Order = "Empty";
            return View();
        }
        public IActionResult PostOrderAsync(string Name, string Street, string City, string PostalCode, string Country, string PaymentMethod)
        {
            string Id = "a4efc61e-843c-4abb-9299-d08850fabf4e";
            
            ShopCustomer shopCustomer = new ShopHandler().postShopCustomer(Id,Name,Street,City,PostalCode,Country);
            ShopOrder shopOrder = new ShopHandler().postShopOrder(Convert.ToInt32(shopCustomer.Id), Street, City, PostalCode, Country);

            List<MovieDTO> movieDTOs = HttpContext.Session.Get<List<MovieDTO>>("AddtoCart");
            foreach (var item in movieDTOs)
            {
                new ShopHandler().postShopOrderDetail(Convert.ToInt32(shopOrder.Id), Convert.ToInt32(item.Id), Convert.ToInt32(item.UnitPrice));
            }
            HttpContext.Session.Clear();
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Orders()
        {
           List<ShopDTO> shopDTOs = new ShopHandler().getAllMoviesData();
            return View(shopDTOs);
        }
        public IActionResult deleteOrder(int id)
        {
            new ShopHandler().deleteOrder(id);
            return RedirectToAction("Orders");
        }
    }
}