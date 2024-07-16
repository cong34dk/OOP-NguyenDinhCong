using OOP_NguyenDinhCong.Entity;
using OOP_NguyenDinhCong.Interface;
using System.Collections.Generic;
using System.Linq;

namespace OOP_NguyenDinhCong.DAO
{
    public abstract class BaseDao<T> : IDAO<T> where T : class, IEntity
    {
        protected Database db;

        protected abstract string TableName { get; }

        public BaseDao()
        {
            db = Database.Instance;
        }

        public int Insert(T entity)
        {
            return db.InsertTable(TableName, entity);
        }

        public int Update(T entity)
        {
            return db.UpdateTable(TableName, entity);
        }

        public bool Delete(T entity)
        {
            return db.DeleteTable(TableName, entity);
        }

        public List<T> FindAll()
        {
            return db.SelectTable(TableName) as List<T>;
        }

        public T FindById(int id)
        {
            return db.SelectTable(TableName, p => ((T)p).Id == id).FirstOrDefault() as T;
        }
    }
}
