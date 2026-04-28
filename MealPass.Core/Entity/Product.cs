using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int CategoryID { get; set; }
        
        public int StockStatusID { get; set; }
        public int LowStockLevel { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
