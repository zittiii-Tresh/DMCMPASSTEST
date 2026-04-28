using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class ProductQuery
    {
        public const string GetAll = @"
            SELECT * FROM pro.Products";

        public const string GetById = @"
            SELECT * FROM pro.Products 
            WHERE ProductID = @Id";

        public const string Insert = @"
            INSERT INTO pro.Products
            (ProductName, CategoryID, StockStatusID, LowStockLevel, Quantity, Price)
            VALUES (@ProductName, @CategoryID, @StockStatusID, @LowStockLevel, @Quantity, @Price)";

        public const string Update = @"
            UPDATE pro.Products
            SET ProductName = @ProductName,
                CategoryID = @CategoryID,
                LowStockLevel = @LowStockLevel,
                Quantity = @Quantity,
                Price = @Price,
                StockStatusID = @StockStatusID
            WHERE ProductID = @ProductID";

        public const string Delete = @"
            DELETE FROM pro.Products
            WHERE ProductID = @Id";

        public const string GetAllWithDetails = @"
            SELECT p.ProductID,
                   p.ProductName,
                   c.CategoryName,
                   p.Quantity,
                   s.StockStatusName,
                   p.Price
            FROM pro.Products p
            LEFT JOIN pro.Category c ON p.CategoryID = c.CategoryID
            LEFT JOIN pro.StockStatus s ON p.StockStatusID = s.StockStatusID";

        public const string GetByIdWithDetails = @"
            SELECT p.ProductID,
                   p.ProductName,
                   c.CategoryName,
                   p.Quantity,
                   s.StockStatusName,
                   p.Price,
                   p.LowStockLevel,
                   p.CategoryID
            FROM pro.Products p
            LEFT JOIN pro.Category c ON p.CategoryID = c.CategoryID
            LEFT JOIN pro.StockStatus s ON p.StockStatusID = s.StockStatusID
            WHERE p.ProductID = @ProductID";

        public static string FilterAllProducts = @"
                                                   SELECT p.ProductID 
                                                  ,p.ProductName
                                                  ,c.CategoryName
                                                  ,ss.StockStatusName
                                                  ,p.Quantity
                                                  ,p.Price
                                              FROM pro.Products p
                                              LEFT JOIN pro.Category c
                                              ON c.CategoryID = p.CategoryID
                                              LEFT JOIN pro.StockStatus ss
                                              ON ss.StockStatusID = p.StockStatusID;";

        public static string FilterSnacks = @"SELECT p.ProductID 
                                                  ,p.ProductName
                                                  ,c.CategoryName
                                                  ,ss.StockStatusName
                                                  ,p.Quantity
                                                  ,p.Price
                                              FROM pro.Products p
                                              LEFT JOIN pro.Category c
                                              ON c.CategoryID = p.CategoryID
                                              LEFT JOIN pro.StockStatus ss
                                              ON ss.StockStatusID = p.StockStatusID
                                              WHERE c.CategoryID = 1;";

        public static string FilterDrinks = @"SELECT p.ProductID 
                                                  ,p.ProductName
                                                  ,c.CategoryName
                                                  ,ss.StockStatusName
                                                  ,p.Quantity
                                                  ,p.Price
                                              FROM pro.Products p
                                              LEFT JOIN pro.Category c
                                              ON c.CategoryID = p.CategoryID
                                              LEFT JOIN pro.StockStatus ss
                                              ON ss.StockStatusID = p.StockStatusID
                                              WHERE c.CategoryID = 2;";

        public static string FilterMeals = @"SELECT p.ProductID 
                                                  ,p.ProductName
                                                  ,c.CategoryName
                                                  ,ss.StockStatusName
                                                  ,p.Quantity
                                                  ,p.Price
                                              FROM pro.Products p
                                              LEFT JOIN pro.Category c
                                              ON c.CategoryID = p.CategoryID
                                              LEFT JOIN pro.StockStatus ss
                                              ON ss.StockStatusID = p.StockStatusID
                                              WHERE c.CategoryID = 3;";

    }
}
