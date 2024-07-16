using OOP_NguyenDinhCong.Entity;
using OOP_NguyenDinhCong.Interface;
using System.Collections.Generic;

namespace OOP_NguyenDinhCong.DAO
{
    public interface IDAO<T> where T : IEntity
    {
        int Insert(T entity);
        int Update(T entity);
        bool Delete(T entity);
        List<T> FindAll();
        T FindById(int id);
    }
}
