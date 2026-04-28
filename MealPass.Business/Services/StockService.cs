using MealPass.Core.Interface;

namespace MealPass.Business.Services
{
    public class StockService : IStockService
    {
        public int CalculateStockStatus(int quantity, int lowStockLevel)
        {
            if (quantity == 0)
                return 3; // OutOfStock
            if (quantity <= lowStockLevel)
                return 2; // LowStock
            return 1; // InStock
        }
    }
}
