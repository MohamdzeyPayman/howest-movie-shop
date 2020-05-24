using howest_movie_shop.Library.DTO;
using howest_movie_shop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace howest_movie_shop.Library.Handlers
{
    public class MovieHandler
    {
        public List<MovieDTO> getAllMoviesData()
        {
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "https://localhost:44310/";
                    var json = webClient.DownloadString("api/Movies");
                    var movies = JsonConvert.DeserializeObject<List<Movies>>(json).ToList();

                    var jsonPersons = webClient.DownloadString("api/Persons");
                    var Persons = JsonConvert.DeserializeObject<List<Persons>>(jsonPersons);


                    var jsonGenres = webClient.DownloadString("api/Genres");
                    var genres = JsonConvert.DeserializeObject<List<Genres>>(jsonGenres).ToList();

                    var jsonShopMoviePrices = webClient.DownloadString("api/ShopMoviePrices");
                    var ShopMoviePrices = JsonConvert.DeserializeObject<List<ShopMoviePrice>>(jsonShopMoviePrices).ToList();


                    foreach (var item in movies)
                    {
                        MovieDTO movieDTO = new MovieDTO()
                        {
                            Id = item.Id,
                            ImdbId = item.ImdbId,
                            Title = item.Title,
                            CoverUrl = item.CoverUrl,
                            Year = item.Year,
                            OriginalAirDate = item.OriginalAirDate,
                            Kind = item.Kind,
                            Rating = item.Rating,
                            Plot = item.Plot,
                            Top250Rank = item.Top250Rank
                        };

                        //Genre Start
                        var jsonG = webClient.DownloadString("api/GenreMovies");
                        var genreMovies = JsonConvert.DeserializeObject<List<GenreMovie>>(jsonG).Where(x=>x.MovieId == item.Id).ToList();
                        List<Genres> genrelist = new List<Genres>();
                        if (genreMovies != null)
                        {
                            foreach (var gm in genreMovies)
                            {
                                var temp = genres.FirstOrDefault(x => x.Id == gm.GenreId);
                                genrelist.Add(new Genres()
                                {
                                    Id = temp.Id,
                                    ImdbName = temp.ImdbName,
                                    Name = temp.Name
                                });
                            }
                            movieDTO.genres = genrelist;
                        }
                        // Genre End


                        //Person Start
                        List<PersonDTO> PersonDTOs = new List<PersonDTO>();
                        var jsonMovieRoles = webClient.DownloadString("api/MovieRoles");
                        var MovieRoles = JsonConvert.DeserializeObject<List<MovieRole>>(jsonMovieRoles).Where(x => x.MovieId == item.Id).ToList();
                       foreach (var mr in MovieRoles)
                        {
                            Persons temp = Persons.FirstOrDefault(x => x.Id == mr.PersonId);
                            if (temp != null)
                            {
                                var tempPerson = new PersonDTO()
                                {
                                    Biography = temp.Biography,
                                    ImdbId = temp.ImdbId,
                                    Name = temp.Name,
                                    role = mr.Role
                                };
                                PersonDTOs.Add(tempPerson);
                            }
                                
                        }
                        //Person End
                        movieDTO.persons = PersonDTOs;
                        movieDTO.UnitPrice = ShopMoviePrices.Where(x => x.MovieId == item.Id).FirstOrDefault().UnitPrice;

                        movieDTOs.Add(movieDTO);
                    }
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
            return movieDTOs;
        }
    }
}
