using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using howest_movie_shop.Library.DTO;
using howest_movie_shop.Library.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace howest_movie_shop.Controllers
{
    
    public class ShoppingCartController : Controller
    {
        
        public IActionResult Index()
        {
            List<MovieDTO> movieDTO = null;
            if (HttpContext.Session.Get<List<MovieDTO>>("AddtoCart") == default)
            {
                ViewBag.count = 0;
            }
            else
            {
                movieDTO = HttpContext.Session.Get<List<MovieDTO>>("AddtoCart");
                ViewBag.count = (movieDTO).Count;
            }
            return View(movieDTO);
        }
        
    }
}