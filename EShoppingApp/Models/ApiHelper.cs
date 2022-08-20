using System.Net.Http;

namespace EShoppingApp.Models
{
    public class ApiHelper
    {
        public ApiHelper(HttpClient httpClient)
        {
            ApiClient = httpClient;
        }

        public HttpClient ApiClient;
    }
}
