using OOP_NguyenDinhCong.Entity;
using OOP_NguyenDinhCong.DAO;
using System;
using System.Collections.Generic;

namespace OOP_NguyenDinhCong.Demo
{
    public class CategoryDaoDemo
    {
        private CategoryDAO categoryDAO;

        public CategoryDaoDemo()
        {
            categoryDAO = new CategoryDAO();
        }

        // Phương thức insertTest: kiểm thử việc thêm một đối tượng Category
        public void InsertTest()
        {
            var category = new Category(1, "Electronics", "Electronic devices and gadgets");
            int result = categoryDAO.Insert(category);
            Console.WriteLine(result != -1 ? "Insert successful" : "Insert failed");
        }

        // Phương thức findAllTest: kiểm thử việc tìm tất cả các đối tượng Category
        public void FindAllTest()
        {
            List<Category> categories = categoryDAO.FindAll();
            Console.WriteLine("FindAll result:");
            foreach (var category in categories)
            {
                category.DisplayInfo();
            }
        }

        // Phương thức updateTest: kiểm thử việc cập nhật một đối tượng Category
        public void UpdateTest()
        {
            var category = new Category(1, "Electronics Updated", "Updated description");
            int result = categoryDAO.Update(category);
            Console.WriteLine(result != -1 ? "Update successful" : "Update failed");
        }

        // Phương thức deleteTest: kiểm thử việc xóa một đối tượng Category
        public void DeleteTest()
        {
            var category = new Category(1, "Electronics", "Electronic devices and gadgets");
            bool result = categoryDAO.Delete(category);
            Console.WriteLine(result ? "Delete successful" : "Delete failed");
        }

        // Phương thức findByIdTest: kiểm thử việc tìm một đối tượng Category theo Id
        public void FindByIdTest()
        {
            int id = 1;
            Category category = categoryDAO.FindById(id);
            if (category != null)
            {
                Console.WriteLine("FindById result:");
                category.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Category not found");
            }
        }
    }
}
