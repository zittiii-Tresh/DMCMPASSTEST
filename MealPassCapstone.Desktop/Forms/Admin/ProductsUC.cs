using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class ProductsUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IProductRepository _productRepository = new ProductRepository();

        public ProductsUC()
        {
            InitializeComponent();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            try
            {
                var productsTable = await _productRepository.GetAllWithDetailsAsync();

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
            // ✅ Create an instance of the form
            var form = new AddProductForm();

            // 🔥 Subscribe to the ProductAdded event BEFORE showing it
            form.ProductAdded += (s, args) =>
            {
                LoadProducts(); // ✅ Refresh grid when a new product is added
            };

            // ✅ Show the form
            Helpers.FormHelper.DisplayForm(form);
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProducts.ApplyFindFilter(e.NewValue as string);
        }

        private void gvProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // ✅ Get the ProductID from the clicked row
            var selectedProductID = gvProducts.GetRowCellValue(e.RowHandle, "ProductID");

            if (selectedProductID != null && int.TryParse(selectedProductID.ToString(), out int productId))
            {
                // ✅ Open the EditProductForm with the selected ProductID
                using (var editForm = new EditProductForm(productId))
                {
                    editForm.ShowDialog();
                }

                // ✅ Refresh the product list after editing
                LoadProducts();
            }
            else
            {
                MessageBox.Show("⚠️ Unable to get the selected Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
