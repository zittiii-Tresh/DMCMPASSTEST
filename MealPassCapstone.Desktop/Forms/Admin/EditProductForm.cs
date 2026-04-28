using System;
using System.Data;
using System.Windows.Forms;
using MealPass.Business.Services;
using MealPass.Core.Interface;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EditProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IProductService _productService = new ProductService();
        private int id;

        public EditProductForm(int productID)
        {
            InitializeComponent();
            id = productID;

            LoadProductDetails();
        }

        private async void LoadProductDetails()
        {
            try
            {
                DataRow productRow = await _productService.GetByIdWithDetailsAsync(id);

                if (productRow == null)
                {
                    MessageBox.Show("⚠️ Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                productnameTE.Text = productRow["ProductName"].ToString();
                priceTE.Text = productRow["Price"].ToString();
                quantityTE.Text = productRow["Quantity"].ToString();
                lowstocklevelTE.Text = productRow["LowStockLevel"].ToString();

                if (int.TryParse(productRow["CategoryID"].ToString(), out int categoryId))
                {
                    categoryCBE.SelectedIndex = categoryId - 1;
                }
                else
                {
                    categoryCBE.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load product details: " + ex.Message);
            }
        }

        private async void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string name = productnameTE.Text.Trim();
                int categoryId = categoryCBE.SelectedIndex + 1;
                decimal price = Convert.ToDecimal(priceTE.Text);
                int quantity = Convert.ToInt32(quantityTE.Text);
                int lowStockLevel = Convert.ToInt32(lowstocklevelTE.Text);

                await _productService.UpdateProductAsync(id, name, categoryId, price, quantity, lowStockLevel);

                MessageBox.Show("✅ Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to update product: " + ex.Message);
            }
        }

        private async void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(
                    "🗑️ Are you sure you want to delete this product? This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    await _productService.DeleteAsync(id);
                    MessageBox.Show("✅ Product deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to delete product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
