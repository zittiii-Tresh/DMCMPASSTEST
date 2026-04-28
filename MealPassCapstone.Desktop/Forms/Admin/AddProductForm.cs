using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSQL;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class AddProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IProductRepository _productRepository = new ProductRepository();

        // 🔥 Declare event
        public event EventHandler ProductAdded;

        public AddProductForm()
        {
            InitializeComponent();
        }

        private async void addproductBTN_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductName = productnameTE.Text.Trim(),
                CategoryID = categoryCBE.SelectedIndex + 1,
                Price = int.Parse(priceTE.Text),
                Quantity = int.Parse(quantityTE.Text),
                LowStockLevel = int.Parse(lowstocklevelTE.Text)
            };

            await _productRepository.AddAsync(product);
            MessageBox.Show("✅ Product added successfully!");

            // 🔥 Trigger the event
            ProductAdded?.Invoke(this, EventArgs.Empty);

            ClearAll();
        }

        private void ClearAll() 
        {
            // Clear text fields
            productnameTE.Text = string.Empty;
            priceTE.Text = string.Empty;
            quantityTE.Text = string.Empty;
            lowstocklevelTE.Text = string.Empty;

            // Reset combo box
            categoryCBE.SelectedIndex = -1;

            // Optional: Set focus back to the first input
            productnameTE.Focus();
        }
    }
}
