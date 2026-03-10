using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manage
{
    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
        }

        private int originalQuantity = 0;
        ProductRepository repository = new ProductRepository();

        private Product productToEdit = null;

        public frm_produto(Product product)
        {
            InitializeComponent();
            productToEdit = product;
            originalQuantity = product.Quantity;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_name.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the product name.");
                    return;
                }

                if (txt_category.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the category.");
                    return;
                }

                if (!decimal.TryParse(txt_price.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price.");
                    return;
                }

                if (!int.TryParse(txt_quantity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity.");
                    return;
                }

                if (productToEdit == null)
                {
                    Product product = new Product();
                    product.Name = txt_name.Text.Trim();
                    product.Category = txt_category.Text.Trim();
                    product.Price = price;
                    product.Quantity = quantity;

                    int newProductId = repository.AddProduct(product);
                    repository.AddStockMovement(newProductId, "IN", quantity, $"Initial stock: {quantity} units");

                    MessageBox.Show("Product added successfully!");
                }
                else
                {
                    productToEdit.Name = txt_name.Text.Trim();
                    productToEdit.Category = txt_category.Text.Trim();
                    productToEdit.Price = price;
                    productToEdit.Quantity = quantity;

                    repository.UpdateProduct(productToEdit);

                    if (quantity > originalQuantity)
                    {
                        int difference = quantity - originalQuantity;
                        repository.AddStockMovement(
                            productToEdit.Id,
                            "IN",
                            difference,
                            $"Stock increased by {difference} units"
                        );
                    }
                    else if (quantity < originalQuantity)
                    {
                        int difference = originalQuantity - quantity;
                        repository.AddStockMovement(
                            productToEdit.Id,
                            "OUT",
                            difference,
                            $"Stock decreased by {difference} units"
                        );
                    }

                    MessageBox.Show("Product updated successfully!");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frm_produto_Load(object sender, EventArgs e)
        {
            if (productToEdit != null)
            {
                txt_name.Text = productToEdit.Name;
                txt_category.Text = productToEdit.Category;
                txt_price.Text = productToEdit.Price.ToString();
                txt_quantity.Text = productToEdit.Quantity.ToString();
            }
        }
    }
}
