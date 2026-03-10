using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace Stock_Manage
{
    public class ProductRepository
    {
        Database db = new Database();

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();
                    p.Id = reader.GetInt32("id");
                    p.Name = reader.GetString("name");
                    p.Category = reader.GetString("category");
                    p.Price = reader.GetDecimal("price");
                    p.Quantity = reader.GetInt32("quantity");
                    if (!reader.IsDBNull(reader.GetOrdinal("created_at")))
                        p.Created = reader.GetDateTime("created_at");
                    else
                        p.Created = null;

                    products.Add(p);
                }
            }

            return products;
        }

        public DataTable GetAllMovements()
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                sm.id AS Id,
                p.name AS Product,
                sm.movement_type AS MovementType,
                sm.quantity AS Quantity,
                sm.movement_date AS MovementDate,
                sm.notes AS Notes
                FROM stock_movements sm
                INNER JOIN products p ON sm.product_id = p.id
                ORDER BY sm.id ASC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(table);
            }

            return table;
        }
        public List<Product> SearchProducts(string searchText)
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM products WHERE name LIKE @search OR category LIKE @search";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product p = new Product();
                    p.Id = reader.GetInt32("id");
                    p.Name = reader.GetString("name");
                    p.Category = reader.GetString("category");
                    p.Price = reader.GetDecimal("price");
                    p.Quantity = reader.GetInt32("quantity");

                    products.Add(p);
                }
            }

            return products;
        }

        public DataTable SearchMovements(string searchText)
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                sm.id AS Id,
                p.name AS Product,
                sm.movement_type AS MovementType,
                sm.quantity AS Quantity,
                sm.movement_date AS MovementDate,
                sm.notes AS Notes
                FROM stock_movements sm
                INNER JOIN products p ON sm.product_id = p.id
                WHERE p.name LIKE @search
                OR sm.notes LIKE @search
                OR sm.movement_type LIKE @search
                ORDER BY sm.movement_date DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }

        public int AddProduct(Product product)
        {
            int newProductId = 0;

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO products (name, category, price, quantity)
                         VALUES (@name, @category, @price, @quantity);
                         SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

                newProductId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return newProductId;
        }

        public void AddStockMovement(int productId, string movementType, int quantity, string notes)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO stock_movements (product_id, movement_type, quantity, notes)
                         VALUES (@product_id, @movement_type, @quantity, @notes)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@movement_type", movementType);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@notes", notes);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE products 
                         SET name = @name,
                             category = @category,
                             price = @price,
                             quantity = @quantity
                         WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", product.Id);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int productId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM products WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
