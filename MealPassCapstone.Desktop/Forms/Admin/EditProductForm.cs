using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class EditProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IProductRepository _productRepository = new ProductRepository();
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
                DataRow productRow = await _productRepository.GetByIdWithDetailsAsync(id);

                if (productRow == null)
                {
                    MessageBox.Show("⚠️ Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                // ✅ Fill form controls with database values
                productnameTE.Text = productRow["ProductName"].ToString();
                priceTE.Text = productRow["Price"].ToString();
                quantityTE.Text = productRow["Quantity"].ToString();
                lowstocklevelTE.Text = productRow["LowStockLevel"].ToString();

                // ✅ Convert CategoryID (1,2,3) → ComboBox SelectedIndex (0,1,2)
                if (int.TryParse(productRow["CategoryID"].ToString(), out int categoryId))
                {
                    categoryCBE.SelectedIndex = categoryId - 1;
                }
                else
                {
                    categoryCBE.SelectedIndex = -1; // No selection if invalid
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

                // ✅ Use CalculateStockStatus from the repository
                int stockStatusId = _productRepository.CalculateStockStatus(quantity, lowStockLevel);

                await _productRepository.UpdateProductAsync(id, name, categoryId, price, quantity, lowStockLevel, stockStatusId);

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
                    await _productRepository.DeleteAsync(id);
                    MessageBox.Show("✅ Product deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the edit form after deletion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to delete product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}