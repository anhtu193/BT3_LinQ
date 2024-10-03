using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_LinQ
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        // Adding a product
        private void AddProduct(string productID, string name, int quantity, decimal unitPrice, string origin, DateTime expiryDate)
        {
            products.Add(new Product(productID, name, quantity, unitPrice, origin, expiryDate));
            RefreshProductList();
        }
  
        // Deleting a product
        private void DeleteProduct(string productID)
        {
            products.RemoveAll(p => p.ProductID == productID);
            RefreshProductList();
        }

        // Checking for expired products
        private bool HasExpiredProducts()
        {
            return products.Exists(p => p.ExpiryDate < DateTime.Now);
        }

        // Finding the product with the highest price
        private Product FindProductWithHighestPrice()
        {
            return products.OrderByDescending(p => p.UnitPrice).FirstOrDefault();
        }

        // Finding a product by origin (Japan)
        private Product FindProductByOrigin(string origin)
        {
            return products.FirstOrDefault(p => p.Origin == origin);
        }

        // Getting all expired products
        private List<Product> GetExpiredProducts()
        {
            return products.FindAll(p => p.ExpiryDate < DateTime.Now);
        }

        // Getting products with price between a and b
        private List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return products.Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList();
        }

        // Deleting all products by origin
        private void DeleteProductsByOrigin(string origin)
        {
            products.RemoveAll(p => p.Origin == origin);
            RefreshProductList();
        }

        // Deleting all products
        private void DeleteAllProducts()
        {
            products.Clear();
            RefreshProductList();
        }

        // Delete all expired products
        private void DeleteExpiredProducts()
        {
            products.RemoveAll(p => p.ExpiryDate < DateTime.Now);

            RefreshProductList();
        }

        // Refresh the product list in the UI
        private void RefreshProductList()
        {
            ProductList.Items.Clear();
            foreach (var product in products)
            {
                ProductList.Items.Add(new ListViewItem(new string[] { product.ProductID, product.Name, product.Quantity.ToString(), product.UnitPrice.ToString(), product.Origin, product.ExpiryDate.ToShortDateString() }));
            }
        }

        private void reset()
        {
            txtProductID.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtOrigin.Clear();
            txtName.Clear();
            dtpExpiryDate.ResetText();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct(txtProductID.Text, txtName.Text, int.Parse(txtQuantity.Text), decimal.Parse(txtUnitPrice.Text), txtOrigin.Text, dtpExpiryDate.Value);
            reset();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Length == 0)
            {
                MessageBox.Show("Please enter Product ID to delete.");
            }
            else
            {
                DeleteProduct(txtProductID.Text);
                reset();
            }
        }

        private void btnFindHighestPrice_Click(object sender, EventArgs e)
        {
            var product = FindProductWithHighestPrice();
            productListView.Items.Clear();
            productListView.Items.Add(new ListViewItem(new string[] { product.ProductID, product.Name, product.Quantity.ToString(), product.UnitPrice.ToString(), product.Origin, product.ExpiryDate.ToShortDateString() }));
        }

        private void btnFindJapanProduct_Click(object sender, EventArgs e)
        {
           var product = FindProductByOrigin("Nhat Ban");
            productListView.Items.Clear();
            productListView.Items.Add(new ListViewItem(new string[] { product.ProductID, product.Name, product.Quantity.ToString(), product.UnitPrice.ToString(), product.Origin, product.ExpiryDate.ToShortDateString() }));
        }

        private void btnGetExpiredProducts_Click(object sender, EventArgs e)
        {
            var ExpiredProduct = GetExpiredProducts();
            productListView.Items.Clear();
            foreach (var product in ExpiredProduct)
            {
                productListView.Items.Add(new ListViewItem(new string[] { product.ProductID, product.Name, product.Quantity.ToString(), product.UnitPrice.ToString(), product.Origin, product.ExpiryDate.ToShortDateString() }));
            }
        }

        private void btnGetProductsByPriceRange_Click(object sender, EventArgs e)
        {
            var productsFromRange = GetProductsByPriceRange(decimal.Parse(txtMinPrice.Text), decimal.Parse(txtMaxPrice.Text));
            productListView.Items.Clear();
            foreach (var product in productsFromRange)
            {
                productListView.Items.Add(new ListViewItem(new string[] { product.ProductID, product.Name, product.Quantity.ToString(), product.UnitPrice.ToString(), product.Origin, product.ExpiryDate.ToShortDateString() }));
            }
        }

        private void btnDeleteProductsByOrigin_Click(object sender, EventArgs e)
        {
            if(txtProductOriginToDelete.Text != string.Empty)
            {
                DeleteProductsByOrigin(txtProductOriginToDelete.Text);
                txtProductOriginToDelete.Clear();
            }
            else
            {
                MessageBox.Show("Please enter origin.");
            }
        }

        private void btnCheckExpired_Click(object sender, EventArgs e)
        {
            bool hasExpiredProduct = HasExpiredProducts();
            if (hasExpiredProduct)
            {
                MessageBox.Show("There're expired products in storage.");
            }
            else
            {
                MessageBox.Show("There're no expired products in storage.");
            } 
                

        }

        private void btnDeleteAllProducts_Click(object sender, EventArgs e)
        {
            DeleteAllProducts();
        }

        private void btnDeleteExpiredProducts_Click(object sender, EventArgs e)
        {
            DeleteExpiredProducts();
        }
    }
}
