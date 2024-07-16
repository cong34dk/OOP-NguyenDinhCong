using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.DAO
{
    public class ProductDAO
    {
        private Database db;
        public ProductDAO()
        {
            db = Database.Instance;
        }

        //Phuong thuc Insert
        public int Insert(Product row)
        {
            return db.InsertTable("product", row);
        }

        public int Update(Product row)
        {
            return db.UpdateTable("product", row);
        }

        public bool Delete(Product row)
        {
            return db.DeleteTable("product", row);
        }

        public List<Product> FindAll()
        {
            return db.SelectTable("product") as List<Product>;
        }

        public Product FindById(int id)
        {
            return db.SelectTable("product", p => ((Product)p).Id == id).FirstOrDefault() as Product;
        }
    }
}
