using EShoppingEntity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EShoppingApp.Models
{
    public class ProductMasterRepository : IProductMasterRepository
    {
        private readonly ApiHelper _apiHelper;

        public ProductMasterRepository(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public async Task<Product> AddProduct(Product product)
        {
            HttpResponseMessage httpResponseMessage = await _apiHelper.ApiClient.PostAsJsonAsync("Products/Create", product);
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Product>(content);
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            HttpResponseMessage httpResponseMessage = await _apiHelper.ApiClient.PostAsJsonAsync("Products/Delete",new { id = productId } );
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Product>(content);
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            HttpResponseMessage httpResponseMessage = await _apiHelper.ApiClient.GetAsync("Products/Index");
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(content);
        }

        public async Task<Product> GetProduct(string ProdId)
        {
            HttpResponseMessage httpResponseMessage = await _apiHelper.ApiClient.GetAsync($"Products/Details/{ProdId}");
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Product> (content);
        }

        public async Task<Product> UpdateProduct(Product productChanges)
        {
            HttpResponseMessage httpResponseMessage = await _apiHelper.ApiClient.PostAsJsonAsync($"Products/Edit", productChanges);
            string content = await httpResponseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Product>(content);
        }
    }
}
