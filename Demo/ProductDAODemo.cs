using OOP_NguyenDinhCong.Entity;
using OOP_NguyenDinhCong.DAO;
using System;
using System.Collections.Generic;

namespace OOP_NguyenDinhCong.Demo
{
    public class ProductDaoDemo
    {
        private ProductDAO productDAO;

        public ProductDaoDemo()
        {
            productDAO = new ProductDAO();
        }

        // Phương thức insertTest: kiểm thử việc thêm một đối tượng Product
        public void InsertTest()
        {
            var product = new Product(1, "Laptop", 1, 1000, 50, "High-end gaming laptop");
            int result = productDAO.Insert(product);
            Console.WriteLine(result != -1 ? "Insert successful" : "Insert failed");
        }

        // Phương thức findAllTest: kiểm thử việc tìm tất cả các đối tượng Product
        public void FindAllTest()
        {
            List<Product> products = productDAO.FindAll();
            Console.WriteLine("FindAll result:");
            foreach (var product in products)
            {
                product.DisplayInfo();
            }
        }

        // Phương thức updateTest: kiểm thử việc cập nhật một đối tượng Product
        public void UpdateTest()
        {
            var product = new Product(1, "Laptop Updated", 1, 1200, 45, "Updated high-end gaming laptop");
            int result = productDAO.Update(product);
            Console.WriteLine(result != -1 ? "Update successful" : "Update failed");
        }

        // Phương thức deleteTest: kiểm thử việc xóa một đối tượng Product
        public void DeleteTest()
        {
            var product = new Product(1, "Laptop", 1, 1000, 50, "High-end gaming laptop");
            bool result = productDAO.Delete(product);
            Console.WriteLine(result ? "Delete successful" : "Delete failed");
        }

        // Phương thức findByIdTest: kiểm thử việc tìm một đối tượng Product theo Id
        public void FindByIdTest()
        {
            int id = 1;
            Product product = productDAO.FindById(id);
            if (product != null)
            {
                Console.WriteLine("FindById result:");
                product.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
    }
}
