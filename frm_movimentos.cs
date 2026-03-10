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
    public partial class frm_movimentos : Form
    {
        public frm_movimentos()
        {
            InitializeComponent();
        }

        ProductRepository repository = new ProductRepository();


        private void dgv_movements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadMovements()
        {
            dgv_movements.DataSource = null;
            dgv_movements.DataSource = repository.GetAllMovements();

            dgv_movements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_movements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_movements.MultiSelect = false;
            dgv_movements.ReadOnly = true;
            dgv_movements.AllowUserToAddRows = false;
            dgv_movements.AllowUserToDeleteRows = false;
            dgv_movements.RowHeadersVisible = false;

            dgv_movements.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv_movements.Columns["Id"].HeaderText = "ID";
            dgv_movements.Columns["Product"].HeaderText = "Product";
            dgv_movements.Columns["MovementType"].HeaderText = "Movement Type";
            dgv_movements.Columns["Quantity"].HeaderText = "Quantity";
            dgv_movements.Columns["MovementDate"].HeaderText = "Movement Date";
            dgv_movements.Columns["Notes"].HeaderText = "Notes";

            dgv_movements.Columns["MovementDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }
        private void SearchMovements()
        {
            dgv_movements.DataSource = null;
            dgv_movements.DataSource = repository.SearchMovements(txt_search.Text);

            dgv_movements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_movements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_movements.MultiSelect = false;
            dgv_movements.ReadOnly = true;
            dgv_movements.AllowUserToAddRows = false;
            dgv_movements.AllowUserToDeleteRows = false;
            dgv_movements.RowHeadersVisible = false;

            dgv_movements.Columns["Id"].HeaderText = "ID";
            dgv_movements.Columns["Product"].HeaderText = "Product";
            dgv_movements.Columns["MovementType"].HeaderText = "Movement Type";
            dgv_movements.Columns["Quantity"].HeaderText = "Quantity";
            dgv_movements.Columns["MovementDate"].HeaderText = "Movement Date";
            dgv_movements.Columns["Notes"].HeaderText = "Notes";

            dgv_movements.Columns["MovementDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void frm_movimentos_Load(object sender, EventArgs e)
        {
            LoadMovements();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                LoadMovements();
            }
            else
            {
                SearchMovements();
            }
        }
    }
}
