using System;
using OOP_NguyenDinhCong.Entity;
using OOP_NguyenDinhCong.DAO;

namespace OOP_NguyenDinhCong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo các đối tượng DAO
            CategoryDAO categoryDAO = new CategoryDAO();
            ProductDAO productDAO = new ProductDAO();
            AccessoryDAO accessoryDAO = new AccessoryDAO();

            // Thêm một vài dữ liệu vào Database để kiểm tra
            Category category1 = new Category(1, "Electronics", "Electronic devices");
            categoryDAO.Insert(category1);

            Product product1 = new Product(1, "Laptop", 1, 1500, 10, "High-performance laptop");
            productDAO.Insert(product1);

            Accessory accessory1 = new Accessory(1, "Mouse", 1, 200, "Peripheral");
            accessoryDAO.Insert(accessory1);

            // Hiển thị thông tin từ Database
            Console.WriteLine("Categories:");
            foreach (var category in categoryDAO.FindAll())
            {
                category.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("\nProducts:");
            foreach (var product in productDAO.FindAll())
            {
                product.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("\nAccessories:");
            foreach (var accessory in accessoryDAO.FindAll())
            {
                accessory.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
