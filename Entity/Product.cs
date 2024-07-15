using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.Entity
{
    public class Product
    {
        //Cac thuoc tinh
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int Stock {  get; set; }
        public string Description { get; set; }

        //Constructor
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

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        // Phương thức hiển thị thông tin sản phẩm
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"CategoryId: {CategoryId}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Description: {Description}");
        }
    }
}
