using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.Entity
{
    public class Accessory
    {
        // Các thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Constructor mặc định
        public Accessory() { }

        // Constructor với tham số
        public Accessory(int id, string name, int productId, decimal price, string description)
        {
            Id = id;
            Name = name;
            ProductId = productId;
            Price = price;
            Description = description;
        }

        // Phương thức hiển thị thông tin phụ kiện
        public void DisplayAccessoryInfo()
        {
            Console.WriteLine($"Accessory Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Product Id: {ProductId}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}