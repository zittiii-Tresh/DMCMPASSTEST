using System;
using System.Windows.Forms;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.Interface;

namespace MealPassCapstone.Desktop.Forms.Admin
{
    public partial class AddProductForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IProductService _productService = new ProductService();

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

            await _productService.AddAsync(product);
            MessageBox.Show("✅ Product added successfully!");

            ProductAdded?.Invoke(this, EventArgs.Empty);

            ClearAll();
        }

        private void ClearAll()
        {
            productnameTE.Text = string.Empty;
            priceTE.Text = string.Empty;
            quantityTE.Text = string.Empty;
            lowstocklevelTE.Text = string.Empty;

            categoryCBE.SelectedIndex = -1;

            productnameTE.Focus();
        }
    }
}
