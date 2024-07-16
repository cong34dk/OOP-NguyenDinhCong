using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.DAO
{
    public class AccessoryDAO
    {
        private Database db;
        public AccessoryDAO()
        {
            db = Database.Instance;
        }

        //Phuong thuc Insert
        public int Insert(Accessory row)
        {
            return db.InsertTable("accessory", row);
        }

        public int Update(Accessory row)
        {
            return db.UpdateTable("accessory", row);
        }

        public bool Delete(Accessory row)
        {
            return db.DeleteTable("accessory", row);
        }

        public List<Accessory> FindAll()
        {
            return db.SelectTable("accessory") as List<Accessory>;
        }

        public Accessory FindById(int id)
        {
            return db.SelectTable("accessory", p => ((Accessory)p).Id == id).FirstOrDefault() as Accessory;
        }
    }
}
