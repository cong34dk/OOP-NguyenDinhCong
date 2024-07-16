using OOP_NguyenDinhCong.Entity;
using System;
using System.Collections.Generic;

namespace OOP_NguyenDinhCong.DAO
{
    public abstract class BaseDao<T>
    {
        protected Database db;

        public BaseDao()
        {
            db = Database.Instance;
        }

        // Phương thức insert: thêm một đối tượng vào Database
        public virtual int Insert(T row)
        {
            throw new NotImplementedException();
        }

        // Phương thức update: cập nhật một đối tượng trong Database
        public virtual int Update(T row)
        {
            throw new NotImplementedException();
        }

        // Phương thức delete: xóa một đối tượng từ Database
        public virtual bool Delete(T row)
        {
            throw new NotImplementedException();
        }

        // Phương thức findAll: tìm tất cả các đối tượng trong Database
        public virtual List<T> FindAll()
        {
            throw new NotImplementedException();
        }

        // Phương thức findById: tìm một đối tượng theo Id trong Database
        public virtual T FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}