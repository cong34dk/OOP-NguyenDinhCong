using OOP_NguyenDinhCong.Interface;
using System;

namespace OOP_NguyenDinhCong.Entity
{
    public class Product : BaseRow, IEntity
    {
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product() { }

        public Product(int id, string name, int categoryId, int price, int stock, string description)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Price = price;
            Stock = stock;
            Description = description;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CategoryId: {CategoryId}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine();
        }
    }
}
