using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace MealPass.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IStockService _stockService;

        public ProductService()
            : this(new ProductRepository(), new StockService()) { }

        public ProductService(IProductRepository productRepository, IStockService stockService)
        {
            _productRepository = productRepository;
            _stockService = stockService;
        }

        public Task<IEnumerable<Product>> GetAllAsync() => _productRepository.GetAllAsync();
        public Task<Product> GetByIdAsync(int id) => _productRepository.GetByIdAsync(id);

        public Task AddAsync(Product product)
        {
            product.StockStatusID = _stockService.CalculateStockStatus(product.Quantity, product.LowStockLevel);
            return _productRepository.AddAsync(product);
        }

        public Task UpdateAsync(Product product)
        {
            product.StockStatusID = _stockService.CalculateStockStatus(product.Quantity, product.LowStockLevel);
            return _productRepository.UpdateAsync(product);
        }

        public Task UpdateProductAsync(int productId, string name, int categoryId, decimal price, int quantity, int lowStockLevel)
        {
            int stockStatusId = _stockService.CalculateStockStatus(quantity, lowStockLevel);
            return _productRepository.UpdateProductAsync(productId, name, categoryId, price, quantity, lowStockLevel, stockStatusId);
        }

        public Task DeleteAsync(int id) => _productRepository.DeleteAsync(id);

        public Task<DataTable> GetAllWithDetailsAsync() => _productRepository.GetAllWithDetailsAsync();
        public Task<DataRow?> GetByIdWithDetailsAsync(int productId) => _productRepository.GetByIdWithDetailsAsync(productId);

        public Task<DataTable> LoadProductsAsync() => _productRepository.LoadProductsAsync();
        public Task<DataTable> LoadSnacksAsync() => _productRepository.LoadSnacksAsync();
        public Task<DataTable> LoadMealsAsync() => _productRepository.LoadMealsAsync();
        public Task<DataTable> LoadDrinksAsync() => _productRepository.LoadDrinksAsync();
    }
}
