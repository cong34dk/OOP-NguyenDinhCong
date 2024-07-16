using OOP_NguyenDinhCong.DAO;
using OOP_NguyenDinhCong.Demo;
using OOP_NguyenDinhCong.Entity;
using System;

namespace OOP_NguyenDinhCong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tao doi tuong DAO
            ProductDAO productDAO = new ProductDAO();
            CategoryDAO categoryDAO = new CategoryDAO();
            AccessoryDAO accessoryDAO = new AccessoryDAO();

            DatabaseDemo databaseDemo = new DatabaseDemo();

            databaseDemo.InitDatabase();
            databaseDemo.PrintTableTest("product");
            productDAO.FindById(1);
            productDAO.FindAll();
           


        }
    }
}