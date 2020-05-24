using System;
using howest_movie_shop.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace howest_movie_shop.Library.Seeders
{
    static class MoviePriceSeeder
    {
        public static void Run(){
            db_moviesContext context = new db_moviesContext();
            context.Database.EnsureCreated();
           var moviePrices = context.ShopMoviePrice.ToListAsync();
            if (moviePrices == null) {
                context.AddRange(new[]
                {
                 new ShopMoviePrice()
                 {
                     MovieId = 1,
                     UnitPrice = 4
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 2,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 3,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 4,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 5,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 6,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 7,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 8,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 9,
                     UnitPrice = 5
                 }, new ShopMoviePrice()
                 {
                     MovieId = 10,
                     UnitPrice = 4
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 11,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 12,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 13,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 14,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 15,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 16,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 17,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 18,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 19,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 20,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 21,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 22,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 23,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 24,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 25,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 26,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 27,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 28,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 29,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 30,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 31,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 32,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 33,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 34,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 35,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 36,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 37,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 38,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 39,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 40,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 41,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 42,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 43,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 44,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 45,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 46,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 47,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 48,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 49,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 50,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 51,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 52,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 53,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 54,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 55,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 56,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 57,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 58,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 59,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 60,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 61,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 62,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 63,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 64,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 65,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 66,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 67,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 68,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 69,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 70,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 71,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 72,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 73,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 74,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 75,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 76,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 77,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 78,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 79,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 80,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 81,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 82,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 83,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 84,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 85,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 86,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 87,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 88,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 89,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 90,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 91,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 92,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 93,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 94,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 95,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 96,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 97,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 98,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 99,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 100,
                     UnitPrice = 1
                 },new ShopMoviePrice()
                 {
                     MovieId = 101,
                     UnitPrice = 4
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 102,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 103,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 104,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 105,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 106,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 107,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 108,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 109,
                     UnitPrice = 5
                 }, new ShopMoviePrice()
                 {
                     MovieId = 110,
                     UnitPrice = 4
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 111,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 112,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 113,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 114,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 115,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 116,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 117,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 118,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 119,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 120,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 121,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 122,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 123,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 124,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 125,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 126,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 127,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 128,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 129,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 130,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 131,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 132,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 133,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 134,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 135,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 136,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 137,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 138,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 139,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 140,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 141,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 142,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 143,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 144,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 145,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 146,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 147,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 148,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 149,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 150,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 151,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 152,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 153,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 154,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 155,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 156,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 157,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 158,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 159,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 160,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 161,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 162,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 163,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 164,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 165,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 166,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 167,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 168,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 169,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 170,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 171,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 172,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 173,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 174,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 175,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 176,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 177,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 178,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 179,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 180,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 181,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 182,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 183,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 184,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 185,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 186,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 187,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 188,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 189,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 190,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 191,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 192,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 193,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 194,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 195,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 196,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 197,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 198,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 199,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 200,
                     UnitPrice = 1
                 }, new ShopMoviePrice()
                 {
                     MovieId = 201,
                     UnitPrice = 4
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 202,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 203,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 204,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 205,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 206,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 207,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 208,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 209,
                     UnitPrice = 5
                 }, new ShopMoviePrice()
                 {
                     MovieId = 210,
                     UnitPrice = 4
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 211,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 212,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 213,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 214,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 215,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 216,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 217,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 218,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 219,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 220,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 221,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 222,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 223,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 224,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 225,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 226,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 227,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 228,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 229,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 230,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 231,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 232,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 233,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 234,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 235,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 236,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 237,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 238,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 239,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 240,
                     UnitPrice = 1
                 },
                  new ShopMoviePrice()
                 {
                     MovieId = 241,
                     UnitPrice = 5
                 },
                   new ShopMoviePrice()
                 {
                     MovieId = 242,
                     UnitPrice = 2
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 243,
                     UnitPrice = 7
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 244,
                     UnitPrice = 9
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 245,
                     UnitPrice = 4
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 246,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 247,
                     UnitPrice = 6
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 248,
                     UnitPrice = 5
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 249,
                     UnitPrice = 8
                 },
                    new ShopMoviePrice()
                 {
                     MovieId = 250,
                     UnitPrice = 1
                 }
             });
                context.SaveChanges();
            }
           
        }
    }
}