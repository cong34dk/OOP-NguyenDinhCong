using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.Demo
{
    public class ProductDemo
    {
        // Phương thức tạo sản phẩm để kiểm tra
        public Product CreateProductTest()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Laptop",
                CategoryId = 3,
                Price = 21000000,
                Stock = 50,
                Description = "High-performance laptop with 16GB RAM and 512GB SSD."
            };

            return product;
        }

        // Phương thức in thông tin sản phẩm
        public void PrintProduct(Product product)
        {
            if (product != null)
            {
                product.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Product is null");
            }
        }
    }
}