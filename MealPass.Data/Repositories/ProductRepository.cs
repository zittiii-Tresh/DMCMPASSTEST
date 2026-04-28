using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Core.GlobalSQL;
using MealPass.Data.Queries;
using System.Data;

namespace MealPass.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository()
        {
            _connectionString = SQLQuery.connectionString;
        }

        // GET ALL
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryAsync<Product>(ProductQuery.GetAll);
            }
        }

        // GET BY ID
        public async Task<Product> GetByIdAsync(int productId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Product>(ProductQuery.GetById, new { Id = productId });
            }
        }

        // ADD (StockStatusID auto-calculated)
        public async Task AddAsync(Product product)
        {
            product.StockStatusID = CalculateStockStatus(product.Quantity, product.LowStockLevel);

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(ProductQuery.Insert, product);
            }
        }

        // UPDATE (StockStatusID auto-calculated)
        public async Task UpdateAsync(Product product)
        {
            product.StockStatusID = CalculateStockStatus(product.Quantity, product.LowStockLevel);

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

        // DELETE
        public async Task DeleteAsync(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(ProductQuery.Delete, new { Id = id });
            }
        }

        // Centralized logic for StockStatusID
        public int CalculateStockStatus(int quantity, int lowStockLevel)
        {
            if (quantity == 0)
                return 3; // OutOfStock
            else if (quantity <= lowStockLevel)
                return 2; // LowStock
            else
                return 1; // InStock
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
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                string query = ProductQuery.FilterAllProducts;
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    await Task.Run(() => adapter.Fill(dataTable));

                    return dataTable;
                }
            }
        }

        public async Task<DataTable> LoadSnacksAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                string query = ProductQuery.FilterSnacks;
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    await Task.Run(() => adapter.Fill(dataTable));

                    return dataTable;
                }
            }
        }

        public async Task<DataTable> LoadMealsAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                string query = ProductQuery.FilterMeals;
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    await Task.Run(() => adapter.Fill(dataTable));

                    return dataTable;
                }
            }
        }

        public async Task<DataTable> LoadDrinksAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                string query = ProductQuery.FilterDrinks;
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
