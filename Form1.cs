using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Stock_Manage
{
    public partial class Form1 : Form
    {
        ProductRepository repository = new ProductRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            dgv_product.DataSource = null;
            dgv_product.DataSource = repository.GetAllProducts();

            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_product.MultiSelect = false;
            dgv_product.ReadOnly = true;
            dgv_product.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            

            if (dgv_product.Columns["Created"] != null)
            {
                dgv_product.Columns["Created"].HeaderText = "Created At";
                dgv_product.Columns["Created"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

        }

        private void SearchProducts()
        {
            dgv_product.DataSource = null;
            dgv_product.DataSource = repository.SearchProducts(txt_search.Text);

            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_product.MultiSelect = false;
            dgv_product.ReadOnly = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_produto frm = new frm_produto();
            frm.ShowDialog();
            LoadProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                LoadProducts();
            }
            else
            {
                SearchProducts();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            if (dgv_product.CurrentRow == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            Product product = new Product();
            product.Id = Convert.ToInt32(dgv_product.CurrentRow.Cells["Id"].Value);
            product.Name = dgv_product.CurrentRow.Cells["Name"].Value.ToString();
            product.Category = dgv_product.CurrentRow.Cells["Category"].Value.ToString();
            product.Price = Convert.ToDecimal(dgv_product.CurrentRow.Cells["Price"].Value);
            product.Quantity = Convert.ToInt32(dgv_product.CurrentRow.Cells["Quantity"].Value);

            frm_produto frm = new frm_produto(product);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_product.CurrentRow == null)
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                int productId = Convert.ToInt32(dgv_product.CurrentRow.Cells["Id"].Value);
                string productName = dgv_product.CurrentRow.Cells["Name"].Value.ToString();
                int quantity = Convert.ToInt32(dgv_product.CurrentRow.Cells["Quantity"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the product '" + productName + "'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    repository.AddStockMovement(productId, "OUT", quantity, "Product deleted");
                    repository.DeleteProduct(productId);

                    MessageBox.Show("Product deleted successfully.");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_movements_Click(object sender, EventArgs e)
        {
            frm_movimentos frm = new frm_movimentos();
            frm.ShowDialog();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(folderPath, $"Products_{DateTime.Now:yyyyMMdd_HHmm}.xlsx");

                Excel.Application excel = new Excel.Application();
                excel.Workbooks.Add();

                Excel._Worksheet worksheet = excel.ActiveSheet;

                for (int i = 1; i <= dgv_product.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgv_product.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_product.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_product.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv_product.Rows[i].Cells[j].Value;
                    }
                }

                worksheet.Columns.AutoFit();

                excel.ActiveWorkbook.SaveAs(filePath);
                excel.ActiveWorkbook.Close();
                excel.Quit();

                MessageBox.Show(
                    "The export was completed successfully.\nThe file was saved on your Desktop.",
                    "Export Completed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Stock Management System\n\n" +
                "Developed by: Daniel Coz\n" +
                "Year: 2026\n\n" +
                "This application was developed as a learning project.\n" +
                "Version 1.0",
                "Credits",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}