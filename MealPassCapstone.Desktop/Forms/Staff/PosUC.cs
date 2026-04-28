using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealPass.Business.Services;
using MealPass.Core.Interface;
using MealPassCapstone.Desktop.Helpers;

namespace MealPassCapstone.Desktop.Forms.Staff
{
    public partial class PosUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IProductService _productService = new ProductService();
        private readonly ICartService _cartService = new CartService();

        public PosUC()
        {
            InitializeComponent();
            Cancel.ColumnEdit = repositoryItemCancelBTN;
            this.Load += PosUC_LoadAsync;
        }

        private async void PosUC_LoadAsync(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private async Task LoadSnacksAsync()
        {
            productsGC.DataSource = await _productService.LoadSnacksAsync();
        }

        private async Task LoadMealsAsync()
        {
            productsGC.DataSource = await _productService.LoadMealsAsync();
        }

        private async Task LoadProductsAsync()
        {
            productsGC.DataSource = await _productService.LoadProductsAsync();
        }

        private async Task LoadDrinksAsync()
        {
            productsGC.DataSource = await _productService.LoadDrinksAsync();
        }

        private void addtocartBTN_Click(object sender, EventArgs e)
        {
            int selectedRow = productsGV.FocusedRowHandle;
            if (selectedRow < 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            string productID = productsGV.GetRowCellValue(selectedRow, "ProductID")?.ToString();
            string productName = productsGV.GetRowCellValue(selectedRow, "ProductName")?.ToString();
            string priceStr = productsGV.GetRowCellValue(selectedRow, "Price")?.ToString();
            string stockStr = productsGV.GetRowCellValue(selectedRow, "Quantity")?.ToString();
            int stock = int.TryParse(stockStr, out int s) ? s : 0;

            if (!_cartService.IsInStock(stock))
            {
                MessageBox.Show($"Sorry, '{productName}' is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = decimal.TryParse(priceStr, out decimal p) ? p : 0;
            int quantity = 1;

            DataTable cartTable = cartGC.DataSource as DataTable;
            if (cartTable == null)
            {
                cartTable = _cartService.CreateEmptyCart();
                cartGC.DataSource = cartTable;
            }

            if (_cartService.IsInCart(cartTable, productID))
            {
                MessageBox.Show($"'{productName}' is already in your cart.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _cartService.AddItem(cartTable, productID, productName, price, quantity);

            UpdateTotalAmount(cartTable);
        }

        private void UpdateTotalAmount(DataTable cartTable)
        {
            decimal sum = _cartService.CalculateGrandTotal(cartTable);
            grandtotalLBL.Text = sum.ToString("N2");
        }

        private void cartGV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity" || e.Column.FieldName == "Price")
            {
                int rowHandle = e.RowHandle;
                object quantityObj = cartGV.GetRowCellValue(rowHandle, "Quantity");
                object priceObj = cartGV.GetRowCellValue(rowHandle, "Price");

                if (int.TryParse(quantityObj?.ToString(), out int quantity) &&
                    decimal.TryParse(priceObj?.ToString(), out decimal price))
                {
                    decimal total = _cartService.LineTotal(quantity, price);
                    cartGV.SetRowCellValue(rowHandle, "Total", total);

                    if (cartGC.DataSource is DataTable cartTable)
                    {
                        UpdateTotalAmount(cartTable);
                    }
                }
            }
        }

        private void repositoryItemCancelBTN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.ButtonEdit;
            if (editor == null) return;

            var view = cartGV;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle < 0) return;

            string id = view.GetRowCellValue(rowHandle, "ID")?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            if (cartGC.DataSource is DataTable cartTable)
            {
                _cartService.RemoveItemsById(cartTable, id);
                UpdateTotalAmount(cartTable);
                view.RefreshData();
            }
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.PaymentOptionForm());
        }

        private async void snacksBTN_Click(object sender, EventArgs e) => await LoadSnacksAsync();
        private async void mealsBTN_Click(object sender, EventArgs e) => await LoadMealsAsync();
        private async void drinksBTN_Click(object sender, EventArgs e) => await LoadDrinksAsync();
        private async void allBTN_Click(object sender, EventArgs e) => await LoadProductsAsync();

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            productsGV.ApplyFindFilter(e.NewValue as string);
        }
    }
}
