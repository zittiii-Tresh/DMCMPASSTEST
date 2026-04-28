using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using MealPass.Shared;

namespace MealPass.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<Product>(ProductQuery.GetAll);
            }
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Product>(ProductQuery.GetById, new { Id = productId });
            }
        }

        public async Task AddAsync(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(ProductQuery.Insert, product);
            }
        }

        public async Task UpdateAsync(Product product)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(ProductQuery.Update, product);
            }
        }

        public async Task UpdateProductAsync(int productId, string name, int categoryId, decimal price, int quantity, int lowStockLevel, int stockStatusId)
        {
            var product = new Product
            {
                ProductID = productId,
                ProductName = name,
                CategoryID = categoryId,
                Price = price,
                Quantity = quantity,
                LowStockLevel = lowStockLevel,
                StockStatusID = stockStatusId
            };

            await UpdateAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(ProductQuery.Delete, new { Id = id });
            }
        }

        public async Task<DataTable> GetAllWithDetailsAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(ProductQuery.GetAllWithDetails, connection))
                {
                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public async Task<DataRow?> GetByIdWithDetailsAsync(int productId)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(ProductQuery.GetByIdWithDetails, conn))
            {
                cmd.Parameters.AddWithValue("@ProductID", productId);
                await conn.OpenAsync();

                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public async Task<DataTable> LoadProductsAsync()
        {
            return await LoadAsync(ProductQuery.FilterAllProducts);
        }

        public async Task<DataTable> LoadSnacksAsync()
        {
            return await LoadAsync(ProductQuery.FilterSnacks);
        }

        public async Task<DataTable> LoadMealsAsync()
        {
            return await LoadAsync(ProductQuery.FilterMeals);
        }

        public async Task<DataTable> LoadDrinksAsync()
        {
            return await LoadAsync(ProductQuery.FilterDrinks);
        }

        private async Task<DataTable> LoadAsync(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    await Task.Run(() => adapter.Fill(dataTable));
                    return dataTable;
                }
            }
        }
    }
}
