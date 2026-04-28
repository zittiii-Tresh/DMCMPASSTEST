using System;
using System.Windows.Forms;
using MealPass.Business.Services;
using MealPass.Core.Interface;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class ProductsUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IProductService _productService = new ProductService();

        public ProductsUC()
        {
            InitializeComponent();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            try
            {
                var productsTable = await _productService.GetAllWithDetailsAsync();

                if (productsTable.Rows.Count == 0)
                {
                    MessageBox.Show("⚠️ No products found.");
                }

                gcProducts.DataSource = productsTable;
                gvProducts.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load products: " + ex.Message);
            }
        }

        private void addproductBTN_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm();

            form.ProductAdded += (s, args) =>
            {
                LoadProducts();
            };

            Helpers.FormHelper.DisplayForm(form);
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProducts.ApplyFindFilter(e.NewValue as string);
        }

        private void gvProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedProductID = gvProducts.GetRowCellValue(e.RowHandle, "ProductID");

            if (selectedProductID != null && int.TryParse(selectedProductID.ToString(), out int productId))
            {
                using (var editForm = new EditProductForm(productId))
                {
                    editForm.ShowDialog();
                }

                LoadProducts();
            }
            else
            {
                MessageBox.Show("⚠️ Unable to get the selected Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
