using OOP_NguyenDinhCong.DAO;
using OOP_NguyenDinhCong.Demo;
using OOP_NguyenDinhCong.Entity;
using System;

namespace OOP_NguyenDinhCong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tao doi tuong DAO
            var productDAO = new ProductDAO();
            var categoryDAO = new CategoryDAO();
            var accessoryDAO = new AccessoryDAO();

            //Tao va chen 1 Product
            var product = new Product(1, "Laptop Asus Tuf Gaming", 1, 1500, 50, "Laptop gaming High Perfomance");
            productDAO.Insert(product);
            Console.WriteLine("Inserted Product");
            product.DisplayInfo();

            //Tao va chen 1 Category
            var category = new Category(1, "Laptop", "Laptop devices");
            categoryDAO.Insert(category);
            Console.WriteLine("Inserted Category");
            category.DisplayInfo();

            //Tao va chen 1 Accessory
            var accessory = new Accessory(1, "Mouse Asus", 1, 50, "Wireless gaming mouse");
            accessoryDAO.Insert(accessory);
            Console.WriteLine("Inserted Accessory");
            accessory.DisplayInfo();

            // Tìm tất cả Products
            var products = productDAO.FindAll();
            Console.WriteLine("\nAll Products:");
            foreach (var p in products)
            {
                p.DisplayInfo();
            }

            // Tìm Product theo Id
            var foundProduct = productDAO.FindById(1);
            Console.WriteLine("\nFound Product by Id:");
            foundProduct.DisplayInfo();

            // Xóa Product
            productDAO.Delete(product);
            Console.WriteLine("\nDeleted Product:");
            products = productDAO.FindAll();
            foreach (var p in products)
            {
                p.DisplayInfo();
            }

            // Cập nhật Category
            category.Description = "All kinds of electronic devices";
            categoryDAO.Update(category);
            Console.WriteLine("\nUpdated Category:");
            category.DisplayInfo();

            // Tìm tất cả Categories
            var categories = categoryDAO.FindAll();
            Console.WriteLine("\nAll Categories:");
            foreach (var c in categories)
            {
                c.DisplayInfo();
            }

            // Tìm Category theo Id
            var foundCategory = categoryDAO.FindById(1);
            Console.WriteLine("\nFound Category by Id:");
            foundCategory.DisplayInfo();

            // Xóa Category
            categoryDAO.Delete(category);
            Console.WriteLine("\nDeleted Category:");
            categories = categoryDAO.FindAll();
            foreach (var c in categories)
            {
                c.DisplayInfo();
            }

            // Cập nhật Accessory
            accessory.Price = 45;
            accessoryDAO.Update(accessory);
            Console.WriteLine("\nUpdated Accessory:");
            accessory.DisplayInfo();

            // Tìm tất cả Accessories
            var accessories = accessoryDAO.FindAll();
            Console.WriteLine("\nAll Accessories:");
            foreach (var a in accessories)
            {
                a.DisplayInfo();
            }

            // Tìm Accessory theo Id
            var foundAccessory = accessoryDAO.FindById(1);
            Console.WriteLine("\nFound Accessory by Id:");
            foundAccessory.DisplayInfo();

            // Xóa Accessory
            accessoryDAO.Delete(accessory);
            Console.WriteLine("\nDeleted Accessory:");
            accessories = accessoryDAO.FindAll();
            foreach (var a in accessories)
            {
                a.DisplayInfo();
            }
            Console.ReadKey();
        }

    }
}