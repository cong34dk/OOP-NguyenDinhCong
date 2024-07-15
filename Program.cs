using OOP_NguyenDinhCong.DAO;
using OOP_NguyenDinhCong.Entity;
using System;

namespace OOP_NguyenDinhCong
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.Instance;

            // Tạo một sản phẩm mới và thêm vào bảng Product
            Product product = new Product
            {
                Id = 1,
                Name = "Laptop",
                CategoryId = 101,
                Price = 21000000,
                Stock = 50,
                Description = "High-performance laptop with 16GB RAM and 512GB SSD."
            };
            db.InsertTable("product", product);

            // Hiển thị thông tin sản phẩm
            var products = db.SelectTable("product");
            foreach (Product p in products)
            {
                p.DisplayProductInfo();
            }

            // Cập nhật thông tin sản phẩm
            product.Price = 19900000;
            db.UpdateTable("product", product);

            // Hiển thị thông tin sản phẩm sau khi cập nhật
            products = db.SelectTable("product");
            foreach (Product p in products)
            {
                p.DisplayProductInfo();
            }

            // Xóa sản phẩm
            db.DeleteTable("product", product);

            // Hiển thị thông tin sản phẩm sau khi xóa
            products = db.SelectTable("product");
            if (products == null || products.GetEnumerator().MoveNext() == false)
            {
                Console.WriteLine("No products available.");
            }

            // Xóa toàn bộ bảng Product
            db.TruncateTable("product");

            Console.ReadLine();
        }
    }
}
