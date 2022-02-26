using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWithoutORM.Data
{
    //namespaces
    using CrudWithoutORM.Common;
    using System.Data.SqlClient;

    /// <summary>
    /// Crud operations
    /// </summary>
    public class ProductData
    {
        /// <summary>
        /// Get all products from the database
        /// </summary>
        /// <returns>All Products</returns>
        public List<Product> GetAll()
        {
            var productList = new List<Product>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM product", connection);
                connection.Open();

                using (var reader= command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product
                            (
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDecimal(2),
                                reader.GetInt32(3)
                            );
                        productList.Add(product);
                    }
                }
            }
            return productList;
        }

        /// <summary>
        /// Get single product from the database by id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product</returns>
        public Product Get(int id)
        {
            Product product = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM product WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                           (
                           reader.GetInt32(0),
                           reader.GetString(1),
                           reader.GetDecimal(2),
                           reader.GetInt32(3)
                           );
                    }

                }
            }
            return product;
        }

        /// <summary>
        /// Add single product to the database
        /// </summary>
        public void Add(Product product)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO product (Name, Price, Stock) VALUES (@name, @price, @stock)", connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Update single product in the database
        /// </summary>
        public void Update(Product product)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("UPDATE product SET Name=@name, Price=@price, Stock=@stock WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Delete a product from the database by id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>True/False</returns>
        public bool Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE FROM product WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id.ToString());
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
