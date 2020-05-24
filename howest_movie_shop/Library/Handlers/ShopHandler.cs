using howest_movie_shop.Library.DTO;
using howest_movie_shop.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace howest_movie_shop.Library.Handlers
{
    public class ShopHandler
    {
        public ShopCustomer postShopCustomer(string Id, string Name, string Street, string City, string PostalCode, string Country)
        {
            using (var client = new WebClient())
            {
                ShopCustomer sc = new ShopCustomer(); //Setting parameter to post  
                sc.UserId = Id;
                sc.Name = Name;
                sc.Street = Street;
                sc.City = City;
                sc.PostalCode = PostalCode;
                sc.Country = Country;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("https://localhost:44310/api/ShopCustomers", JsonConvert.SerializeObject(sc));
                ShopCustomer shopcustomer = JsonConvert.DeserializeObject<ShopCustomer>(result);
                return shopcustomer;
            }
            //var client = new RestClient("https://localhost:44310/api/ShopCustomers");


        }
        public ShopOrder postShopOrder(int CustomerId, string Street, string City, string PostalCode, string Country)
        {
            using (var client = new WebClient())
            {
                ShopOrder sc = new ShopOrder(); //Setting parameter to post  
                sc.CustomerId = Convert.ToInt32(CustomerId);
                sc.Street = Street;
                sc.City = City;
                sc.PostalCode = PostalCode;
                sc.Country = Country;
                sc.OrderDate = DateTime.Now;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("https://localhost:44310/api/ShopOrders", JsonConvert.SerializeObject(sc));
                ShopOrder so =  JsonConvert.DeserializeObject<ShopOrder>(result);
                return so;
            }
        }
        public ShopOrderDetail postShopOrderDetail(int OrderId, int MovieId, int UnitPrice)
        {
            using (var client = new WebClient())
            {
                ShopOrderDetail sc = new ShopOrderDetail(); //Setting parameter to post  
                sc.OrderId = OrderId;
                sc.MovieId = MovieId;
                sc.UnitPrice = UnitPrice;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString("https://localhost:44310/api/ShopOrderDetails", JsonConvert.SerializeObject(sc));
                ShopOrderDetail sod = JsonConvert.DeserializeObject<ShopOrderDetail>(result);
                return sod;
            }
        }


        public List<ShopDTO> getAllMoviesData()
        {
            List<ShopDTO> movieDTOs = new List<ShopDTO>();
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.BaseAddress = "https://localhost:44310/";
                    var json = webClient.DownloadString("api/Movies");
                    var movies = JsonConvert.DeserializeObject<List<Movies>>(json).ToList();

                    var SCjson = webClient.DownloadString("api/ShopCustomers");
                    var shopCustomers = JsonConvert.DeserializeObject<List<ShopCustomer>>(SCjson).ToList();

                    var SMPjson = webClient.DownloadString("api/ShopMoviePrices");
                    var shopMoviePrices = JsonConvert.DeserializeObject<List<ShopMoviePrice>>(SMPjson).ToList();

                    var SOjson = webClient.DownloadString("api/ShopOrders");
                    var shopOrders = JsonConvert.DeserializeObject<List<ShopOrder>>(SOjson).ToList();

                    var SODjson = webClient.DownloadString("api/ShopOrderDetails");
                    var shopOrderDetails = JsonConvert.DeserializeObject<List<ShopOrderDetail>>(SODjson).ToList();

                    foreach (var item in shopOrders)
                    {
                        ShopDTO shopDTO = new ShopDTO()
                        {
                            OrderId = Convert.ToInt32(item.Id),
                            OrderDate = item.OrderDate,
                            Address = item.Street + " " + item.Country,
                            CustomerName = shopCustomers.FirstOrDefault(x => x.Id == item.CustomerId).Name
                        };
                        List<ShopOrderDetail> shopOrderDetail = shopOrderDetails.Where(x => x.OrderId == item.Id).ToList();
                        int amount = 0; string movienames = "";
                        foreach (var shopOdetail in shopOrderDetail)
                        {
                            amount = amount + Convert.ToInt32(shopMoviePrices.FirstOrDefault(x => x.MovieId == shopOdetail.MovieId).UnitPrice);
                            movienames = movienames + " ," + movies.FirstOrDefault(x => x.Id == shopOdetail.MovieId).Title;
                        }
                        shopDTO.MovieTitle = movienames;
                        shopDTO.TotalPrice = amount;
                        movieDTOs.Add(shopDTO);
                        //MovieTitle = movies.Where(x=>x.)
                    }
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
            return movieDTOs; ;
        }

        public void deleteOrder(int id)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44310/");
            client.DefaultRequestHeaders.Accept.Clear();
            HttpResponseMessage response = client.DeleteAsync("api/ShopOrders/" + id).Result;
           
        }
    }
}
