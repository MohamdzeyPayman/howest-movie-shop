using System;
using System.Collections.Generic;

namespace howest_movie_shop.Models
{
    public partial class ShopOrderDetail
    {
        public long OrderId { get; set; }
        public long MovieId { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
