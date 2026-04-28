using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task UpdateProductAsync(int productId, string name, int categoryId, decimal price, int quantity, int lowStockLevel);
        Task DeleteAsync(int id);

        Task<DataTable> GetAllWithDetailsAsync();
        Task<DataRow?> GetByIdWithDetailsAsync(int productId);

        Task<DataTable> LoadProductsAsync();
        Task<DataTable> LoadSnacksAsync();
        Task<DataTable> LoadMealsAsync();
        Task<DataTable> LoadDrinksAsync();
    }
}
