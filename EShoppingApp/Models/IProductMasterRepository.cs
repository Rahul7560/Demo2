using EShoppingEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShoppingApp.Models
{
    public interface IProductMasterRepository
    {
        Task<Product> GetProduct(string prodCode);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product productChanges);
        Task<Product> DeleteProduct(int productId);
        
    }
}
