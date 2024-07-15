using OOP_NguyenDinhCong.DAO;
using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.Demo
{
    public class DatabaseDemo
    {
        private Database database;

        public DatabaseDemo()
        {
            database = Database.Instance;
        }

        //Phuong thuc InsertTableTest

        public void InsertTableTest()
        {
            Product product = new Product { Id = 1, Name = "Product 1", Price = 17000000 };
            database.InsertTable("product", product);

            Category category = new Category { Id = 1, Name = "Category 1" };
            database.InsertTable("category", category);

            Accessory accessory = new Accessory { Id = 1, Name = "Accessory 1", Description = "good" };
            database.InsertTable("accessory", accessory);
        }

        //Phuong thuc SelectTableTest
        public void SelectTableTest()
        {
            var products = database.SelectTable("product");
            foreach (Product p in products)
            {
                Console.WriteLine($"Product: {p.Id}, {p.Name}, {p.Price}");
            }

            var categories = database.SelectTable("category");
            foreach (Category c in categories)
            {
                Console.WriteLine($"Category: {c.Id}, {c.Name}");
            }

            var accessories = database.SelectTable("category");
            foreach (Category c in accessories)
            {
                Console.WriteLine($"Category: {c.Id}, {c.Name}, {c.Description}");
            }
        }

        //Phuong thuc UpdateTableTest
        public void UpdateTableTest()
        {
            Product updatedProduct = new Product { Id = 1, Name = "Updated Product 1", Price = 12000000 };
            database.UpdateTable("product", updatedProduct);

            Category updatedCategory = new Category { Id = 1, Name = "Updated Category 1" };
            database.UpdateTable("category", updatedCategory);

            Accessory updatedAccessory = new Accessory { Id = 1, Name = "Updated Accessory 1", Description = "Updated Description" };
            database.UpdateTable("accessory", updatedAccessory);
        }

        //Phuong thuc DeleteTableTest
        public void DeleteTableTest()
        {
            Product productToDelete = new Product { Id = 1 };
            database.DeleteTable("product", productToDelete);

            Category categoryToDelete = new Category { Id = 1 };
            database.DeleteTable("category", categoryToDelete);

            Accessory accessoryToDelete = new Accessory { Id = 1 };
            database.DeleteTable("accessory", accessoryToDelete);
        }

        //Phuong thuc TruncateTableTest
        public void TruncateTableTest()
        {
            database.TruncateTable("product");
            database.TruncateTable("category");
            database.TruncateTable("accessory");
        }

        //Phuong thuc InitDatabase
        public void InitDatabase()
        {
            for (int i = 1; i <= 10; i++)
            {
                Product product = new Product { Id = i, Name = $"Product {i}", Price = 100 + i };
                database.InsertTable("product", product);

                Category category = new Category { Id = i, Name = $"Category {i}" };
                database.InsertTable("category", category);

                Accessory accessory = new Accessory { Id = i, Name = $"Accessory {i}", Description = $"Description {i}" };
                database.InsertTable("accessory", accessory);
            }
        }

        //Phuong thuc PrintTableTest
        public void PrintTableTest(string tableName)
        {
            var records = database.SelectTable(tableName.ToLower());
            switch (tableName.ToLower())
            {
                case "product":
                    foreach (Product p in records.OfType<Product>())
                    {
                        Console.WriteLine($"Product: {p.Id}, {p.Name}, {p.Price}");
                    }
                    break;
                case "category":
                    foreach (Category c in records.OfType<Category>())
                    {
                        Console.WriteLine($"Category: {c.Id}, {c.Name}");
                    }
                    break;
                case "accessory":
                    foreach (Accessory a in records.OfType<Accessory>())
                    {
                        Console.WriteLine($"Accessory: {a.Id}, {a.Name}, {a.Description}");
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }
    }
}
