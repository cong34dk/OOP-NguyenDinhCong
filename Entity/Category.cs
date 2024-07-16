using System;

namespace OOP_NguyenDinhCong.Entity
{
    public class Category : BaseRow
    {
        // Constructor mặc định
        public Category() { }

        // Constructor với tham số
        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Category Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
