namespace MealPass.Core.Interface
{
    public interface IStockService
    {
        // Returns 1 = InStock, 2 = LowStock, 3 = OutOfStock
        int CalculateStockStatus(int quantity, int lowStockLevel);
    }
}
