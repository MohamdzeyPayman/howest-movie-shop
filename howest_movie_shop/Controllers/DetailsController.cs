using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using howest_movie_shop.Library.DTO;
using howest_movie_shop.Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace howest_movie_shop.Controllers
{
    public class DetailsController : Controller
    {
       public IActionResult Index(string movieId)
        {
            MovieDTO movieDTO = HttpContext.Session.Get<List<MovieDTO>>("movies").FirstOrDefault(x => x.Id == Convert.ToInt32(movieId));
            if (HttpContext.Session.Get<List<MovieDTO>>("AddtoCart") == default)
            {
                ViewBag.count = 0;
            }
            else
            {
                ViewBag.count = (HttpContext.Session.Get<List<MovieDTO>>("AddtoCart")).Count;
            }

                return View(movieDTO);
        }
    }
}