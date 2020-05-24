using howest_movie_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace howest_movie_shop.Library.DTO
{
    public class MovieDTO
    {
        public long Id { get; set; }
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public string CoverUrl { get; set; }
        public int Year { get; set; }
        public string OriginalAirDate { get; set; }
        public string Kind { get; set; }
        public decimal Rating { get; set; }
        public string Plot { get; set; }
        public int Top250Rank { get; set; }

        public List<Genres> genres { get; set; }
        public List<PersonDTO> persons { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
