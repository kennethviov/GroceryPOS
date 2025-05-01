using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Serialization;
using GroceryPOS.Components;
using GroceryStroreDiscountGUI.Components;
using Microsoft.Data.SqlClient;
using System.Resources;
using System.Reflection;

namespace GroceryPOS
{
    internal class DataHandler
    {
        readonly string connectionString;
        readonly string query;

        public DataHandler() {
            connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; Database = protoDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            query = "SELECT\r\n    I.item_id,\r\n    I.item_name,\r\n    I.item_price,\r\n    I.item_unit,\r\n    I.item_stocks,\r\n    C.category_name AS category_description,\r\n    I.item_description\r\nFROM Items I\r\nJOIN Inventory C ON I.category_id = C.category_id";
        }

        public List<ProductCard> LoadProductsFromDatabase()
        {
            List<ProductCard> items = new List<ProductCard>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read())
                        {
                            ProductCard product = new ProductCard()
                            {
                                Name = reader["item_name"].ToString(),
                                Price = Convert.ToDouble(reader["item_price"]),
                                SoldBy = reader["item_unit"].ToString(),
                                Stock = (int)reader["item_stocks"],
                                Category = reader["category_description"].ToString().ToLower(),
                                Description = reader["item_description"].ToString()
                            };

                            product.Image = LoadProductImage(product.Name);

                            items.Add(product);
                        }

                        return items;
                    }
                }
            }
        }

        public List<Item> LoadItemsFromDatabase()
        {
            List<Item> items = new List<Item>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item item = new Item()
                            {
                                Name = reader["item_name"].ToString(),
                                Price = Convert.ToDouble(reader["item_price"]),
                                SoldBy = reader["item_unit"].ToString(),
                                Stock = (int)reader["item_stocks"],
                                Category = reader["category_description"].ToString().ToLower(),
                                Description = reader["item_description"].ToString()
                            };

                            item.Image = LoadProductImage(item.Name);

                            items.Add(item);
                        }

                        return items;
                    }
                }
            }
        }

        private Image LoadProductImage(string productName)
        {
            ResourceManager rm = GroceryPOS.Properties.Resources.ResourceManager;

            Image img = (Image)rm.GetObject(productName);

            Console.WriteLine(img);

            if (img != null) 
            {
                return img;
            } 
            else
            {
                return GroceryPOS.Properties.Resources.broken_image;
            }
        }
    }
}
