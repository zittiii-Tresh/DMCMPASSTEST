using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task<DataRow?> GetByIdWithDetailsAsync(int productId);  
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<DataTable> GetAllWithDetailsAsync();

        // ✅ New: Centralized stock status calculation
        int CalculateStockStatus(int quantity, int lowStockLevel);

        // ✅ New: Easier product update by fields
        Task UpdateProductAsync(int productId, string name, int categoryId, decimal price, int quantity, int lowStockLevel, int stockStatusId);
    }
}
