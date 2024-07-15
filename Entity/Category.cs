using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.Entity
{
    public class Category
    {
        // Các thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Constructor mặc định
        public Category() { }

        // Constructor với tham số
        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        // Phương thức hiển thị thông tin danh mục
        public void DisplayCategoryInfo()
        {
            Console.WriteLine($"Category Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
