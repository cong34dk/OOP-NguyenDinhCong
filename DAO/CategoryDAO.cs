using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.DAO
{
    public class CategoryDAO
    {
        private Database db;
        public CategoryDAO()
        {
            db = Database.Instance;
        }

        //Phuong thuc Insert
        public int Insert(Category row)
        {
            return db.InsertTable("category", row);
        }

        public int Update(Category row)
        {
            return db.UpdateTable("category", row);
        }

        public bool Delete(Category row)
        {
            return db.DeleteTable("category", row);
        }

        public List<Category> FindAll()
        {
            return db.SelectTable("category") as List<Category>;
        }

        public Category FindById(int id)
        {
            return db.SelectTable("category", p => ((Category)p).Id == id).FirstOrDefault() as Category;
        }
    }
}
