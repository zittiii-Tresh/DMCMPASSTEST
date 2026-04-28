using System.Data;
using System.Linq;
using MealPass.Core.Interface;

namespace MealPass.Business.Services
{
    public class CartService : ICartService
    {
        public DataTable CreateEmptyCart()
        {
            var cart = new DataTable();
            cart.Columns.Add("ID");
            cart.Columns.Add("ProductName");
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("Price", typeof(decimal));
            cart.Columns.Add("Total", typeof(decimal));
            return cart;
        }

        public bool IsInStock(int stock) => stock > 0;

        public bool IsInCart(DataTable cart, string productId) =>
            cart.AsEnumerable().Any(r => r["ID"].ToString() == productId);

        public void AddItem(DataTable cart, string productId, string productName, decimal price, int quantity)
        {
            DataRow newRow = cart.NewRow();
            newRow["ID"] = productId;
            newRow["ProductName"] = productName;
            newRow["Quantity"] = quantity;
            newRow["Price"] = price;
            newRow["Total"] = LineTotal(quantity, price);
            cart.Rows.Add(newRow);
        }

        public decimal CalculateGrandTotal(DataTable cart)
        {
            decimal sum = 0;
            foreach (DataRow row in cart.Rows)
            {
                if (decimal.TryParse(row["Total"]?.ToString(), out decimal total))
                {
                    sum += total;
                }
            }
            return sum;
        }

        public decimal LineTotal(int quantity, decimal price) => quantity * price;

        public void RemoveItemsById(DataTable cart, string productId)
        {
            var rowsToRemove = cart.AsEnumerable()
                .Where(r => r["ID"].ToString() == productId)
                .ToList();

            foreach (var row in rowsToRemove)
                cart.Rows.Remove(row);
        }
    }
}
