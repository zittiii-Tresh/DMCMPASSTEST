using System.Data;

namespace MealPass.Core.Interface
{
    public interface ICartService
    {
        DataTable CreateEmptyCart();
        bool IsInStock(int stock);
        bool IsInCart(DataTable cart, string productId);
        void AddItem(DataTable cart, string productId, string productName, decimal price, int quantity);
        decimal CalculateGrandTotal(DataTable cart);
        decimal LineTotal(int quantity, decimal price);
        void RemoveItemsById(DataTable cart, string productId);
    }
}
