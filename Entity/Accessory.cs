using System;

namespace OOP_NguyenDinhCong.Entity
{
    public class Accessory : BaseRow
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }

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

        public override void DisplayInfo()
        {
            Console.WriteLine($"Accessory Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Product Id: {ProductId}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
