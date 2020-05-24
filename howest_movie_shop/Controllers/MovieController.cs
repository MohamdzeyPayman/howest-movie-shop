using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using howest_movie_shop.Library.DTO;
using howest_movie_shop.Library.Handlers;
using howest_movie_shop.Library.Services;
using howest_movie_shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using project.Models;

namespace howest_movie_shop.Controllers
{
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;

        private static int count = 0;
        public MovieController(ILogger<MovieController> logger)
        {
            //if (HttpContext.Session.Get<List<MovieDTO>>("AddtoCart") == default)
            //{
            //    HttpContext.Session.Set<List<MovieDTO>>("AddtoCart", null);
            //}
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Requires SessionExtensions from sample download.
            if (HttpContext.Session.Get<List<MovieDTO>>("movies") == default)
            {
                List<MovieDTO> movieDTOs = new MovieHandler().getAllMoviesData();
                HttpContext.Session.Set<List<MovieDTO>>("movies", movieDTOs);
            }
            List<MovieDTO> movieDTO = HttpContext.Session.Get<List<MovieDTO>>("movies");

            ViewBag.count = count;
            return View(movieDTO);
        }

        public ActionResult AddToCart(int movieId)
        {
            MovieDTO movie = HttpContext.Session.Get<List<MovieDTO>>("movies").FirstOrDefault(x => x.Id == Convert.ToInt32(movieId));
            
            if (HttpContext.Session.Get<List<MovieDTO>>("AddtoCart") == default)
            {
                List<MovieDTO> movieDTOs = new List<MovieDTO>();
                movieDTOs.Add(movie);
                HttpContext.Session.Set<List<MovieDTO>>("AddtoCart", movieDTOs);
            }
            else
            {
                List<MovieDTO> movieDTOs = HttpContext.Session.Get<List<MovieDTO>>("AddtoCart");
                movieDTOs.Add(movie);
                HttpContext.Session.Set<List<MovieDTO>>("AddtoCart", movieDTOs);
            }
            count = (HttpContext.Session.Get<List<MovieDTO>>("AddtoCart")).Count;
            ViewBag.count = count;
            return RedirectToAction("", "");
        }
        public IActionResult Search(string SearchValue, string SortKey, string SortOrder)
        {
            List<MovieDTO> movieDTO = HttpContext.Session.Get<List<MovieDTO>>("movies").Where(x=>x.Title.Contains(SearchValue)).ToList();
            if(SortOrder == "asc")
            {
                if (SortKey == "Title")
                {
                    movieDTO = movieDTO.OrderBy(x => x.Title).ToList();
                }
                else
                {
                    movieDTO = movieDTO.OrderBy(x => x.Year).ToList();
                }
            }
            else
            {
                if (SortKey == "Title")
                {
                    movieDTO = movieDTO.OrderByDescending(x => x.Title).ToList();
                }
                else
                {
                    movieDTO = movieDTO.OrderByDescending(x => x.Year).ToList();
                }
            }
            ViewBag.count = count;
            return View("Index", movieDTO);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
