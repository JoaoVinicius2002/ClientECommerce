using ClientECommerce.Models;
using ClientECommerce.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientECommerce.Repositories
{
    public class OrderRepository
    {
        HttpClient cliente = new HttpClient();
        public OrderRepository()
        {
            cliente.BaseAddress = new Uri("https://localhost:44358/");
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<OrderProductDTO>> GetOrderProductsAsync()
        {
            HttpResponseMessage response = await cliente.GetAsync("api/Order/GetAllOrders");
            if (response.IsSuccessStatusCode)
            {
                var orders = await response.Content.ReadAsStringAsync();
                var result =  JsonConvert.DeserializeObject<List<OrderProductDTO>>(orders);
                return result;
            }
            return new List<OrderProductDTO>();
        }

    }
}
