﻿using System;
using System.Collections.Generic;

namespace howest_movie_shop.Models
{
    public partial class MovieRole
    {
        public long MovieId { get; set; }
        public long PersonId { get; set; }
        public string Role { get; set; }
    }
}
