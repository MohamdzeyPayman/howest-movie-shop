using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace howest_movie_shop.Library.DTO
{
    public class ShopDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string MovieTitle { get; set; }
        public int TotalPrice { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

    }
}
