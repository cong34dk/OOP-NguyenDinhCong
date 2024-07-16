using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.DAO
{
    public class Database
    {
        //Cac thuoc tinh
        public List<Product> ProductTable { get; set; }
        public List<Category> CategoryTable { get; set; }
        public List<Accessory> AccessoryTable { get; set; }

        //Singleton Instance
        private static Database _instance;
        public static Database Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }
                return _instance;
            }
        }

        // Constructor private để ngăn tạo đối tượng bên ngoài
        private Database()
        {
            ProductTable = new List<Product>();
            CategoryTable = new List<Category>();
            AccessoryTable = new List<Accessory>();
        }

        //Phuong thuc InsertTable
        public int InsertTable(string name, object row)
        {
            switch (name.ToLower())
            {
                case "product":
                    ProductTable.Add((Product)row);
                    return ProductTable.Count - 1;
                case "category":
                    CategoryTable.Add((Category)row);
                    return CategoryTable.Count - 1;
                case "accessory":
                    AccessoryTable.Add((Accessory)row);
                    return AccessoryTable.Count - 1;

                default:
                    throw new ArgumentException("Invalid table name");
            }
        }

        //Phuong thuc SelectTable
        public IEnumerable<object> SelectTable(string name, Func<object, bool> where = null)
        {
            switch (name.ToLower())
            {
                case "product":
                    return where == null ? ProductTable : ProductTable.FindAll(new Predicate<Product>(where));
                case "category":
                    return where == null ? CategoryTable : CategoryTable.FindAll(new Predicate<Category>(where));
                case "accessory":
                    return where == null ? AccessoryTable : AccessoryTable.FindAll(new Predicate<Accessory>(where));
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }

        //Phuong thuc UpdateTable
        public int UpdateTable(string name, object row)
        {
            int index = -1;
            switch (name.ToLower())
            {
                case "product":
                    var product = (Product)row;
                    index = ProductTable.FindIndex(p => p.Id == product.Id);
                    if (index != -1) ProductTable[index] = product;
                    break;
                case "category":
                    var category = (Category)row;
                    index = ProductTable.FindIndex(c => c.Id == category.Id);
                    if (index != -1) CategoryTable[index] = category;
                    break;
                case "accessory":
                    var accessory = (Accessory)row;
                    index = ProductTable.FindIndex(a => a.Id == accessory.Id);
                    if (index != -1) AccessoryTable[index] = accessory;
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }
            return index;
        }

        //Phuong thuc UpdateTableById
        public int UpdateTableById(string name, int id, object row)
        {
            int index = -1;
            switch (name.ToLower())
            {
                case "product":
                    index = ProductTable.FindIndex(p => p.Id == id);
                    if (index != -1) ProductTable[index] = (Product)row;
                    break;
                case "category":
                    index = CategoryTable.FindIndex(c => c.Id == id);
                    if (index != -1) CategoryTable[index] = (Category)row;
                    break;
                case "accessory":
                    index = AccessoryTable.FindIndex(a => a.Id == id);
                    if (index != -1) AccessoryTable[index] = (Accessory)row;
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }
            return index;
        }

        //Phuong thuc DeleteTable
        public bool DeleteTable(string name, object row)
        {
            bool removed = false;
            switch (name.ToLower())
            {
                case "product":
                    var product = (Product)row;
                    removed = ProductTable.Remove(ProductTable.Find(p => p.Id == product.Id));
                    break;
                case "category":
                    var category = (Category)row;
                    removed = CategoryTable.Remove(CategoryTable.Find(c => c.Id == category.Id));
                    break;
                case "accessory":
                    var accessory = (Accessory)row;
                    removed = AccessoryTable.Remove(AccessoryTable.Find(a => a.Id == accessory.Id));
                    break;
                default:
                    throw new ArgumentException("Invalid table name");
            }
            return removed;
        }

        //Phuong thuc TruncateTable
        public void TruncateTable(string name)
        {
            switch (name.ToLower())
            {
                case "product":
                    ProductTable.Clear();
                    break;
                case "category":
                    CategoryTable.Clear();
                    break;
                case "accessory":
                    AccessoryTable.Clear();
                    break;
                default :
                    throw new ArgumentException("Invalid table name");
            }
        }
    }
}
